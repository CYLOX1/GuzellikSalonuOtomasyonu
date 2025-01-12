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
    public partial class CalisanKayitForm : Form
    {
        public CalisanKayitForm()
        {
            InitializeComponent();
        }
        baglanti db = new baglanti();

        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanArayuz calisara = new CalisanArayuz();
            calisara.Show();
            this.Close();
        }

        private void btnkkaydet_Click(object sender, EventArgs e)
        {
            var cagir = db.baglan();

            if (adtxt.Text == "" || soyadtxt.Text == "" || teltxt.Text == "")
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz!");
            }
            else
            {
                try
                {
                    müşteriler ekle = new müşteriler();
                    ekle.Ad = adtxt.Text;
                    ekle.Soyad = soyadtxt.Text;
                    ekle.TelefonNo = teltxt.Text;
                    cagir.müşteriler.Add(ekle);

                    cagir.SaveChanges();

                    CalisanArayuz carayuz = new CalisanArayuz();
                    carayuz.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void teltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int uzunluk = 12;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (teltxt.Text.Length >= uzunluk && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
