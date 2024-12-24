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
    public partial class CalisanHizmetsecim : Form
    {
        public CalisanHizmetsecim()
        {
            InitializeComponent();
        }

        private void btnonay_Click(object sender, EventArgs e)
        {
            CalisanSeans cseans = new CalisanSeans();   
            cseans.Show();
            this.Close();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanKayitForm calisanKayitForm = new CalisanKayitForm();
            calisanKayitForm.Show();
            this.Close();
        }
    }
}
