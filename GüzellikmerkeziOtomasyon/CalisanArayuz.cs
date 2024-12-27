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
    public partial class CalisanArayuz : Form
    {
        public CalisanArayuz()
        {
            InitializeComponent();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Girissayfa grsf = new Girissayfa();
            grsf.Show();
            this.Close();
        }

        private void btnyenimusteri_Click(object sender, EventArgs e)
        {
            CalisanKayitForm ckayit = new CalisanKayitForm();
            ckayit.Show();
            this.Hide();
        }

        private void btnmusteriduzen_Click(object sender, EventArgs e)
        {
            CalisanMusteriDuzenle cmusteriduzen = new CalisanMusteriDuzenle();
            cmusteriduzen.Show();
            this.Hide();
        }

        private void btnseansduzen_Click(object sender, EventArgs e)
        {
            CalisanSeansDuzenleme calisseans = new CalisanSeansDuzenleme();
            calisseans.Show();
            this.Hide();

        }

        private void btnseansbak_Click(object sender, EventArgs e)
        {
            CalisanSeansGoruntule calisanSeans = new CalisanSeansGoruntule();
            calisanSeans.Show();
            this.Hide();
        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
