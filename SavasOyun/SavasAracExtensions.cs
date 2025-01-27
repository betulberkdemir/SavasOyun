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
        BilgisayarKazandi,
        OyuncuKazandi,
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
        public static (SavasSonucu Sonuc, int Skor) KartlariSavastir(KartTutucu bilgisayar, KartTutucu oyuncu)
        {
            // TODO: kart savaşma mekaniği
            //kartlarıın birbirine olan hasarını hesapla arac1.VurusHesapla
            //kartın dayanık ve rakibe olan hasar değerlerinden en küçük olanı al
            //bu değeri rakibe vur arac1.DayaniklilikGuncelle
            //eğer bir kart diğerini öldürse onun seviyesini alır

            var bilgisayarKart = bilgisayar.SavasKarti;
            var oyuncuKart = oyuncu.SavasKarti;

            int bilgisayarVurus = bilgisayarKart.VurusHesapla(oyuncuKart.Sinif);
            int oyuncuVurus = oyuncuKart.VurusHesapla(bilgisayarKart.Sinif);

            //can = dayanıklılık küçük olanı aldım.
            int mumkunOlanVurusBilgisayar = Math.Min(bilgisayarVurus, bilgisayarKart.Dayaniklilik);
            int mumkunOlanVurusOyuncu = Math.Min(oyuncuVurus, oyuncuKart.Dayaniklilik);

            bilgisayar.SetTotalDamage(mumkunOlanVurusBilgisayar); //total dmg'e yazdır
            oyuncu.SetTotalDamage(mumkunOlanVurusOyuncu); //total dmg'e yazdır

            //vuruş yaptım
            bilgisayarKart.DayaniklilikGuncelle(mumkunOlanVurusOyuncu);
            oyuncuKart.DayaniklilikGuncelle(mumkunOlanVurusBilgisayar);

            bilgisayar.SetDurability(bilgisayarKart.Dayaniklilik);
            oyuncu.SetDurability(oyuncuKart.Dayaniklilik);

            if (bilgisayarKart.Dayaniklilik <= 0 && oyuncuKart.Dayaniklilik <= 0)
                return (SavasSonucu.YokOldular, 0);


            else if (bilgisayarKart.Dayaniklilik <= 0)
            {
                int oSkor = Math.Max(bilgisayarKart.Seviye, 10);
                oyuncuKart.Seviye += oSkor;
                oyuncu.SetLevel(oyuncuKart.Seviye);
                return (SavasSonucu.OyuncuKazandi, oSkor);
            }


            else if (oyuncuKart.Dayaniklilik <= 0)
            {
                int oSkor = Math.Max(oyuncuKart.Seviye, 10);
                bilgisayarKart.Seviye += oSkor;
                bilgisayar.SetLevel(bilgisayarKart.Seviye);
                return (SavasSonucu.BilgisayarKazandi, oSkor);
            }
            else
                return (SavasSonucu.Beraberlik, 0);
        }

        public static void Test()
        {
            //Oyuncu kullanici = null;/*new Kullanici(1,"");*/
            //Oyuncu bilgisayar = null;

            //var arac1 = bilgisayar.KartSec();
            //var arac2 = kullanici.KartSec(1); // bu sayı tıkladığı kartın indexi olmalı

            //SavasSonucu sonuc = KartlariSavastir(arac1, arac2);

            //switch (sonuc)
            //{
            //    case SavasSonucu.YokOldular:
            //        kullanici.KartYokEt(arac2);
            //        bilgisayar.KartYokEt(arac1);
            //        break;
            //    case SavasSonucu.Beraberlik:

            //        //kart durumunu güncelle kullanıcı ve bilgisayar için,
            //        kullanici.KartSec();//kart durumu yerde olmuş oluyor
            //        bilgisayar.KartSec();//kart durumu rastgele seçip yerde olmuş oluyor
            //        break;

            //    case SavasSonucu.BilgisayarKazandi:

            //        kullanici.KartCekme(); //rasgele kart çekip listeye ekler
            //        bilgisayar.KartCekme();//rasgele kart çekip listeye ekler
            //        break;

            //    case SavasSonucu.OyuncuKazandi:

            //        kullanici.KartCekme();
            //        bilgisayar.KartCekme();

            //        break;
            //}
        }
    }
}
