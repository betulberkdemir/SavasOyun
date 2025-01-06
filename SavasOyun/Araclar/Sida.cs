using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    internal class Sida : DenizArac
    {
        public override AltSinif Altsinif { get; set; }
        public override int HavaVurusAvantaji { get; set; }
        public override int Dayaniklilik { get; set ; }
        public override int Vurus { get ; set ; }

        public int KaraVurusAvantaji {  get; set; }

        public Sida(int seviye = 0): base(seviye) {
            Altsinif = AltSinif.Sida;
            HavaVurusAvantaji = 10;
            Dayaniklilik = 20;
            Vurus = 10;
            KaraVurusAvantaji = 20;
            


        }

        public override void DayaniklilikGuncelle(int alinanHasar)
        {
            Dayaniklilik -= alinanHasar;
        }

        public override int VurusHesapla(Sinif rakipSinifi)
        {
            //Burada override ederek ezdiğimiz DenizArac.VurusHesapla(Sinif) methodundan,
            //hava vuruşu hesaplanmış halini alıp kara vuruşunu eğer gerekli ise hesaplıyoruz.
            int havaHesaplanmisHasar = base.VurusHesapla(rakipSinifi);
            if(rakipSinifi == Sinif.Kara)
            {
                havaHesaplanmisHasar += KaraVurusAvantaji;
            }
            return havaHesaplanmisHasar;
        }
    }
}
