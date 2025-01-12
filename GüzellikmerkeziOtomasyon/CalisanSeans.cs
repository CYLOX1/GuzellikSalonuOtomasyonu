using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GüzellikmerkeziOtomasyon
{
    public partial class CalisanSeans : Form
    {
        public CalisanSeans()
        {
            InitializeComponent();
        }
        baglanti bagla = new baglanti();


        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            CalisanArayuz calisara  = new CalisanArayuz();
            calisara.Show();
            this.Close();
        }

        private void liste()
        {
            var cagir = bagla.baglan();
            var liste = (from s in cagir.Seanslar
                         select new
                         {
                             s.SeansID,
                             s.musteriID,
                             s.Ad,
                             s.Soyad,
                             s.hizmetID,
                             s.VerilenHizmet,
                             s.Tarih,
                             s.Saat
                         }).ToList();
            seansdatagrid.DataSource = liste;
            seansdatagrid.ClearSelection();
        }


        private void CalisanSeans_Load(object sender, EventArgs e)
        {
            liste();
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
