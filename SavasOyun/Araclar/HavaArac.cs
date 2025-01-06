using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    public abstract class HavaArac : SavasArac
    {
        //soyut -> somut (override etme)
        public override Sinif Sinif { get; set; }

        //soyut
        public abstract int KaraVurusAvantaji { get; set; }
        
        public HavaArac(int seviye = 0) : base(seviye)
        {
            Sinif = Sinif.Hava;
        }

        public override int VurusHesapla(Sinif rakipSinifi)
        {
            int anaHasar = base.VurusHesapla(rakipSinifi);
            
            if(rakipSinifi == Sinif.Kara)
            {
                anaHasar += KaraVurusAvantaji;

            }
            return anaHasar;
        }

    }
}
