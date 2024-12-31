namespace GüzellikmerkeziOtomasyon
{
    partial class CalisanHizmetsecim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tarihzamanaracı = new System.Windows.Forms.DateTimePicker();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnonay = new System.Windows.Forms.Button();
            this.hizmetlist = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combosaat = new System.Windows.Forms.ComboBox();
            this.musteridatagrid = new System.Windows.Forms.DataGridView();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.musteriad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ıdtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kapatmafoto = new System.Windows.Forms.PictureBox();
            this.kucultfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.musteridatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(378, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 40);
            this.label3.TabIndex = 54;
            this.label3.Text = "HİZMET VE TARİH SEÇİMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(881, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "SENAS ZAMANI";
            // 
            // tarihzamanaracı
            // 
            this.tarihzamanaracı.Location = new System.Drawing.Point(851, 149);
            this.tarihzamanaracı.Name = "tarihzamanaracı";
            this.tarihzamanaracı.Size = new System.Drawing.Size(191, 22);
            this.tarihzamanaracı.TabIndex = 51;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.HotPink;
            this.btngeri.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btngeri.Location = new System.Drawing.Point(12, 533);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(88, 38);
            this.btngeri.TabIndex = 50;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnonay
            // 
            this.btnonay.BackColor = System.Drawing.Color.HotPink;
            this.btnonay.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnonay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnonay.Location = new System.Drawing.Point(885, 487);
            this.btnonay.Name = "btnonay";
            this.btnonay.Size = new System.Drawing.Size(175, 84);
            this.btnonay.TabIndex = 49;
            this.btnonay.Text = "ONAYLA";
            this.btnonay.UseVisualStyleBackColor = false;
            this.btnonay.Click += new System.EventHandler(this.btnonay_Click);
            // 
            // hizmetlist
            // 
            this.hizmetlist.CheckOnClick = true;
            this.hizmetlist.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hizmetlist.FormattingEnabled = true;
            this.hizmetlist.Location = new System.Drawing.Point(559, 149);
            this.hizmetlist.Name = "hizmetlist";
            this.hizmetlist.Size = new System.Drawing.Size(253, 312);
            this.hizmetlist.TabIndex = 48;
            this.hizmetlist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.hizmetlist_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(625, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "HİZMETLER";
            // 
            // combosaat
            // 
            this.combosaat.FormattingEnabled = true;
            this.combosaat.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.combosaat.Location = new System.Drawing.Point(874, 277);
            this.combosaat.Name = "combosaat";
            this.combosaat.Size = new System.Drawing.Size(153, 24);
            this.combosaat.TabIndex = 56;
            // 
            // musteridatagrid
            // 
            this.musteridatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteridatagrid.Location = new System.Drawing.Point(3, 107);
            this.musteridatagrid.Name = "musteridatagrid";
            this.musteridatagrid.RowHeadersWidth = 51;
            this.musteridatagrid.RowTemplate.Height = 24;
            this.musteridatagrid.Size = new System.Drawing.Size(524, 237);
            this.musteridatagrid.TabIndex = 59;
            this.musteridatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteridatagrid_CellClick);
            // 
            // adtxt
            // 
            this.adtxt.Enabled = false;
            this.adtxt.Location = new System.Drawing.Point(171, 402);
            this.adtxt.Name = "adtxt";
            this.adtxt.ReadOnly = true;
            this.adtxt.Size = new System.Drawing.Size(159, 22);
            this.adtxt.TabIndex = 61;
            // 
            // soyadtxt
            // 
            this.soyadtxt.Enabled = false;
            this.soyadtxt.Location = new System.Drawing.Point(345, 402);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.ReadOnly = true;
            this.soyadtxt.Size = new System.Drawing.Size(156, 22);
            this.soyadtxt.TabIndex = 62;
            // 
            // musteriad
            // 
            this.musteriad.AutoSize = true;
            this.musteriad.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriad.Location = new System.Drawing.Point(233, 360);
            this.musteriad.Name = "musteriad";
            this.musteriad.Size = new System.Drawing.Size(36, 24);
            this.musteriad.TabIndex = 63;
            this.musteriad.Text = "AD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(391, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "SOYAD";
            // 
            // ıdtxt
            // 
            this.ıdtxt.Enabled = false;
            this.ıdtxt.Location = new System.Drawing.Point(6, 402);
            this.ıdtxt.Name = "ıdtxt";
            this.ıdtxt.ReadOnly = true;
            this.ıdtxt.Size = new System.Drawing.Size(159, 22);
            this.ıdtxt.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "ID";
            // 
            // kapatmafoto
            // 
            this.kapatmafoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.InitialImage = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.Location = new System.Drawing.Point(1034, 12);
            this.kapatmafoto.Name = "kapatmafoto";
            this.kapatmafoto.Size = new System.Drawing.Size(31, 35);
            this.kapatmafoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapatmafoto.TabIndex = 58;
            this.kapatmafoto.TabStop = false;
            this.kapatmafoto.Click += new System.EventHandler(this.kapatmafoto_Click);
            // 
            // kucultfoto
            // 
            this.kucultfoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_drop_down_50;
            this.kucultfoto.Location = new System.Drawing.Point(991, 12);
            this.kucultfoto.Name = "kucultfoto";
            this.kucultfoto.Size = new System.Drawing.Size(37, 35);
            this.kucultfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kucultfoto.TabIndex = 57;
            this.kucultfoto.TabStop = false;
            this.kucultfoto.Click += new System.EventHandler(this.kucultfoto_Click);
            // 
            // CalisanHizmetsecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ıdtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.musteriad);
            this.Controls.Add(this.soyadtxt);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.musteridatagrid);
            this.Controls.Add(this.kapatmafoto);
            this.Controls.Add(this.kucultfoto);
            this.Controls.Add(this.combosaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tarihzamanaracı);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnonay);
            this.Controls.Add(this.hizmetlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalisanHizmetsecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hizmetsecim";
            this.Load += new System.EventHandler(this.CalisanHizmetsecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteridatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tarihzamanaracı;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnonay;
        private System.Windows.Forms.CheckedListBox hizmetlist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combosaat;
        private System.Windows.Forms.PictureBox kapatmafoto;
        private System.Windows.Forms.PictureBox kucultfoto;
        private System.Windows.Forms.DataGridView musteridatagrid;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.Label musteriad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ıdtxt;
        private System.Windows.Forms.Label label1;
    }
}