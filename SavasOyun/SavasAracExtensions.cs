using SavasOyun.Araclar;
using SavasOyun.Oyuncular;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun
{
    public enum SavasSonucu
    {
        YokOldular,
        Beraberlik,
        Arac1Kazandi,
        Arac2Kazandi,
    }
    public static class SavasAracExtensions
    {
        public static readonly Random Random = new Random();


        //karttutucu ve karttutucukucuk bu static metodu kullanarak kartın adını ve resmini alıyor
        public static (string, Image) GetKartAdiVeResim(SavasArac savasArac)
        {
            string kartAdi = null;
            Image kartResmi = null;

            switch (savasArac.Altsinif)
            {
                case AltSinif.Obus:
                    kartAdi = "Obus";
                    kartResmi = Properties.Resources.obus;
                    break;
                case AltSinif.Firkateyn:
                    kartAdi = "Firkateyn";
                    kartResmi = Properties.Resources.firkateyn;
                    break;
                case AltSinif.Ucak:
                    kartAdi = "Ucak";
                    kartResmi = Properties.Resources.plane;
                    break;
                case AltSinif.KFS:
                    kartAdi = "KFS";
                    kartResmi = Properties.Resources.kfs;
                    break;
                case AltSinif.Sida:
                    kartAdi = "Sida";
                    kartResmi = Properties.Resources.sida;
                    break;
                case AltSinif.Siha:
                    kartAdi = "Siha";
                    kartResmi = Properties.Resources.siha;
                    break;
                default:
                    break;
            }

            return (kartAdi, kartResmi);
        }
        //form'da rastgele kart oluşturup kullanıcın kartlarına ekle.
        //altı tane kücük kart var bu kartları rastgele kullanıcıya ve bilgisayara gönder hamle bittikten sonra
        public static SavasArac RasgeleKartOlustur(bool ozelKartDahil, int seviye = 0)
        {
            int cardTipi = ozelKartDahil ? Random.Next(0, 6) : Random.Next(0, 3);
            // if (ozelKartDahil)
            //      cardTipi = Random.Next(0, 6); 
            // else
            //      cardTipi = Random.Next(0, 3);

            switch((AltSinif)cardTipi)
            {
                case AltSinif.Obus:
                    return new Obus(seviye);
                case AltSinif.Firkateyn:
                    return new Firkateyn(seviye);
                case AltSinif.Ucak:
                    return new Ucak(seviye);
                case AltSinif.KFS:  
                    return new KFS(seviye);
                case AltSinif.Sida:
                    return new Sida(seviye);
                case AltSinif.Siha:
                    return new Siha(seviye);
                default:
                    return null;
            }
        }

        //kartları savaştır ve total dmg'e (label) gönder.
        public static SavasSonucu KartlariSavastir(SavasArac arac1, SavasArac arac2)
        {
            // TODO: kart savaşma mekaniği
            //kartlarıın birbirine olan hasarını hesapla arac1.VurusHesapla
            //kartın dayanık ve rakibe olan hasar değerlerinden en küçük olanı al
            //bu değeri rakibe vur arac1.DayaniklilikGuncelle
            //eğer bir kart diğerini öldürse onun seviyesini alır 

            int vurus1 = arac1.VurusHesapla(arac2.Sinif);
            int vurus2 = arac2.VurusHesapla(arac1.Sinif);
            //can = dayanıklılık küçük olanı aldım.
            int mumkunOlanVurus1 = Math.Min(vurus1, arac1.Dayaniklilik);
            int mumkunOlanVurus2 = Math.Min(vurus2, arac2.Dayaniklilik);
            //vuruş yaptım
            arac1.DayaniklilikGuncelle(mumkunOlanVurus2);
            arac2.DayaniklilikGuncelle(mumkunOlanVurus1);

            
            if (arac1.Dayaniklilik <= 0 && arac2.Dayaniklilik <= 0)
                return SavasSonucu.YokOldular;
            else if (arac1.Dayaniklilik <= 0)
                return SavasSonucu.Arac2Kazandi;
            else if (arac2.Dayaniklilik <= 0)
                return SavasSonucu.Arac1Kazandi;
            else
                return SavasSonucu.Beraberlik;
        }

        public static void Test()
        {
            Oyuncu kullanici = new Kullanici(1,"");
            Oyuncu bilgisayar = new Bilgisayar();

            var arac1 = bilgisayar.KartSec();
            var arac2 = kullanici.KartSec(1); // bu sayı tıkladığı kartın indexi olmalı

            SavasSonucu sonuc = KartlariSavastir(arac1, arac2);

            switch (sonuc)
            {
                case SavasSonucu.YokOldular:
                    kullanici.KartYokEt(arac2);
                    bilgisayar.KartYokEt(arac1);
                    break;
                case SavasSonucu.Beraberlik:

                    //kart durumunu güncelle kullanıcı ve bilgisayar için,
                    kullanici.KartSec();//kart durumu yerde olmuş oluyor
                    bilgisayar.KartSec();//kart durumu rastgele seçip yerde olmuş oluyor
                    break;

                case SavasSonucu.Arac1Kazandi:

                    kullanici.KartCekme(); //rasgele kart çekip listeye ekler
                    bilgisayar.KartCekme();//rasgele kart çekip listeye ekler
                    break;

                case SavasSonucu.Arac2Kazandi:

                    kullanici.KartCekme();
                    bilgisayar.KartCekme();

                    break;
            }
        }
    }
}
