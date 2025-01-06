using SavasOyun.Araclar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Oyuncular
{
    public abstract class Oyuncu
    {
        public int Skor {  get; set; }
        public int OyuncuID { get; }
        public string OyuncuAdi { get; }
        public bool IsComputer { get; protected set; }
        public bool OzelAraclarAktif => Skor >= 20;

        public List<SavasArac> KartListesi {  get; set; }
         
        public Oyuncu(int oyuncuId, string oyuncuAdi)
        {
            OyuncuID = oyuncuId;
            OyuncuAdi = oyuncuAdi;
        }


        public void SkorGoster()
        {
            Console.WriteLine($"Skor: {Skor}");
        }

        public void KartCekme()
        {
            SavasArac kart = SavasAracExtensions.RasgeleKartOlustur(OzelAraclarAktif);
            KartListesi.Add(kart);
        }

        public abstract SavasArac KartSec(int index = 0); //

        public void KartYokEt(SavasArac kart)
        {
            KartListesi.Remove(kart);

        }
    }

    
    
}
