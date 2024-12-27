namespace GüzellikmerkeziOtomasyon
{
    partial class CalisanKayitForm
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
            this.btngeri = new System.Windows.Forms.Button();
            this.btnkkaydet = new System.Windows.Forms.Button();
            this.cinsiyet = new System.Windows.Forms.GroupBox();
            this.radioerkek = new System.Windows.Forms.RadioButton();
            this.radiokadin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kytpanel = new System.Windows.Forms.Panel();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.kapatmafoto = new System.Windows.Forms.PictureBox();
            this.kucultfoto = new System.Windows.Forms.PictureBox();
            this.cinsiyet.SuspendLayout();
            this.kytpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.HotPink;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btngeri.Location = new System.Drawing.Point(12, 525);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(84, 46);
            this.btngeri.TabIndex = 16;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnkkaydet
            // 
            this.btnkkaydet.BackColor = System.Drawing.Color.HotPink;
            this.btnkkaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkkaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnkkaydet.Location = new System.Drawing.Point(447, 497);
            this.btnkkaydet.Name = "btnkkaydet";
            this.btnkkaydet.Size = new System.Drawing.Size(194, 68);
            this.btnkkaydet.TabIndex = 15;
            this.btnkkaydet.Text = "KAYDET";
            this.btnkkaydet.UseVisualStyleBackColor = false;
            this.btnkkaydet.Click += new System.EventHandler(this.btnkkaydet_Click);
            // 
            // cinsiyet
            // 
            this.cinsiyet.Controls.Add(this.radioerkek);
            this.cinsiyet.Controls.Add(this.radiokadin);
            this.cinsiyet.Location = new System.Drawing.Point(280, 384);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(501, 107);
            this.cinsiyet.TabIndex = 14;
            this.cinsiyet.TabStop = false;
            this.cinsiyet.Text = "groupBox1";
            // 
            // radioerkek
            // 
            this.radioerkek.AutoSize = true;
            this.radioerkek.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioerkek.Location = new System.Drawing.Point(312, 47);
            this.radioerkek.Name = "radioerkek";
            this.radioerkek.Size = new System.Drawing.Size(76, 23);
            this.radioerkek.TabIndex = 1;
            this.radioerkek.TabStop = true;
            this.radioerkek.Text = "ERKEK";
            this.radioerkek.UseVisualStyleBackColor = true;
            // 
            // radiokadin
            // 
            this.radiokadin.AutoSize = true;
            this.radiokadin.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiokadin.Location = new System.Drawing.Point(137, 56);
            this.radiokadin.Name = "radiokadin";
            this.radiokadin.Size = new System.Drawing.Size(79, 23);
            this.radiokadin.TabIndex = 0;
            this.radiokadin.TabStop = true;
            this.radiokadin.Text = "KADIN";
            this.radiokadin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(442, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "KAYIT FORMU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(373, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "GÜZELLİK MERKEZİ ";
            // 
            // kytpanel
            // 
            this.kytpanel.BackColor = System.Drawing.Color.SeaShell;
            this.kytpanel.Controls.Add(this.teltxt);
            this.kytpanel.Controls.Add(this.soyadtxt);
            this.kytpanel.Controls.Add(this.label3);
            this.kytpanel.Controls.Add(this.label2);
            this.kytpanel.Controls.Add(this.label1);
            this.kytpanel.Controls.Add(this.adtxt);
            this.kytpanel.Location = new System.Drawing.Point(280, 159);
            this.kytpanel.Name = "kytpanel";
            this.kytpanel.Size = new System.Drawing.Size(501, 219);
            this.kytpanel.TabIndex = 11;
            // 
            // teltxt
            // 
            this.teltxt.BackColor = System.Drawing.SystemColors.Window;
            this.teltxt.Location = new System.Drawing.Point(193, 137);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(195, 22);
            this.teltxt.TabIndex = 5;
            // 
            // soyadtxt
            // 
            this.soyadtxt.BackColor = System.Drawing.SystemColors.Window;
            this.soyadtxt.Location = new System.Drawing.Point(193, 97);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(195, 22);
            this.soyadtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "TELEFON :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYAD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD :";
            // 
            // adtxt
            // 
            this.adtxt.BackColor = System.Drawing.SystemColors.Window;
            this.adtxt.Location = new System.Drawing.Point(193, 54);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(195, 22);
            this.adtxt.TabIndex = 0;
            // 
            // kapatmafoto
            // 
            this.kapatmafoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.InitialImage = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.Location = new System.Drawing.Point(1029, 12);
            this.kapatmafoto.Name = "kapatmafoto";
            this.kapatmafoto.Size = new System.Drawing.Size(31, 35);
            this.kapatmafoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapatmafoto.TabIndex = 26;
            this.kapatmafoto.TabStop = false;
            this.kapatmafoto.Click += new System.EventHandler(this.kapatmafoto_Click);
            // 
            // kucultfoto
            // 
            this.kucultfoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_drop_down_50;
            this.kucultfoto.Location = new System.Drawing.Point(986, 12);
            this.kucultfoto.Name = "kucultfoto";
            this.kucultfoto.Size = new System.Drawing.Size(37, 35);
            this.kucultfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kucultfoto.TabIndex = 25;
            this.kucultfoto.TabStop = false;
            this.kucultfoto.Click += new System.EventHandler(this.kucultfoto_Click);
            // 
            // CalisanKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.kapatmafoto);
            this.Controls.Add(this.kucultfoto);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnkkaydet);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kytpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalisanKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayitform";
            this.cinsiyet.ResumeLayout(false);
            this.cinsiyet.PerformLayout();
            this.kytpanel.ResumeLayout(false);
            this.kytpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnkkaydet;
        private System.Windows.Forms.GroupBox cinsiyet;
        private System.Windows.Forms.RadioButton radioerkek;
        private System.Windows.Forms.RadioButton radiokadin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel kytpanel;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.PictureBox kapatmafoto;
        private System.Windows.Forms.PictureBox kucultfoto;
    }
}