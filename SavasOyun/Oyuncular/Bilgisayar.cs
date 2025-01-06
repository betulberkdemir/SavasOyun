using SavasOyun.Araclar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Oyuncular
{
    public class Bilgisayar : Oyuncu
    {
        public Bilgisayar(): base(-1, "Bilgisayar")
        {
            IsComputer = true;
        }


        public override SavasArac KartSec(int index = 0)
        {
            SavasArac kart;

            do
            {
                index = SavasAracExtensions.Random.Next(0, KartListesi.Count);
                kart = KartListesi[index];
            } while (kart.KartDurumu == KartDurumu.Yerde);

            kart.KartDurumu = KartDurumu.Yerde;
            return kart;
        }

    }

    
}
