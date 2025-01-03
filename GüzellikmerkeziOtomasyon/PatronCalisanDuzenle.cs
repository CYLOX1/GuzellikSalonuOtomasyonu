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
    public partial class PatronCalisanDuzenle : Form
    {
        public PatronCalisanDuzenle()
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
            var liste = cagir.calisan.AsNoTracking().ToList();
            calisandatagrid.DataSource = liste;
            calisandatagrid.ClearSelection();
            ıdtxt.Clear();
            adtxt.Clear();
            soyadtxt.Clear();
            teltxt.Clear();
            
        }
        private void PatronCalisanDuzenle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void calisandatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilensatir = calisandatagrid.SelectedCells[0].RowIndex;
            ıdtxt.Text = calisandatagrid.Rows[secilensatir].Cells[0].Value.ToString();
            adtxt.Text = calisandatagrid.Rows[secilensatir].Cells[1].Value.ToString();
            soyadtxt.Text = calisandatagrid.Rows[secilensatir].Cells[2].Value.ToString();
            teltxt.Text = calisandatagrid.Rows[secilensatir].Cells[3].Value.ToString();
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
                    bool mevcutCalisan = cagir.calisan
                    .Any(c => c.Ad == adtxt.Text && c.Soyad == soyadtxt.Text);

                    if (mevcutCalisan)
                    {
                        MessageBox.Show("Bu isim ve soyisimde zaten bir çalışan mevcut. Lütfen farklı bir isim giriniz.");
                        return;
                    }

                    calisan ekle = new calisan();
                    ekle.Ad = adtxt.Text;
                    ekle.Soyad = soyadtxt.Text;
                    ekle.TelefonNo = teltxt.Text;
                    cagir.calisan.Add(ekle);
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
                    int id = Convert.ToInt32(ıdtxt.Text);
                    var bgl = db.baglan();
                    var sil = bgl.calisan.Find(id);
                    bgl.calisan.Remove(sil);
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
            try
            {
                if (adtxt.Text == "" || soyadtxt.Text == "" || teltxt.Text == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız!");
                }
                else
                {
                    int id = Convert.ToInt32(ıdtxt.Text);
                    var bgl = db.baglan();
                    var guncelle = bgl.calisan.Find(id);
                    guncelle.Ad = adtxt.Text;
                    guncelle.Soyad = soyadtxt.Text;
                    guncelle.TelefonNo = teltxt.Text;
                    bgl.SaveChanges();
                    listele();
                }
              
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message );
            }

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

        private void checkfiltre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkfiltre.Checked)
            {
                txtfiltread.Visible = true;
                txtfiltresoyad.Visible = true;
                txtfiltretel.Visible = true;
            }
            else
            {
                txtfiltread.Visible = false;
                txtfiltresoyad.Visible = false;
                txtfiltretel.Visible = false;
                txtfiltread.Clear();
                txtfiltresoyad.Clear();
                txtfiltretel.Clear();
            }
        }
         private void filtre()
        {
            var cagir = db.baglan();
            var filtrelenmisListe = cagir.calisan.AsNoTracking().Where(m =>
                (string.IsNullOrEmpty(txtfiltread.Text) || m.Ad.Contains(txtfiltread.Text)) &&
                (string.IsNullOrEmpty(txtfiltresoyad.Text) || m.Soyad.Contains(txtfiltresoyad.Text)) &&
                (string.IsNullOrEmpty(txtfiltretel.Text) || m.TelefonNo.Contains(txtfiltretel.Text))
            ).ToList();

            calisandatagrid.DataSource = filtrelenmisListe;
            calisandatagrid.ClearSelection();
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
            filtre();
        }
    }
}
