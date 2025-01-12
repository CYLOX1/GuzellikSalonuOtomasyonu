using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GüzellikmerkeziOtomasyon
{
    public partial class PatronFiyatDuzenleme : Form
    {
        public PatronFiyatDuzenleme()
        {
            InitializeComponent();
        }
        baglanti db = new baglanti();
        private void btngeri_Click(object sender, EventArgs e)
        {
            PatronArayuz patronArayuz = new PatronArayuz();
            patronArayuz.Show();
            this.Close();
        }

        private void listele()
        {

            var cagir = db.baglan();
            var liste = (from f in cagir.hizmetler
                         select new
                         {
                             f.hizmetID,
                             f.hizmet,
                             f.fiyat
                         }).ToList(); 
            fiyatdatagrid.DataSource = liste;
            fiyatdatagrid.ClearSelection();
            hizmetıdtxt.Clear();
            hizmetadtxt.Clear();
            hizmetfiyattxt.Clear();
            
        }
        private void PatronFiyatDuzenleme_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void fiyatdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilensatir = fiyatdatagrid.SelectedCells[0].RowIndex;
            hizmetıdtxt.Text = fiyatdatagrid.Rows[secilensatir].Cells[0].Value.ToString();
            hizmetadtxt.Text = fiyatdatagrid.Rows[secilensatir].Cells[1].Value.ToString();
            hizmetfiyattxt.Text = fiyatdatagrid.Rows[secilensatir].Cells[2].Value.ToString();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            var cagir = db.baglan();
            try
            {

                if (hizmetadtxt.Text == "" || hizmetfiyattxt.Text == "" )
                {
                    MessageBox.Show("Boş alan bırakmayınız!");
                }
                else
                {

                    hizmetler ekle = new hizmetler();
                    ekle.hizmet = hizmetadtxt.Text;
                    ekle.fiyat = hizmetfiyattxt.Text;
                    cagir.hizmetler.Add(ekle);
                    cagir.SaveChanges();
                    listele();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(hizmetıdtxt.Text);
                var bgl = db.baglan();
                var sil = bgl.hizmetler.Find(id);
                bgl.hizmetler.Remove(sil);
                bgl.SaveChanges();
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (hizmetadtxt.Text == "" || hizmetfiyattxt.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }
            else
            {
                int id = Convert.ToInt32(hizmetıdtxt.Text);
                var bgl = db.baglan();
                var guncelle = bgl.hizmetler.Find(id);
                guncelle.hizmet = hizmetadtxt.Text;
                guncelle.fiyat = hizmetfiyattxt.Text;
                bgl.SaveChanges();
                listele();
            }
        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hizmetfiyattxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '+') && (e.KeyChar != '-') &&
            (e.KeyChar != '(') && (e.KeyChar != ')') && (e.KeyChar != ' '))
            {
                e.Handled = true; // Geçersiz karakter girişini engelle
            }
        }
    }
}
