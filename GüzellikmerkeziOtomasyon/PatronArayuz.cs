using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GüzellikmerkeziOtomasyon
{
    public partial class PatronArayuz : Form
    {
        public PatronArayuz()
        {
            InitializeComponent();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Girissayfa grsf = new Girissayfa();
            grsf.Show();
            this.Close();
        }

        private void btnkazanc_Click(object sender, EventArgs e)
        {
            PatronKazancForm pkazanc  = new PatronKazancForm();
            pkazanc.Show();
            this.Close();
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            PatronMüsteriDuzenleme pmusteri = new PatronMüsteriDuzenleme();
            pmusteri.Show();
            this.Hide();
        }

        private void btncalisan_Click(object sender, EventArgs e)
        {
            PatronCalisanDuzenle pcalisan = new PatronCalisanDuzenle();
            pcalisan.Show();
            this.Hide();
        }

        private void btnfiyat_Click(object sender, EventArgs e)
        {
            PatronFiyatDuzenleme pfiyat = new PatronFiyatDuzenleme();
            pfiyat.Show();
            this.Hide();

        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
