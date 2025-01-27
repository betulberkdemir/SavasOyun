using SavasOyun.Araclar;
using SavasOyun.Oyuncular;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavasOyun
{
    public partial class Form1 : Form
    {
        private Oyuncu kullanici;
        private Oyuncu bilgisayar;
        private bool sonTur = false;
        private int tur = 0;
        private int MaxTur => Convert.ToInt32(TxtMaxTur.Text);
        private int Tur
        {
            get => tur;
            set
            {
                tur = value;
                TxtTur.Text = tur.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
            // kullanıcıları ve destelerini oluştur
            // oyuncunun kartlarını bir yere kat
            this.Size = new Size(850, 1000);
            // form 1121; 1102 ()

            // Create Bilgisayar object
            bilgisayar = new Bilgisayar();

            // Create Player object
            kullanici = new Kullanici(1, "Kullanıcı", 
                new List<KartTutucuKucuk>
                {
                    kartTutucuKucuk1,
                    kartTutucuKucuk2,
                    kartTutucuKucuk3,
                    kartTutucuKucuk4,
                    kartTutucuKucuk5,
                    kartTutucuKucuk6
                });

            Tur++;
        }

        private void arena_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).Tag);

            //kartı kullanıcı seçti
            SavasArac kart = kullanici.KartSec(id);

            // kartın durumunu kontrol et
            if (kart.KartDurumu == KartDurumu.Yerde)
            {
                DoluKutucuguBosalt(id);
                kart.KartDurumu = KartDurumu.Elde;
                ((Kullanici)kullanici).UpdateKartTutucuKucukElements();
                ((Button)sender).Text = "Arena";
            }
            else if (kart.KartDurumu == KartDurumu.Elde)
            {
                KartTutucu bosKutucuk = BosKutucuguGetir();
                if (bosKutucuk == null)
                    return;

                bosKutucuk.SavasKarti = kart;
                bosKutucuk.Tag = id;

                kart.KartDurumu = KartDurumu.Yerde;
                ((Kullanici)kullanici).UpdateKartTutucuKucukElements();
                ((Button)sender).Text = "El";
            }   
        }

        // Arena için boş ve dolu kutucukları kontrol et
        private void DoluKutucuguBosalt(int id)
        {
            if(kartTutucu4.Tag != null && (int)kartTutucu4.Tag == id)
            {
                kartTutucu4.SavasKarti = null;
                kartTutucu4.Tag = null;
            }
            else if (kartTutucu5.Tag != null && (int)kartTutucu5.Tag == id)
            {
                kartTutucu5.SavasKarti = null;
                kartTutucu5.Tag = null;
            }
            else if (kartTutucu6.Tag != null && (int)kartTutucu6.Tag == id)
            {
                kartTutucu6.SavasKarti = null;
                kartTutucu6.Tag = null;
            }
        }

        private KartTutucu BosKutucuguGetir()
        {
            if (kartTutucu4.SavasKarti == null)
                return kartTutucu4;
            if (kartTutucu5.SavasKarti == null)
                return kartTutucu5;
            if (kartTutucu6.SavasKarti == null)
                return kartTutucu6;

            return null;
        }

        private void Fight_Click(object sender, EventArgs e)
        {
            if(BosKutucuguGetir() != null)
            {
                MessageBox.Show("Lütfen tüm kartları arenaya yerleştirin.");
                return;
            }


            SavasArac kart1 = bilgisayar.KartSec();
            SavasArac kart2 = bilgisayar.KartSec();
            SavasArac kart3 = bilgisayar.KartSec();

            kartTutucu1.SavasKarti = kart1;
            kartTutucu2.SavasKarti = kart2;
            kartTutucu3.SavasKarti = kart3;

            var sonuc = SavasAracExtensions.KartlariSavastir(kartTutucu1, kartTutucu4);
            var sonuc2 = SavasAracExtensions.KartlariSavastir(kartTutucu2, kartTutucu5);
            var sonuc3 = SavasAracExtensions.KartlariSavastir(kartTutucu3, kartTutucu6);

           
            SonucuIsle(sonuc);
            SonucuIsle(sonuc2);
            SonucuIsle(sonuc3);

            kullanici.SkorGoster(UserScore);
            bilgisayar.SkorGoster(CompScore);
            FightBtn.Enabled = false;
            StartBtn.Enabled = true;
        }


        // bu fonksiyon kazanana kazandığı puanı vermelidir (sonuca bakarak kazanan belirlenir, skor'a bakarak puan verilir)
        // bu fonksiton textbox1 ve textbox2 ye skorun güncel halini yazdırmalıdır
        private void SonucuIsle((SavasSonucu Sonuc, int Skor) sonuc)
        {
            switch (sonuc.Sonuc)
            {
                case SavasSonucu.Beraberlik:
                    MessageBox.Show("Berabere");
                    break;

                case SavasSonucu.BilgisayarKazandi:
                    bilgisayar.Skor += sonuc.Skor;
                    MessageBox.Show("Bilgisayar Kazandı");
                    break;

                case SavasSonucu.OyuncuKazandi:
                    kullanici.Skor += sonuc.Skor;
                    MessageBox.Show("Oyuncu Kazandı");
                    break;

                case SavasSonucu.YokOldular:
                    MessageBox.Show("Yok oldular");
                    break;
            }
        }


        private void Start_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            //tur kontrolü yapılacak eğer tur eşik değere ulaştıysa message box gösterilip oyun kapatılacak.//
            ///////////////////////////////////////////////////////////////////////////////////////////////////

            bilgisayar.KartlariYokEt();
            kullanici.KartlariYokEt();


            if (MaxTur == Tur) // eğer son tur ise puan kontrolü yapılır
                               // eğer oyuncunun kartları bitmiş ise bilgisayar kazanır
                               // eğer bilgisayarın kartları bitmiş ise oyuncu kazanır
                               // eğer her ikisinin kartları bitmiş ise puan kontrolü yapılır
            {
                if (kullanici.Skor > bilgisayar.Skor)
                    MessageBox.Show("Oyun bitti.Oyuncu kazandı.");
                else if (kullanici.Skor < bilgisayar.Skor)
                    MessageBox.Show("Bilgisayar kazandı.");
                else
                    MessageBox.Show("Oyun berabere bitti.");

                StartBtn.Enabled = false;
                return;
            }


            if(bilgisayar.KartListesi.Count == 1)
            {
                bilgisayar.KartCekme();
                sonTur = true;
            }
            if (bilgisayar.KartListesi.Count < 6)
            {
                bilgisayar.KartCekme();
            }

            if (kullanici.KartListesi.Count == 1)
            {
                kullanici.KartCekme();
                sonTur = true;
            }
            if (kullanici.KartListesi.Count < 6)
            {
                kullanici.KartCekme();
            }

            //kartları sıfırla
            kartTutucu1.SavasKarti.KartDurumu = KartDurumu.Elde;
            kartTutucu2.SavasKarti.KartDurumu = KartDurumu.Elde;
            kartTutucu3.SavasKarti.KartDurumu = KartDurumu.Elde;
            kartTutucu4.SavasKarti.KartDurumu = KartDurumu.Elde;
            kartTutucu5.SavasKarti.KartDurumu = KartDurumu.Elde;
            kartTutucu6.SavasKarti.KartDurumu = KartDurumu.Elde;
            kartTutucu1.SavasKarti = null;
            kartTutucu2.SavasKarti = null;
            kartTutucu3.SavasKarti = null;
            kartTutucu4.SavasKarti = null;
            kartTutucu4.Tag = null;
            kartTutucu5.SavasKarti = null;
            kartTutucu5.Tag = null;
            kartTutucu6.SavasKarti = null;
            kartTutucu6.Tag = null;

            ((Kullanici)kullanici).UpdateKartTutucuKucukElements();

            StartBtn.Enabled = false;
            FightBtn.Enabled = true;
            Tur++;
        }

        private void TxtMaxTur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtMaxTur.ReadOnly = true;
            }
        }
    }
}
