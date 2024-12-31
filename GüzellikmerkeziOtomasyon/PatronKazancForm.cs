﻿using System;
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
            kazanclbl.Text = db.baglan().Seanslar.Sum(x => x.kazanc).ToString();
        }
    }
}
