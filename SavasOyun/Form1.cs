using SavasOyun.Araclar;
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
    }
}
