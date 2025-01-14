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
            var liste = (from m in cagir.müşteriler
                         select new
                         {
                             m.musteriID,
                             m.Ad,
                             m.Soyad,
                             m.TelefonNo
                         }).ToList();
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int uzunluk = 12;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (teltxt.Text.Length >= uzunluk && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void filtre()
        {
            var cagir = db.baglan();
            var filtrelenmisListe = cagir.müşteriler.AsNoTracking().Where(m =>
                (string.IsNullOrEmpty(txtfiltread.Text) || m.Ad.Contains(txtfiltread.Text)) &&
                (string.IsNullOrEmpty(txtfiltresoyad.Text) || m.Soyad.Contains(txtfiltresoyad.Text)) &&
                (string.IsNullOrEmpty(txtfiltretel.Text) || m.TelefonNo.StartsWith(txtfiltretel.Text))
                ).Select(m => new
                {
                    m.musteriID,
                    m.Ad,
                    m.Soyad,
                    m.TelefonNo
                }
            ).ToList();

            musteridatagrid.DataSource = filtrelenmisListe;
            musteridatagrid.ClearSelection();
        }


        private void checkfiltre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkfiltre.Checked)
            {
              txtfiltread.Visible = true;
              txtfiltresoyad.Visible = true;
              txtfiltretel.Visible = true;
                lblad.Visible = true;
                lblsoyad.Visible = true;
                lbltel.Visible = true;

            }
            else
            {
                txtfiltread.Visible = false;
                txtfiltresoyad.Visible = false;
                txtfiltretel.Visible = false;
                lblad.Visible = false;
                lblsoyad.Visible = false;
                lbltel.Visible = false;
                txtfiltread.Clear();
                txtfiltresoyad.Clear();
                txtfiltretel.Clear();
                listele();
            }
        }

        private void txtfiltread_TextChanged(object sender, EventArgs e)
        {
            filtre();
        }

        private void txtfiltresoyad_TextChanged(object sender, EventArgs e)
        {
            filtre();
        }

        private void txtfiltretel_TextChanged(object sender, EventArgs e)
        {
            if (teltxt.Text.Length > 15)
            {
                teltxt.Text = teltxt.Text.Substring(0, 12); // Fazla karakterleri kes
                teltxt.SelectionStart = teltxt.Text.Length; // İmleci sona taşı
            }

            filtre();
        }

        private void teltxt_TextChanged(object sender, EventArgs e)
        {
            if (teltxt.Text.Length > 15)
            {
                teltxt.Text = teltxt.Text.Substring(0, 12);
                teltxt.SelectionStart = teltxt.Text.Length;
            }

        }

        private void txtfiltretel_KeyPress(object sender, KeyPressEventArgs e)
        {
            int uzunluk = 12;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (txtfiltretel.Text.Length >= uzunluk && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
