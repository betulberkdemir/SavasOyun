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
    public partial class KartTutucuKucuk : UserControl
    {
        public delegate void DelegateSetSetSavasArac(SavasArac savasKarti);

        private SavasArac _savasKarti;
        public SavasArac SavasKarti
        {
            get => _savasKarti;
            set => SetSavasArac(value);
        }

        public KartTutucuKucuk()
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
                }
                else
                {
                    (string kartAdi, Image kartResmi) = SavasAracExtensions.GetKartAdiVeResim(savasKarti);
                    lblKartAdi.Text = kartAdi;
                    pictureBox1.Image = kartResmi;
                    lblTur.Text = $"T:{savasKarti.Sinif}";
                    lblDayaniklilik.Text = $"D:{savasKarti.Dayaniklilik}";
                    lblVurus.Text = $"V:{savasKarti.Vurus}";
                }
            }
        }
    }
}
