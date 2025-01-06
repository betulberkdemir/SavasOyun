using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    internal class KFS : KaraArac
    {
        public override AltSinif Altsinif { get; set; }
        public override int DenizVurusAvantaji { get; set; }
        public override int Dayaniklilik { get ; set; }
        public override int Vurus { get; set; }
        public int HavaVurusAvantaji { get; set; }

        

        
        public KFS (int seviye = 0 ) : base(seviye)
        {

            Altsinif = AltSinif.KFS;
            DenizVurusAvantaji = 10;
            Dayaniklilik = 20;
            Vurus = 10;
            HavaVurusAvantaji = 20;
            

        }


        public void GuncelPuanGoster()
        {
            KartPuaniGoster(); // Base class'ın metodunu çağır
        }

        public override void DayaniklilikGuncelle(int alinanHasar)
        {
            Dayaniklilik -= alinanHasar;
        }

        public override int VurusHesapla(Sinif rakipSinifi)
        {
            int hesaplananVurus = base.VurusHesapla(rakipSinifi);
            if(rakipSinifi == Sinif.Hava)
            {
                hesaplananVurus += HavaVurusAvantaji;
            }
            return hesaplananVurus;

        }
    }
}
