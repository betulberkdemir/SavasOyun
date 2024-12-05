using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    public abstract class SavasArac
    {
        //somut
        public int Seviye { get; set; }

        //soyut
        public abstract int Dayaniklilik { get; set; }
        public abstract int Vurus { get; set; }
        public abstract Sinif Sinif { get; set; }
        
        //ctor
        public SavasArac(int seviye = 0)
        {
        }

        //somut
        public void KartPuaniGoster()
        {
            //dayanıklılık ve seviye puani göster
            Console.WriteLine($"Dayanıklılık: {Dayaniklilik}, SeviyePuanı: {Seviye}");
        }

        //soyut
        public abstract void DurumGuncelle(int alinanHasar);
    }
}








