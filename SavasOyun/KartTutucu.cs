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
        private delegate void DelegateSetSetSavasArac(SavasArac savasKarti); //referans
        private delegate void DelegateSetIntField(int field); //referans

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

        public void SetTotalDamage(int damage)
        {
            if (InvokeRequired)
            {
                Invoke((DelegateSetIntField)SetTotalDamage, new object[] { damage });
            }
            {
                TextDmg.Text = damage.ToString();
            }
        }

        public void SetDurability (int durability)
        {
            if (InvokeRequired)
            {
                Invoke((DelegateSetIntField)SetDurability, new object[] { durability });
            }
            {
                TextDurability.Text = durability.ToString();
            }
        }
        //kart tutucuda levelin set edilmesi.
        //
        //
        //CompScore ve UserScore'da levelin set edilmesi gerekiyor.
        public void SetLevel(int level)
        {
            if (InvokeRequired)
            {
                Invoke((DelegateSetIntField)SetLevel, new object[] { level });
            }
            {
                TextLevel.Text = level.ToString();
            }
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
                    textId.Text = "";
                }
                else
                {
                    (lblKartAdi.Text, pictureBox1.Image) = SavasAracExtensions.GetKartAdiVeResim(savasKarti);
                    lblTur.Text = $"T:{savasKarti.Sinif}";
                    lblDayaniklilik.Text = $"D:{savasKarti.Dayaniklilik}";
                    lblVurus.Text = $"V:{savasKarti.Vurus}";
                    TextDurability.Text = savasKarti.Dayaniklilik.ToString();
                    textId.Text = savasKarti.Id.ToString();

                    if (savasKarti is HavaArac havaArac)
                    {
                        lblKaraAvantaji.Text = $"KA:{havaArac.KaraVurusAvantaji}";
                    }
                    else if (savasKarti is DenizArac denizArac)
                    {
                        lblHavaAvantaji.Text = $"HA:{denizArac.HavaVurusAvantaji}";
                    }
                    else if (savasKarti is KaraArac karaArac)
                    {
                        lblDenizAvantaji.Text = $"DA:{karaArac.DenizVurusAvantaji}";
                    }

                    if(savasKarti is KFS kfs)
                    {
                        lblHavaAvantaji.Text = $"HA:{kfs.HavaVurusAvantaji}";
                    }
                    else if(savasKarti is Sida sida)
                    {
                        lblKaraAvantaji.Text = $"KA:{sida.KaraVurusAvantaji}";
                    }
                    else if (savasKarti is Siha siha)
                    {
                        lblDenizAvantaji.Text = $"DA:{siha.DenizVurusAvantaji}";
                    }

                    //lblKaraAvantaji = $"V:{savasKarti.KaraAvantaji}"; (savas aracda tanımlamadığım için sıkıntı veriyor.)

                    //Ucak ucak = new Ucak();// object creation
                    //object boxed = ucak as object; //boxing uçak obje olarak paketle
                    //Ucak unboxed = boxed as Ucak; // unboxing paketlenmiş objeyi uçak olarak aç


                    //Sida sida;
                    //sida = new Sida();
                    //SavasArac arac;//
                    //arac = sida;
                    //DenizArac denizArac;
                    //denizArac = arac as DenizArac; // (DenizArac)arac
                    //HavaArac havaArac;
                    //havaArac = arac as HavaArac;
                    ////havaArac.Sinif//benim yaptığım referans hatası

                    //if(arac is HavaArac hava)//hava arac referans ediyor
                    //{
                    //   // hava.//havanın özelliklerine ulaşıyor. 
                    //}

                    //TextBox texbox = new TextBox();
                    //TextDurability = new TextBox();
                }
            }
        }

    }
}
