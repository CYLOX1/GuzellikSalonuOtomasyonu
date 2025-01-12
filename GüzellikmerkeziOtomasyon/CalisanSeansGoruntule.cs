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

            try
            {
                var cagir = db.baglan();

                // Bugünün tarihini alıyoruz (saat bilgisini sıfırlıyoruz)
                DateTime bugun = DateTime.Today;

                // Sadece bugünden itibaren tarihleri getiriyoruz
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
                             }).Where(s => DbFunctions.TruncateTime(s.Tarih) >= DbFunctions.TruncateTime(bugun)).ToList();

                // Filtrelenmiş listeyi DataGrid'e bağlıyoruz
                seanslardatagrid.DataSource = liste;
                seanslardatagrid.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı: " + ex.Message);
            }


        }



        private void CalisanSeansGoruntule_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
