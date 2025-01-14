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
    public partial class PatronKazancForm : Form
    {
        public PatronKazancForm()
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

        private void SeanslariListele()
        {
            // Tüm seansları listele
            var seanslar = db.baglan().Seanslar
                .Select(x => new
                {
                    x.Tarih,
                    x.VerilenHizmet,
                    x.kazanc
                })
                .ToList();

            // DataGridView'e bağla
            kazancdatagrid.DataSource = seanslar;
        }
        private void kucultfoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void kapatmafoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatronKazancForm_Load(object sender, EventArgs e)
        {
            DateTime ayinIlkGunu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddSeconds(-1);

            // Bu ayın kazancını hesapla
            var buAyinKazanci = db.baglan().Seanslar
                .Where(x => x.Tarih >= ayinIlkGunu && x.Tarih <= ayinSonGunu)
                .Sum(x => x.kazanc);

            // Kazancı label'a yazdır
            kazanclbl.Text = buAyinKazanci.ToString();
            SeanslariListele();
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dateTimebaslangic.Value.Date;
            DateTime bitisTarihi = dateTimebitis.Value.Date.AddDays(1).AddSeconds(-1); // Gün sonuna kadar

            // Seansları tarih aralığına göre filtrele
            var filtrelenmisSeanslar = db.baglan().Seanslar
                .Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi)
                .Select(x => new
                {
                    x.Tarih,
                    x.VerilenHizmet,
                    x.kazanc
                })
                .ToList();

            // DataGridView'e bağla
          kazancdatagrid.DataSource = filtrelenmisSeanslar;

            // Filtrelenen seansların toplam kazancını hesapla
            var toplamKazanc = filtrelenmisSeanslar.Sum(x => x.kazanc);

            // Toplam kazancı Label'a yazdır
            filtrekazanc.Text = toplamKazanc.ToString(); 
        }

        private void Tümü_Click(object sender, EventArgs e)
        {
            SeanslariListele();
        }
    }
}
