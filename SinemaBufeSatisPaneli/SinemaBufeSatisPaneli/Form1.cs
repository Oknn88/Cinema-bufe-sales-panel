using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufeSatisPaneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0, kasatoplam = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtKola.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";
            toplam = 0;
            label9.Text = toplam.ToString() + " TL";

            txtMisir.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, kola, bilet;

            misir = Convert.ToInt16(txtBilet.Text);
            su = Convert.ToInt16(txtSu.Text);
            kola = Convert.ToInt16(txtKola.Text);
            bilet = Convert.ToInt16(txtBilet.Text);

            toplam = misir * 4 + su + kola * 2 + bilet * 8;

            kasatoplam += toplam;

            label9.Text = toplam.ToString() + " TL";
            label16.Text = kasatoplam.ToString() + " TL";
        }
    }
}
