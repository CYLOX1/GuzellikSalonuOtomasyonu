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
    public partial class PatronFiyatDüzenlemecs : Form
    {
        public PatronFiyatDüzenlemecs()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            PatronArayüz parayuz =new PatronArayüz();
            parayuz.Show();
            this.Close();
        }
    }
}
