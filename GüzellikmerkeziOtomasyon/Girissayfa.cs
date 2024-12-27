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
    public partial class Girissayfa : Form
    {
        public Girissayfa()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string patronad = "1";
            var patronsifre = "1";

            var calisanad = "2";
            var calisansifre = "2";

            if (kaditxt.Text==patronad && sifretxt.Text == patronsifre )
            {
                PatronArayuz ptary = new PatronArayuz();
                ptary.Show();
                this.Hide();
            }
            else if ( kaditxt.Text == calisanad && sifretxt.Text == calisansifre)
            {
                CalisanArayuz clsary = new CalisanArayuz();
                clsary.Show();
                this.Hide();
            }
            else if (kaditxt.Text == "" && sifretxt.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!!");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış!!");

            }
        }

        private void kapatfoto_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(sifretxt.PasswordChar == '*')
            {
                sifretxt.PasswordChar = '\0';
                pictureBox1.Image = Properties.Resources.acikgoz;
            }
            else
            {
                sifretxt.PasswordChar = '*';
                pictureBox1.Image = Properties.Resources.kapaligoz;
            }
        }

        private void Girissayfa_Load(object sender, EventArgs e)
        {
            sifretxt.PasswordChar = '*';


            pictureBox1.Image = Properties.Resources.kapaligoz;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }


}
