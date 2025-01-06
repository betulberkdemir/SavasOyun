using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    public class Firkateyn : DenizArac
    {
        public override AltSinif Altsinif { get ; set ; }
        public override int HavaVurusAvantaji { get ; set; }
        public override int Dayaniklilik { get; set; }
        public override int Vurus { get; set; }

        public Firkateyn(int seviye = 0) : base(seviye)
        {
            Sinif = Sinif.Deniz;
            Altsinif = AltSinif.Firkateyn;
            Dayaniklilik = 25;
            Vurus = 10;
            HavaVurusAvantaji = 5;

        }

        public override void DayaniklilikGuncelle(int alinanHasar)
        {
            Dayaniklilik -= alinanHasar;
        }

        //Burada override etmemize gerek yok çünkü buradaki somutlaştırılan HavaVurusAvantaji,
        //DenizArac ata sınıfında soyut halde erişilebilir durumda.
        //Kod kalabalığı yapmamak için DenizArac.VurusHesapla(Sinif) fonksitonu bizim için kullanıbilir durumda.
    }
}
