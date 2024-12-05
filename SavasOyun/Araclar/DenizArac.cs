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
        public abstract string Altsinif { get; set; }
        public abstract string HavaVurusAvantaji { get; set; }
        public DenizArac(int Seviye = 0) : base(Seviye)
        {
            Sinif = Sinif.Deniz;
        }



    }

}
