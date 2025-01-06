using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    public class Obus : KaraArac
    {
        public override AltSinif Altsinif { get ; set ; }
        public override int DenizVurusAvantaji { get ; set; }
        public override int Dayaniklilik { get ; set ; }
        public override int Vurus { get ; set ; }


        
        public Obus(int seviye = 0) : base(seviye) {

            Altsinif = AltSinif.Obus;
            DenizVurusAvantaji = 10;
            Dayaniklilik = 20;
            Vurus = 10;
            DenizVurusAvantaji = 5;

        }

        public override void DayaniklilikGuncelle(int alinanHasar)
        {
            Dayaniklilik -= alinanHasar;
        }


        //Burada vurusHesapla fonksiyonunu override etmemize gerek yok
    }
}
