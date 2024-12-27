using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GüzellikmerkeziOtomasyon
{
    public partial class CalisanMusteriDuzenle : Form
    {
        baglanti db = new baglanti();
        public CalisanMusteriDuzenle()
        {
            InitializeComponent();
        }

        private void listele()
        {

            var cagir = db.baglan();
            var liste = cagir.müşteriler.AsNoTracking().ToList();
            musteridatagrid.DataSource = liste;
            musteridatagrid.ClearSelection();
            ıdtxt.Clear();
            adtxt.Clear();
            soyadtxt.Clear();
            teltxt.Clear();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanArayuz calisarayuz = new CalisanArayuz();
            calisarayuz.Show();
            this.Close();
        }

        private void CalisanMusteriDuzenle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            var cagir = db.baglan();
            try
            {

                if (adtxt.Text == "" || soyadtxt.Text == "" || teltxt.Text == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız!");
                }
                else
                {

                    müşteriler ekle = new müşteriler();
                    ekle.Ad = adtxt.Text;
                    ekle.Soyad = soyadtxt.Text;
                    ekle.TelefonNo = teltxt.Text;
                    cagir.müşteriler.Add(ekle);
                    cagir.SaveChanges();
                    listele();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ıdtxt.Text);
                var bgl = db.baglan();
                var sil = bgl.müşteriler.Find(id);
                bgl.müşteriler.Remove(sil);
                bgl.SaveChanges();
                listele();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }

        }

        private void musteridatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilensatir = musteridatagrid.SelectedCells[0].RowIndex;
            ıdtxt.Text = musteridatagrid.Rows[secilensatir].Cells[0].Value.ToString();
            adtxt.Text = musteridatagrid.Rows[secilensatir].Cells[1].Value.ToString();
            soyadtxt.Text = musteridatagrid.Rows[secilensatir].Cells[2].Value.ToString();
            teltxt.Text = musteridatagrid.Rows[secilensatir].Cells[3].Value.ToString();

        }

        private void ıdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (adtxt.Text == "" || soyadtxt.Text == "" || teltxt.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }
            else
            {
                int id = Convert.ToInt32(ıdtxt.Text);
                var bgl = db.baglan();
                var guncelle = bgl.müşteriler.Find(id);
                guncelle.Ad = adtxt.Text;
                guncelle.Soyad = soyadtxt.Text;
                guncelle.TelefonNo = teltxt.Text;
                bgl.SaveChanges();
                listele();
            }
        }


    }
}
