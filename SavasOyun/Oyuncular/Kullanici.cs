using SavasOyun.Araclar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyun.Oyuncular
{

    public class Kullanici : Oyuncu
    {
        //KULLANİCİ OYUNCU SINIFINI MİRAS ALIR

        //BELLİ SEVİYEYE ULAŞTIĞINDA 20 VE ÜZERİ SİHA SİDA KFS KARTLARI AÇILIR.
        
        //KULLANİCİ BAŞLANGIÇTA 3 KART SEÇER
        public Kullanici(int id, string name) : base(id, name)
        {
            IsComputer = false;
        }

        public override SavasArac KartSec(int index = 0)
        {
            var kart = KartListesi[index];
            kart.KartDurumu = KartDurumu.Yerde;
            return kart;
        }

   
    }
}
 