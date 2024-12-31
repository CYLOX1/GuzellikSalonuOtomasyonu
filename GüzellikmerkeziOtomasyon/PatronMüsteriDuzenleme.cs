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
    public partial class PatronMüsteriDuzenleme : Form
    {
        public PatronMüsteriDuzenleme()
        {
            InitializeComponent();
        }
        baglanti db = new baglanti();

        private void btngeri_Click(object sender, EventArgs e)
        {
            PatronArayuz parayuz = new PatronArayuz();
            parayuz.Show();
            this.Close();
        }


        private void listele()
        {

            var cagir = db.baglan();
            var liste = cagir.müşteriler.AsNoTracking().ToList();
            musteridatagrid.DataSource = liste;
            musteridatagrid.ClearSelection();
            adtxt.Clear();
            soyadtxt.Clear();
            teltxt.Clear();
            ıdtxt.Clear();
        }
        private void PatronMüsteriDuzenleme_Load(object sender, EventArgs e)
        {
            listele();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void musteridatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilensatir = musteridatagrid.SelectedCells[0].RowIndex;
            ıdtxt.Text = musteridatagrid.Rows[secilensatir].Cells[0].Value.ToString();
            adtxt.Text = musteridatagrid.Rows[secilensatir].Cells[1].Value.ToString();
            soyadtxt.Text = musteridatagrid.Rows[secilensatir].Cells[2].Value.ToString();
            teltxt.Text = musteridatagrid.Rows[secilensatir].Cells[3].Value.ToString();
        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teltxt_KeyPress(object sender, KeyPressEventArgs e)
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
