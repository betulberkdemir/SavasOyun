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
        public Form1()
        {
            InitializeComponent();
            // kullanıcılARI VE destelerini oluştur
            // oyuncunun kartlarını bir yere kat
            //this.Size = new Size(800, 600); // Genişlik: 800, Yükseklik: 600

            //kartTutucuKucuk1.SavasKarti = new Ucak();
            //kartTutucuKucuk2.SavasKarti = new Obus();
            //kartTutucuKucuk3.SavasKarti = new Firkateyn();
            //kartTutucuKucuk4.SavasKarti = new Obus();
            //kartTutucuKucuk5.SavasKarti = new Ucak();
            //kartTutucuKucuk6.SavasKarti = new Firkateyn();
            this.Size = new Size(850, 1102);
            // form 1121; 1102 ()

            // Create Bilgisayar object
            Bilgisayar bilgisayar = new Bilgisayar();

            // Select 3 cards
            SavasArac kart1 = bilgisayar.KartSec();
            SavasArac kart2 = bilgisayar.KartSec();
            SavasArac kart3 = bilgisayar.KartSec();

            // Assign selected cards to kartTutucu elements
            kartTutucu1.SavasKarti = kart1;
            kartTutucu2.SavasKarti = kart2;
            kartTutucu3.SavasKarti = kart3;

            UpdateKartTutucuKucukElements();



        }

        private void UpdateKartTutucuKucukElements()
        {
            Oyuncu kullanici = new Kullanici(1, "");
            kullanici.KullaniciKartListesi(); 

            // Ensure there are enough kartTutucuKucuk elements to display the cards
            var kartTutucuKucukElements = new List<KartTutucuKucuk>
        {
            kartTutucuKucuk1,
            kartTutucuKucuk2,
            kartTutucuKucuk3,
            kartTutucuKucuk4,
            kartTutucuKucuk5,
            kartTutucuKucuk6
        };

            for (int i = 0; i < kullanici.KartListesi.Count && i < kartTutucuKucukElements.Count; i++)
            {
                kartTutucuKucukElements[i].SavasKarti = kullanici.KartListesi[i];
            }
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kartTutucuRakip1.SavasKarti = null;
            //kartTutucuRakip2.SavasKarti = null;
            //kartTutucuRakip3.SavasKarti = null;
            //kartTutucuKullanici1.SavasKarti = null;
            //kartTutucuKullanici2.SavasKarti = null;
            //kartTutucuKullanici3.SavasKarti = null;

            foreach (var item in panel1.Controls)
            {
                if(item is KartTutucu kartTutucu)
                    kartTutucu.SavasKarti = null;
                else if (item is KartTutucuKucuk kartTutucuKucuk)
                    kartTutucuKucuk.SavasKarti = null;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // kart kutularını temizle
            foreach (var item in panel1.Controls)
            {
                if (item is KartTutucu kartTutucu)
                    kartTutucu.SavasKarti = null;
                else if (item is KartTutucuKucuk kartTutucuKucuk)
                    kartTutucuKucuk.SavasKarti = null;
            }

            //referans
            kartTutucu1.SavasKarti = new Ucak();
            kartTutucu2.SavasKarti = new Siha();
            kartTutucu3.SavasKarti = new Firkateyn();
            kartTutucu4.SavasKarti = new Siha();
            kartTutucu5.SavasKarti = new Sida();
            kartTutucu6.SavasKarti = new KFS();

        }



        private void button2_Click(object sender, EventArgs e)
        {

            kartTutucu1.SavasKarti = new Ucak();
            kartTutucu2.SavasKarti = new Siha();
            kartTutucu3.SavasKarti = new Firkateyn();
            kartTutucu4.SavasKarti = new Siha();
            kartTutucu5.SavasKarti = new Sida();
            kartTutucu6.SavasKarti = new KFS();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            kartTutucu1.SavasKarti = new Siha();
            kartTutucu2.SavasKarti = new Ucak();
            kartTutucu3.SavasKarti = new Obus();
            kartTutucu4.SavasKarti = new Ucak();
            kartTutucu5.SavasKarti = new Siha();
            kartTutucu6.SavasKarti = new Firkateyn();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            kartTutucu1.SavasKarti = new Obus();
            kartTutucu2.SavasKarti = new KFS();
            kartTutucu3.SavasKarti = new Sida();
            kartTutucu4.SavasKarti = new Firkateyn();
            kartTutucu5.SavasKarti = new Ucak();
            kartTutucu6.SavasKarti = new Sida();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kartTutucu1.SavasKarti = new KFS();
            kartTutucu2.SavasKarti= new Obus();
            kartTutucu3.SavasKarti = new Siha();
            kartTutucu4.SavasKarti = new Obus();
            kartTutucu5.SavasKarti = new Firkateyn();
            kartTutucu6.SavasKarti = new Siha();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kartTutucu1.SavasKarti = new Firkateyn();
            kartTutucu2.SavasKarti = new Sida();
            kartTutucu3.SavasKarti = new Obus();
            kartTutucu4.SavasKarti = new Sida();
            kartTutucu5.SavasKarti = new Obus();
            kartTutucu6.SavasKarti = new KFS();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kartTutucuKucuk1.SavasKarti = new Sida();
            kartTutucuKucuk2.SavasKarti = new Siha();
            kartTutucuKucuk3.SavasKarti = new Firkateyn();
            kartTutucuKucuk4.SavasKarti = new Obus();
            kartTutucuKucuk5.SavasKarti= new Sida();
            kartTutucuKucuk6.SavasKarti = new KFS();

        }

        private void kartTutucuKucuk3_Load(object sender, EventArgs e)
        {

        }

        private void bilgisayar_Load(object sender, EventArgs e)
        {

        }

        private void kartTutucu1_Load(object sender, EventArgs e)
        {

        }

        private void kartTutucuRakip1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;//mantığı yok!

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void arena1_Click(object sender, EventArgs e)
        {
            //arena1_Click --> kartTutucuKucuk1'deki kart --> kartTutucu4'deki yere yerleşecek.
            //kartTutucuKucuk1'de (uçak obüs firkateyn) --> kartTutucuKucuk1.SavasKarti = new Sida();
            //kartTutucu4'e gitsin
            //kartTutucuKucuk1.SavasKarti = new Sida(); üretmesine gerek yok başlangıçta zaten var
            //kartı kullanıcın kartına göndermesi gerekiyor
            //karttutucu4' de kart nesnesi oluşacak
            //

            kartTutucu4.SavasKarti = new Ucak();
            
            



        }


        //kartTutucukucukten karttutucuya kart gittikten sonra kucukten gittiği belli olsun diye gri yap.
        //bilgisayara gitmesine gerek yok rastgele kullanıcıya gitsin.
        private void arena2_Click(object sender, EventArgs e)
        {
            kartTutucu5.SavasKarti = new Obus();
            //rastgele bir kart oluşacak.


        }

        private void arena3_Click(object sender, EventArgs e)
        {
            kartTutucu6.SavasKarti = new Firkateyn();
        }

        //OYUNCU BUTONA BAS // OYUNCU NESNE OLUŞTUR  // NESNEDEN RASTGELE METOD ÇAĞIR//
        private void oyuncuButton_Click(object sender, EventArgs e)
        {
               //kullanıcıdan nesne + kart çekme

        }
    }
}
