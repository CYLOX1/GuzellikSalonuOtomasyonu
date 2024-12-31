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

                // Seçilen hizmetin fiyatını al
                string secilenHizmet = hizmetlist.SelectedItem.ToString();
                string hizmetFiyatStr = cagir.hizmetler
                    .Where(h => h.hizmet == secilenHizmet)
                    .Select(h => h.fiyat)
                    .FirstOrDefault();

                // Fiyat dönüştürme
                int hizmetFiyat = 0;
                if (!int.TryParse(hizmetFiyatStr, out hizmetFiyat))
                {
                    MessageBox.Show("Hizmet fiyatı geçerli bir sayı değil! Lütfen veritabanını kontrol edin.");
                    return;
                }

                // Seanslar tablosuna ekleme
                Seanslar ekle = new Seanslar
                {
                    Ad = adtxt.Text,
                    Soyad = soyadtxt.Text,
                    VerilenHizmet = secilenHizmet,
                    Tarih = secilengun,
                    Saat = secilenSaat,
                    kazanc = hizmetFiyat
                };

                cagir.Seanslar.Add(ekle);
                cagir.SaveChanges();

                MessageBox.Show($"Seans başarıyla eklendi. Kazanç: {hizmetFiyat:C}");

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
            var liste = cagir.müşteriler.AsNoTracking().ToList();
            musteridatagrid.DataSource = liste;
            musteridatagrid.ClearSelection();
            adtxt.Clear();
            soyadtxt.Clear();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            CalisanKayitForm calisanKayitForm = new CalisanKayitForm();
            calisanKayitForm.Show();
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

            var uygulamalar = from hizmet in cagir.hizmetler
                              select hizmet.hizmet;
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
    }
}
