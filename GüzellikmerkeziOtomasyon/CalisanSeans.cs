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
    public partial class CalisanSeans : Form
    {
        public CalisanSeans()
        {
            InitializeComponent();
        }
        baglanti bagla = new baglanti();

        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanHizmetsecim calisanhizmet = new CalisanHizmetsecim();
            calisanhizmet.Show();
            this.Close();

        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            CalisanArayuz calisara  = new CalisanArayuz();
            calisara.Show();
            this.Close();
        }

        private void CalisanSeans_Load(object sender, EventArgs e)
        {
           try
            {
                
                var cagir = bagla.baglan();
                var liste= cagir.Seanslar.AsNoTracking().ToList();
                seansdatagrid.DataSource=liste;

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Bir hata ile karşılaşıldı"+ ex.Message);
            }
        }
    }
}
