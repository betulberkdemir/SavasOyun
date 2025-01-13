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
            this.Size = new Size(850, 1000);
            // form 1121; 1102 ()

            // Create Bilgisayar object
            Bilgisayar bilgisayar = new Bilgisayar();

            // Create Player object
            Kullanici kullanici = new Kullanici(1, "Kullanıcı", 
                new List<KartTutucuKucuk>
                {
                    kartTutucuKucuk1,
                    kartTutucuKucuk2,
                    kartTutucuKucuk3,
                    kartTutucuKucuk4,
                    kartTutucuKucuk5,
                    kartTutucuKucuk6
                });

            //// Select 3 cards
            //SavasArac kart1 = bilgisayar.KartSec();
            //SavasArac kart2 = bilgisayar.KartSec();
            //SavasArac kart3 = bilgisayar.KartSec();

            //// Assign selected cards to kartTutucu elements
            //kartTutucu1.SavasKarti = kart1;
            //kartTutucu2.SavasKarti = kart2;
            //kartTutucu3.SavasKarti = kart3;




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

        private void arena1_Click(object sender, EventArgs e)
        {
            

        }

      
        private void arena2_Click(object sender, EventArgs e)
        {
           
        }

        private void arena3_Click(object sender, EventArgs e)
        {
           
        }

    }
}
