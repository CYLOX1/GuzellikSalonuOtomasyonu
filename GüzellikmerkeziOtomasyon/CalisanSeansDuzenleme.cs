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
        }
        private void CalisanSeansDuzenleme_Load(object sender, EventArgs e)
        {
            listele();

            combosaat.Items.Add("8.00");
            combosaat.Items.Add("14.00");

        }
        private void ıdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btndegistir_Click(object sender, EventArgs e)
        {
            if (adtxt.Text == "" || soyadtxt.Text == "" || teltxt.Text == "")
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
                //guncelle.Saat = combosaat.SelectedValue.ToString();    Combobox itemini sql e gönderme
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
            teltxt.Text = seansdatagrid.Rows[secilensatir].Cells[3].Value.ToString();
        }
    }
}
