using SavasOyun.Araclar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavasOyun.Oyuncular
{
    public abstract class Oyuncu
    {
        //BİLGİSAYAR VE KULLANİCİ İÇİN DEĞİŞKENLER
        public int Skor {  get; set; } //BAŞLANGIÇ SEVİYESİ SIFIR 
        public int OyuncuID { get; }
        public string OyuncuAdi { get; }
        public bool IsComputer { get; protected set; } 

        //BELLİ SEVİYEYE ULAŞTIĞINDA 20 VE ÜZERİ SİHA SİDA KFS KARTLARI AÇILIR.

        //OYUNCU VEYA BİLGİSAYARIN KARTI TÜKENDİĞİNDE ELİNDE BİR KARTI OLANA 2 KART VERİLİR 3 KART İLE SON EL OYNANIR
        public bool OzelAraclarAktif => Skor >= 20;

        //public List<SavasArac> KartListesi {  get; set; }
        public List<SavasArac> KartListesi { get; set; } = new List<SavasArac>();
         
        public Oyuncu(int oyuncuId, string oyuncuAdi)
        {
            OyuncuID = oyuncuId;
            OyuncuAdi = oyuncuAdi;
            for (int i = 0; i < 6; i++)
            {
                KartCekme();
            }
        }

        //savaş başladığında her bir tur tamamlandıktan sonra sonucu textlevel'de göster.
        
        //her tur tamamlandığında skorları göster bu texbox'da göster.

        public void SkorGoster(TextBox textBox)
        {
            textBox.Text = Skor.ToString();
        }
       


        //VOİD = HİÇ dönüş değeri türü beklentim yok
        public void KartCekme()
        {
            SavasArac kart = SavasAracExtensions.RasgeleKartOlustur(OzelAraclarAktif);
            InsertKart(kart);
        }

        //SavasArac: Bu metodun dönüş türüdür. Yani, bu metod bir SavasArac nesnesi döner. 
        //Varsayılan index değer olarak 0 atanmıştır. Ancak, metodun içinde bu parametre genellikle rastgele bir değer alır.


        //abstract olarak başlattık kullanici ve bilgisayar sınıfında doldurduk.
        public abstract SavasArac KartSec(int index = 0); 

        public void KartlariYokEt()
        {
            foreach (var kart in KartListesi.Where(x => x.Dayaniklilik <= 0).ToList())
            {
                RemoveKart(kart);
            }
        }

        protected virtual void InsertKart(SavasArac kart)
        {
            KartListesi.Add(kart);
        }

        protected virtual void RemoveKart(SavasArac kart)
        {
            KartListesi.Remove(kart);
        }


    }
}
