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
                              }).ToList();
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
                try
                {
                    int id = Convert.ToInt32(ıdtxt.Text);
                    var bgl = db.baglan();
                    var guncelle = bgl.Seanslar.Find(id);

                    DateTime secilenTarih = tarihzaman.Value.Date;
                    TimeSpan secilenSaat = TimeSpan.Parse(combosaat.Text);

                    // Eski tarih kontrolü
                    if (secilenTarih < DateTime.Now.Date)
                    {
                        MessageBox.Show("Geçmiş tarih seçemezsiniz!");
                        return;
                    }

                    // Aynı tarih ve saatte başka bir seans var mı kontrolü
                    bool seansVar = bgl.Seanslar.Any(s => s.Tarih == secilenTarih && s.Saat == secilenSaat && s.SeansID != id);

                    if (seansVar)
                    {
                        MessageBox.Show("Bu tarih ve saatte zaten bir seans var! Lütfen farklı bir saat seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Güncelleme işlemi
                    guncelle.Tarih = secilenTarih;
                    guncelle.Ad = adtxt.Text;
                    guncelle.Soyad = soyadtxt.Text;
                    guncelle.Saat = secilenSaat;

                    bgl.SaveChanges();
                    listele();

                    MessageBox.Show("Seans başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void seansdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Seçili satırın indeksini alıyoruz
                int secilensatir = e.RowIndex;

                // Geçersiz satır kontrolü (örneğin, başlık satırı seçildiyse)
                if (secilensatir < 0) return;

                // Hücrelerden değerleri okuyarak ilgili alanlara dolduruyoruz
                ıdtxt.Text = seansdatagrid.Rows[secilensatir].Cells["SeansID"].Value?.ToString() ?? "";
                adtxt.Text = seansdatagrid.Rows[secilensatir].Cells["Ad"].Value?.ToString() ?? "";
                soyadtxt.Text = seansdatagrid.Rows[secilensatir].Cells["Soyad"].Value?.ToString() ?? "";
                tarihzaman.Value = Convert.ToDateTime(seansdatagrid.Rows[secilensatir].Cells["Tarih"].Value ?? DateTime.Now);
                combosaat.Text = seansdatagrid.Rows[secilensatir].Cells["Saat"].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                // Hata mesajı kullanıcıya gösterilir
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ıdtxt.Text);
                var bgl = db.baglan();
                var sil = bgl.Seanslar.Find(id);
                bgl.Seanslar.Remove(sil);
                bgl.SaveChanges();
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void Filtre()
        {
            try
            {
                var cagir = db.baglan();
                var sorgu = cagir.Seanslar.AsQueryable();

                

                // Saat filtresi
                if (combofiltresaat.SelectedItem != null)
                {
                    if (TimeSpan.TryParse(combofiltresaat.SelectedItem.ToString(), out TimeSpan secilenSaat))
                    {
                        sorgu = sorgu.Where(m => m.Saat == secilenSaat);
                    }
                }

                // Ad filtresi
                if (!string.IsNullOrEmpty(txtfiltread.Text.Trim()))
                {
                    sorgu = sorgu.Where(m => m.Ad.Contains(txtfiltread.Text.Trim()));
                }

                // Soyad filtresi
                if (!string.IsNullOrEmpty(txtfiltresoyad.Text.Trim()))
                {
                    sorgu = sorgu.Where(m => m.Soyad.Contains(txtfiltresoyad.Text.Trim()));
                }

                // Sorgu sonuçlarını listeye dönüştür
                var filtrelenmisListe = sorgu.Select(m => new
                {
                    m.SeansID,
                    m.musteriID,
                    m.Ad,
                    m.Soyad,
                    m.hizmetID,
                    m.VerilenHizmet,
                    m.Tarih,
                    m.Saat
                }).ToList();

                // Sonuçları DataGrid'e aktar
                seansdatagrid.DataSource = filtrelenmisListe;
                seansdatagrid.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void filtrezaman()
        {
            var cagir = db.baglan();
            DateTime secilenTarih = filtretarih.Value.Date;
            if (secilenTarih == DateTime.MinValue)
            {
                MessageBox.Show("Lütfen bir tarih seçin.", "Tarih Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Tarih seçilmediği için işlemi sonlandırıyoruz
            }

            var filtrelenmisListe = cagir.Seanslar.AsNoTracking().Where(m =>
                (secilenTarih == DateTime.MinValue || DbFunctions.TruncateTime(m.Tarih) == secilenTarih)
            ).ToList();

            seansdatagrid.DataSource = filtrelenmisListe;
            seansdatagrid.ClearSelection();
        }

        private void txtfiltread_TextChanged(object sender, EventArgs e)
        {
            if (checkfiltre.Checked)
            {
                Filtre();
            }
            else
            {
                listele();
            }
        }

        private void txtfiltresoyad_TextChanged(object sender, EventArgs e)
        {
            if (checkfiltre.Checked)
            {
                Filtre();
            }
            else
            {
                listele();
            }
        }

        private void combofiltresaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkfiltre.Checked)
            {
                Filtre();
            }
            else
            {
                listele();
            }

        }

        private void filtretarih_ValueChanged_1(object sender, EventArgs e)
        {
            if (checkfiltre.Checked)
            {
                filtrezaman();
            }
            else
            {
                listele();
            }
        }



        private void checkfiltre_CheckedChanged(object sender, EventArgs e)
        {
            if(checkfiltre.Checked)
            {
               txtfiltread.Visible = true;
                txtfiltresoyad.Visible = true;
                txtfiltrekazanc.Visible = true;
                combofiltresaat.Visible = true;
                checkfiltretarih.Visible = true;
                lblad.Visible = true;
                lblsoyad.Visible = true;
                lbltel.Visible = true;

            }
            else
            {
                 txtfiltread.Visible = false;
                txtfiltresoyad.Visible = false;
                txtfiltrekazanc.Visible = false;
                combofiltresaat.Visible = false;
                checkfiltretarih.Visible = false;
                lblad.Visible = false;
                lblsoyad.Visible = false;
                lbltel.Visible = false;
                txtfiltread.Clear();
                txtfiltresoyad.Clear();
                txtfiltrekazanc.Clear();
                combofiltresaat.ResetText();
                checkfiltretarih.Checked = false;
                listele();
            }
        }

        private void checkfiltretarih_CheckedChanged(object sender, EventArgs e)
        {
           if (checkfiltretarih.Checked)
            {
                filtretarih.Visible = true;
            }
            else
            {
                filtretarih.Visible = false;
                filtretarih.ResetText();
                listele();
            }

        }


    }
}
