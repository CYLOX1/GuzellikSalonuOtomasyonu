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

        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanArayuz calisara = new CalisanArayuz();
            calisara.Show();
            this.Close();
        }

        private void btnkkaydet_Click(object sender, EventArgs e)
        {
            CalisanHizmetsecim chizmetsec = new CalisanHizmetsecim();
            chizmetsec.Show();
            this.Hide();
        }
    }
}
