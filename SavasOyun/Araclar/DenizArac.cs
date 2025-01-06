using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    public abstract class DenizArac : SavasArac
    {
        public override Sinif Sinif { get ; set; }
        public abstract int HavaVurusAvantaji { get; set; }
        public DenizArac(int Seviye = 0) : base(Seviye)
        {
            Sinif = Sinif.Deniz;
        }

        public override int VurusHesapla(Sinif rakipSinifi)
        {
            // Burada override ederek ezdiğimiz SavasAraci.VurusHesapla(Sinif) methodundan,
            // Vurus değerini alıp hava vuruşunu eğer gerekli ise hesaplıyoruz.
            int vurusHasar = base.VurusHesapla(rakipSinifi);
            if (rakipSinifi == Sinif.Hava)
            {
                vurusHasar += HavaVurusAvantaji;
            }
            return vurusHasar;
        }

    }

}
