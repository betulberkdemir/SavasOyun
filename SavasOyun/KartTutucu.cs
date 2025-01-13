using SavasOyun.Araclar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavasOyun
{
    public partial class KartTutucu : UserControl
    {
        public delegate void DelegateSetSetSavasArac(SavasArac savasKarti); //referans

        private bool ozelKart = false;

        private SavasArac _savasKarti;
        public SavasArac SavasKarti
        {
            get => _savasKarti;
            set => SetSavasArac(value);
        }


        //hasarı hesaplıyoruz tiplerini(oyuncu ve bilgisayar) saklamam gerekiyor mu? //

        public KartTutucu()
        {
            InitializeComponent();
        }
        private void SetSavasArac(SavasArac savasKarti)
        {
            //İlk kısım thread safe erişim için gerekli
            if (InvokeRequired)
            {
                Invoke((DelegateSetSetSavasArac)SetSavasArac, new object[] { savasKarti });
            }
            else
            {
                _savasKarti = savasKarti;
                if (savasKarti == null)
                {
                    lblKartAdi.Text = "";
                    pictureBox1.Image = null;
                    lblTur.Text = "";
                    lblDayaniklilik.Text = "";
                    lblVurus.Text = "";
                    lblDenizAvantaji.Text = "";
                    lblHavaAvantaji.Text = "";
                    lblKaraAvantaji.Text = "";
                    TextLevel.Text = "";
                    TextDurability.Text = "";
                    TextDmg.Text = "";
                }
                else
                {
                    (string kartAdi, Image kartResmi) = SavasAracExtensions.GetKartAdiVeResim(savasKarti);
                    lblKartAdi.Text = kartAdi;
                    pictureBox1.Image = kartResmi;
                    lblTur.Text = $"T:{savasKarti.Sinif}";
                    lblDayaniklilik.Text = $"D:{savasKarti.Dayaniklilik}";
                    lblVurus.Text = $"V:{savasKarti.Vurus}";
                    TextLevel.Text = savasKarti.Seviye.ToString();
                    TextDurability.Text = savasKarti.Dayaniklilik.ToString();

                    //lblKaraAvantaji = $"V:{savasKarti.KaraAvantaji}"; (savas aracda tanımlamadığım için sıkıntı veriyor.)

                    Ucak ucak = new Ucak();// object creation
                    object boxed = ucak as object; //boxing uçak obje olarak paketle
                    Ucak unboxed = boxed as Ucak; // unboxing paketlenmiş objeyi uçak olarak aç


                    Sida sida;
                    sida = new Sida();
                    SavasArac arac;//
                    arac = sida;
                    DenizArac denizArac;
                    denizArac = arac as DenizArac; // (DenizArac)arac
                    HavaArac havaArac;
                    havaArac = arac as HavaArac;
                    //havaArac.Sinif//benim yaptığım referans hatası

                    if(arac is HavaArac hava)//hava arac referans ediyor
                    {
                       // hava.//havanın özelliklerine ulaşıyor. 
                    }

                    TextBox texbox = new TextBox();
                    TextDurability = new TextBox();

                    //
                    

                    



                }
            }
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
