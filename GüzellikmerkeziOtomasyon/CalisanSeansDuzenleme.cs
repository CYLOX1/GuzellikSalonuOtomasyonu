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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GüzellikmerkeziOtomasyon
{
    public partial class CalisanSeansDuzenleme : Form
    {
        baglanti db = new baglanti();
        public CalisanSeansDuzenleme()
        {
            InitializeComponent();
            tarihzaman.MinDate = DateTime.Now.Date;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanArayuz calisara = new CalisanArayuz();
            calisara.Show();
            this.Close();
        }



        private void listele()
        {
            var cagir = db.baglan();
            var liste = cagir.Seanslar.AsNoTracking().ToList();
            seansdatagrid.DataSource = liste;
            seansdatagrid.ClearSelection();
            ıdtxt.Clear();
            adtxt.Clear();
            soyadtxt.Clear();
            combosaat.ResetText();


        }
        private void CalisanSeansDuzenleme_Load(object sender, EventArgs e)
        {

            listele();


        }
        private void ıdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btndegistir_Click(object sender, EventArgs e)
        {
            if (adtxt.Text == "" || soyadtxt.Text == "" || tarihzaman.Text == "" || combosaat.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }
            else
            {
                int id = Convert.ToInt32(ıdtxt.Text);
                var bgl = db.baglan();
                var guncelle = bgl.Seanslar.Find(id);
                guncelle.Ad = adtxt.Text;
                guncelle.Soyad = soyadtxt.Text;
                guncelle.Tarih = tarihzaman.Value;
                guncelle.Saat = TimeSpan.Parse(combosaat.Text);
                bgl.SaveChanges();
                listele();
            }
        }

        private void seansdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilensatir = seansdatagrid.SelectedCells[0].RowIndex;
            ıdtxt.Text = seansdatagrid.Rows[secilensatir].Cells[0].Value.ToString();
            adtxt.Text = seansdatagrid.Rows[secilensatir].Cells[1].Value.ToString();
            soyadtxt.Text = seansdatagrid.Rows[secilensatir].Cells[2].Value.ToString();
            tarihzaman.Text = seansdatagrid.Rows[secilensatir].Cells[4].Value.ToString();
            combosaat.Text = seansdatagrid.Rows[secilensatir].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ıdtxt.Text);
            var bgl = db.baglan();
            var sil = bgl.Seanslar.Find(id);
            bgl.Seanslar.Remove(sil);
            bgl.SaveChanges();
            listele();
        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
