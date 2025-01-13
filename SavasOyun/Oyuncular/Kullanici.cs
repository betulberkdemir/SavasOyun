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
        private List<KartTutucuKucuk> _holders;



        //BELLİ SEVİYEYE ULAŞTIĞINDA 20 VE ÜZERİ SİHA SİDA KFS KARTLARI AÇILIR.
        //KULLANİCİ BAŞLANGIÇTA 3 KART SEÇER
        public Kullanici(int id, string name, List<KartTutucuKucuk> holders) : base(id, name)
        {
            IsComputer = false;
            _holders = holders;
            UpdateKartTutucuKucukElements();
        }

        public override SavasArac KartSec(int index = 0)
        {
            var kart = KartListesi[index];
            kart.KartDurumu = KartDurumu.Yerde;
            return kart;
        }

        private void UpdateKartTutucuKucukElements()
        {
            if (_holders is null)
                return;

            for (int i = 0; i < KartListesi.Count; i++)
            {
                _holders[i].SavasKarti = KartListesi[i];
            }
        }

        protected override void InsertKart(SavasArac kart)
        {
            base.InsertKart(kart);
            UpdateKartTutucuKucukElements();
        }

        protected override void RemoveKart(SavasArac kart)
        {
            base.RemoveKart(kart);
            UpdateKartTutucuKucukElements();
        }
    }
}
 