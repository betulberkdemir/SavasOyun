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
        //BİLGİSAYAR OYUNCU SINIFINI MİRAS ALIR
        
        //BİLGİSAYAR SEVİYE NERDE(OYUNCU SINIFINDA)
        public Bilgisayar(): base(-1, "Bilgisayar") // oyuncu id'ye neden -1 verdik, oyuncu adı
        {
            IsComputer = true;
        }

        //BİLGİSAYAR BAŞLANGIÇTA 3 KART SEÇER 
        // SEVİYE=>20 İSE SİHA SİDA KFS EKLENİR


        //ÖZEL KART DURUMU NASIL EKLİCEM???

        //bilgisayar rastgele seçip 
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
