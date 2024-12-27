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
    public partial class CalisanHizmetsecim : Form
    {
        public CalisanHizmetsecim()
        {
            InitializeComponent();
            tarihzamanaracı.MinDate = DateTime.Now.Date;
        } 
        

        private void btnonay_Click(object sender, EventArgs e)
        {
            if (hizmetlist.SelectedItem == null || tarihzamanaracı.Text == "" || combosaat.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }
            else
            {
                
                DateTime bugun = DateTime.Now.Date;
                DateTime secilengun = tarihzamanaracı.Value.Date;

                Seanslar ekle = new Seanslar();
                ekle.VerilenHizmet = hizmetlist.SelectedItem.ToString();
                if(secilengun >= bugun)
                {
                    ekle.Tarih = tarihzamanaracı.Value;
                }
                else
                {
                    MessageBox.Show("Lütfen eski bir tarihi secmeyiniz!");
                }
                
                ekle.Saat = TimeSpan.Parse(combosaat.Text);
                
            }





            CalisanSeans cseans = new CalisanSeans();   
            cseans.Show();
            this.Close();
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
    }
}
