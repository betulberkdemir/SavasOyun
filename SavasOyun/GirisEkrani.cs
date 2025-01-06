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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
            textBox1.Text = string.Empty;

            Ucak ucak = new Ucak(5);
            Siha siha = new Siha();
            TextBoxWriteLine("Ucak: " + ucak.Dayaniklilik);
            TextBoxWriteLine("Siha: " + siha.Dayaniklilik);
            TextBoxWriteLine("Siha vs Ucak");
            siha.DayaniklilikGuncelle(ucak.Vurus);
            ucak.DayaniklilikGuncelle(siha.Vurus);
            TextBoxWriteLine("Ucak: " + ucak.Dayaniklilik);
            TextBoxWriteLine("Siha: " + siha.Dayaniklilik);
        }
        public void TextBoxWriteLine(string text)
        {
            textBox1.Text += text + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(maskedTextBox1.Text);
            int num2 = Convert.ToInt32(maskedTextBox2.Text);

            int result = 0;

            char pickedOperator = Convert.ToChar(comboBox1.Text);

            if (pickedOperator == '/')
            {

                result = num1 / num2;

            }

            else if (pickedOperator == '-')
            {
                result = num2 - num1;
            }

            else if (pickedOperator == '+')
            {
                result = num2 + num1;
            }

            else if (pickedOperator == '*')
            {
                result = num2 * num1;
            }

            else
            {

                MessageBox.Show("Lütfenbir operatör seçiniz", "Hata");

            }

            listBox1.Items.Add(result.ToString());



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
