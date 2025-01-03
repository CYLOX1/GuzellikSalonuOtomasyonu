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
                int secilensatir = seansdatagrid.SelectedCells[0].RowIndex;
                ıdtxt.Text = seansdatagrid.Rows[secilensatir].Cells[0].Value.ToString();
                adtxt.Text = seansdatagrid.Rows[secilensatir].Cells[1].Value.ToString();
                soyadtxt.Text = seansdatagrid.Rows[secilensatir].Cells[2].Value.ToString();
                tarihzaman.Text = seansdatagrid.Rows[secilensatir].Cells[4].Value.ToString();
                combosaat.Text = seansdatagrid.Rows[secilensatir].Cells[5].Value.ToString();
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
                var sil = bgl.Seanslar.Find(id);
                bgl.Seanslar.Remove(sil);
                bgl.SaveChanges();
                listele();
            }
            catch(Exception ex)
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



        private void filtreadsoyad()
        {



            {
                var cagir = db.baglan();

                // DateTimePicker'dan seçilen tarihi alıyoruz
                DateTime secilenTarih = filtretarih.Value.Date;

                if (secilenTarih == DateTime.MinValue)
                {
                    MessageBox.Show("Lütfen bir tarih seçin.", "Tarih Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Tarih seçilmediği için işlemi sonlandırıyoruz
                }

                    // Combobox'tan seçilen saat değerini TimeSpan'a dönüştür
                    TimeSpan? secilenSaat = null;
                if (combofiltresaat.SelectedItem != null)
                {
                    if (TimeSpan.TryParse(combofiltresaat.SelectedItem.ToString(), out TimeSpan result))
                    {
                        secilenSaat = result;
                    }
                }

                // Filtrelenmiş listeyi sorgulama
                var filtrelenmisListe = cagir.Seanslar.AsNoTracking().Where(m =>
                    // Ad filtresi
                    (string.IsNullOrEmpty(txtfiltread.Text) || m.Ad.Contains(txtfiltread.Text)) &&
                    // Soyad filtresi
                    (string.IsNullOrEmpty(txtfiltresoyad.Text) || m.Soyad.Contains(txtfiltresoyad.Text)) &&
                    // Saat filtresi (eğer saat seçilmişse, saat karşılaştırması yapılır)
                    (!secilenSaat.HasValue || m.Saat == secilenSaat.Value)
                ).ToList();

                // Sonuçları grid'e aktar
                seansdatagrid.DataSource = filtrelenmisListe;
                seansdatagrid.ClearSelection();
            }

            //var cagir = db.baglan();
            //var filtrelenmisListe = cagir.Seanslar.AsNoTracking().Where(m =>
            //    (string.IsNullOrEmpty(txtfiltread.Text) || m.Ad.Contains(txtfiltread.Text)) &&
            //    (string.IsNullOrEmpty(txtfiltresoyad.Text) || m.Soyad.Contains(txtfiltresoyad.Text)) 
            //).ToList();

            //seansdatagrid.DataSource = filtrelenmisListe;
            //seansdatagrid.ClearSelection();



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



        private void checkfiltre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkfiltre.Checked)
            {
                checkfiltretarih.Visible = true;
                txtfiltread.Visible = true;
                txtfiltresoyad.Visible = true;

                combofiltresaat.Visible = true;
            }
            else
            {
                checkfiltretarih.Visible = false;
                txtfiltread.Visible = false;
                txtfiltresoyad.Visible = false;
                filtretarih.Visible = false;
                combofiltresaat.Visible = false;
                txtfiltread.Clear();
                txtfiltresoyad.Clear();
                combofiltresaat.ResetText();
                filtretarih.Value = DateTime.Now;
                listele();
            }
        }

        private void txtfiltread_TextChanged(object sender, EventArgs e)
        {
            filtreadsoyad();
        }

        private void txtfiltresoyad_TextChanged(object sender, EventArgs e)
        {
            filtreadsoyad();
        }

        private void filtretarih_ValueChanged(object sender, EventArgs e)
        {
            filtrezaman();
        }

        private void combofiltresaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtreadsoyad();
        }

        private void checkfiltretarih_CheckedChanged(object sender, EventArgs e)
        {
            if (checkfiltretarih.Checked)
            {
                filtretarih.Visible = true;
                filtrezaman();
            }
            else
            {
                filtretarih.Visible = false;
                listele();
            }
        }
    }
}
