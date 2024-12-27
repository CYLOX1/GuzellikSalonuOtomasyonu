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

        baglanti db = new baglanti();
        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanArayuz calisanArayuz = new CalisanArayuz();  
            calisanArayuz.Show();
            this.Close();
        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listele()
        {
            var cagir = db.baglan();
            var liste = cagir.Seanslar.AsNoTracking().ToList();
            seanslardatagrid.DataSource = liste;
            seanslardatagrid.ClearSelection();
        }



        private void CalisanSeansGoruntule_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
