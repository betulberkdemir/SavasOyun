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
        public abstract string Altsinif { get; set; }
        public abstract string DenizVurusAvantaji { get; set; }
        public KaraArac(int seviye = 0) : base(seviye)
        {
            Sinif = Sinif.Kara;
        }
    }
}
