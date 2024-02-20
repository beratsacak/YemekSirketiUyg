using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSirketiUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
                    }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += adresTxt.Text + "\r\n";
                txtBilgi.Text += telefonTxt.Text + "\r\n";
                txtBilgi.Text += adresTxt.Text + "\r\n";
                decimal hesap = 0;
                if (corbaSayi.Value > 0)
                {
                    hesap += corbaSayi.Value * 12;
                    txtBilgi.Text += string.Format("Çorba {0:C}",corbaSayi.Value * 12) + "\r\n";
                }
                txtBilgi.Text += "-----------------" + "\r\n";
                if (salataSayi.Value > 0)
                {
                    hesap += salataSayi.Value * 13;
                    txtBilgi.Text += string.Format("Salata {0:C}", salataSayi.Value * 13) + "\r\n";
                }
                txtBilgi.Text += "-----------------" + "\r\n";
                if (anaYemekSayi.Value > 0)
                {
                    hesap += anaYemekSayi.Value * 14;
                    txtBilgi.Text += string.Format("Ana Yemek {0:C}", anaYemekSayi.Value * 14) + "\r\n";
                }
                txtBilgi.Text += "-----------------" + "\r\n";
                if (tatliSayi.Value > 0)
                {
                    hesap += tatliSayi.Value * 15;
                    txtBilgi.Text += string.Format("Tatlı {0:C}", tatliSayi.Value * 13) + "\r\n";
                }
                txtBilgi.Text += "-----------------"+"\r\n";

                txtBilgi.Text += string.Format("Toplam {0:C}",hesap);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
