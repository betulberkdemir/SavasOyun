using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    public class Ucak : HavaArac
    {
        public override AltSinif Altsinif { get; set; }
        public override int KaraVurusAvantaji { get; set; }
        public override int Dayaniklilik { get; set; }
        public override int Vurus { get; set; }

        public Ucak(int seviye = 0):base(seviye)
        {
            Altsinif = AltSinif.Ucak;
            KaraVurusAvantaji = 10;
            Dayaniklilik = 20;
            Vurus = 10;
        }

        public override void DurumGuncelle(int alinanHasar)
        {
            Dayaniklilik -= alinanHasar;
        }
    }
}
