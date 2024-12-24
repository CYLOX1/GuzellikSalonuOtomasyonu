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
    public partial class CalisanSeansGoruntule : Form
    {
        public CalisanSeansGoruntule()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanArayuz calisanArayuz = new CalisanArayuz();  
            calisanArayuz.Show();
            this.Close();
        }
    }
}
