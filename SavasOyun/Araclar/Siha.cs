﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Araclar
{
    public class Siha: HavaArac
    {
        public override AltSinif Altsinif { get; set; }
        public override int KaraVurusAvantaji { get; set; }
        public override int Dayaniklilik { get; set; }
        public override int Vurus { get; set; }

        public int DenizVurusAvantaji { get; set; }

        public Siha(int seviye = 0) : base(seviye)
        {
            Altsinif = AltSinif.Siha;
            KaraVurusAvantaji = 10;
            Dayaniklilik = 15;
            Vurus = 10;
            DenizVurusAvantaji = 10;
        }

        public override void DayaniklilikGuncelle(int alinanHasar)
        {
            Dayaniklilik -= alinanHasar;
        }

        public override int VurusHesapla(Sinif rakipSinifi)
        {
            int hesaplananVurus = base.VurusHesapla(rakipSinifi);

            if(rakipSinifi == Sinif.Deniz)
            {
                hesaplananVurus += DenizVurusAvantaji;
            }
            return hesaplananVurus;
        }
    }
}
