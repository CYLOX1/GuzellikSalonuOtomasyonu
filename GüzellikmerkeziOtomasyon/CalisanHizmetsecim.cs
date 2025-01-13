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
    public partial class CalisanHizmetsecim : Form
    {
        public CalisanHizmetsecim()
        {
            InitializeComponent();
            tarihzamanaracı.MinDate = DateTime.Now.Date;
        } 
        baglanti db = new baglanti();


        private void btnonay_Click(object sender, EventArgs e)
        {
            if (hizmetlist.SelectedItem == null || tarihzamanaracı.Text == "" || combosaat.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
                return;
            }

            DateTime secilengun = tarihzamanaracı.Value.Date;
            TimeSpan secilenSaat = TimeSpan.Parse(combosaat.Text);

            var cagir = db.baglan();

            try
            {
                // Aynı tarih ve saatte başka bir seans var mı kontrolü
                bool mevcutSeans = cagir.Seanslar
                    .Any(s => s.Tarih == secilengun && s.Saat == secilenSaat);

                if (mevcutSeans)
                {
                    MessageBox.Show("Bu tarih ve saatte zaten bir seans mevcut. Lütfen farklı bir saat seçiniz.");
                    return;
                }

                // Seçilen hizmetin fiyatı ve ID'sini al
                string secilenHizmet = hizmetlist.SelectedItem.ToString();
                var hizmetBilgisi = cagir.hizmetler
                    .Where(h => h.hizmet == secilenHizmet)
                    .Select(h => new { h.hizmetID, h.fiyat })
                    .FirstOrDefault();

                if (hizmetBilgisi == null)
                {
                    MessageBox.Show("Seçilen hizmet bulunamadı. Lütfen veritabanını kontrol edin.");
                    return;
                }

                int hizmetID = hizmetBilgisi.hizmetID; // Hizmet ID'si
                int hizmetFiyat = 0;

                // Fiyat dönüştürme
                if (!int.TryParse(hizmetBilgisi.fiyat, out hizmetFiyat))
                {
                    MessageBox.Show("Hizmet fiyatı geçerli bir sayı değil! Lütfen veritabanını kontrol edin.");
                    return;
                }

                // Seanslar tablosuna ekleme
                Seanslar ekle = new Seanslar
                {
                    musteriID = int.Parse(ıdtxt.Text),
                    Ad = adtxt.Text,
                    Soyad = soyadtxt.Text,
                    hizmetID = hizmetID, // Hizmet ID'si burada eklendi
                    VerilenHizmet = secilenHizmet,
                    Tarih = secilengun,
                    Saat = secilenSaat,
                    kazanc = hizmetFiyat
                };

                cagir.Seanslar.Add(ekle);
                cagir.SaveChanges();

                MessageBox.Show($"Seans başarıyla eklendi. Hizmet ID: {hizmetID}, Kazanç: {hizmetFiyat:C}");

                // Formu yenile
                CalisanSeans cseans = new CalisanSeans();
                cseans.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
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
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanArayuz carayuz = new CalisanArayuz();
            carayuz.Show();
            this.Close();
        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hizmetlist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selectedCount = hizmetlist.CheckedItems.Count;

            if (selectedCount >= 1 && e.NewValue == CheckState.Checked)
            {
                // Yeni öğe işaretlenemez
                MessageBox.Show("Sadece bir öğe seçilebilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.NewValue = CheckState.Unchecked; // Yeni öğeyi işaretlemeden önce eski seçimi iptal et
            }
        }

        private void CalisanHizmetsecim_Load(object sender, EventArgs e)
        {
            listele();
            var cagir = db.baglan();
            var liste = cagir.hizmetler.AsNoTracking().ToList();

            var uygulamalar = from h in cagir.hizmetler
                              select h.hizmet;
            foreach (var item in uygulamalar)
            {
                hizmetlist.Items.Add(item);
            }
            
        }

        private void musteridatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilensatir = musteridatagrid.SelectedCells[0].RowIndex;
            ıdtxt.Text = musteridatagrid.Rows[secilensatir].Cells[0].Value.ToString();
            adtxt.Text = musteridatagrid.Rows[secilensatir].Cells[1].Value.ToString();
            soyadtxt.Text = musteridatagrid.Rows[secilensatir].Cells[2].Value.ToString();

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
               listele();
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
