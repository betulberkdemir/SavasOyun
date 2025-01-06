using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    public abstract class KaraArac : SavasArac
    {
        public override Sinif Sinif { get; set; }
        public abstract int DenizVurusAvantaji { get; set; }
        public KaraArac(int seviye = 0) : base(seviye)
        {
            Sinif = Sinif.Kara;
        }



        public override int VurusHesapla(Sinif rakipSinifi)
        {
            int vurusHasar = base.VurusHesapla(rakipSinifi);

            if(rakipSinifi == Sinif.Deniz)
            {
                vurusHasar += DenizVurusAvantaji;
            }
            return vurusHasar;
        }


    }
}
