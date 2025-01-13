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

        public KartDurumu KartDurumu { get; set; }

        //soyut
        public abstract int Dayaniklilik { get; set; }
        public abstract int Vurus { get; set; }
        public abstract Sinif Sinif { get; set; }
        public abstract AltSinif Altsinif { get; set; }

        //kartta otomatik görünmesi için ekledim.
        //başka sınıfta override edip constructor ile değer vermem gerekiyor.

        //public abstract int DenizAvantaji {  get; set; }
        //public abstract int KaraAvantaji { get; set; }

        //public abstract int HavaAvantaji {  get; set; }




        //ctor
        public SavasArac(int seviye = 0)
        {
            KartDurumu = KartDurumu.Elde;
        }

        //somut
        public void KartPuaniGoster()
        {
            //dayanıklılık ve seviye puani göster
            Console.WriteLine($"Dayanıklılık: {Dayaniklilik}, SeviyePuanı: {Seviye}");
        }

        //soyut
        public abstract void DayaniklilikGuncelle(int alinanHasar);

        //sanal
        public virtual int VurusHesapla(Sinif rakipSinifi)
        {
            // Burada virtual tanımlamamızın sebebi her kartın bu metodu gerekirse override edip hasar hesaplama mantığını değiştirmesini sağlamaktır.
            // Burada abstract tanımla mı yoruz çünkü her kart ortak olarak varsayılan vuruş hasarına sahiptir, bizde onu döndürüyoruz.
            return Vurus;
        }
    }
}








