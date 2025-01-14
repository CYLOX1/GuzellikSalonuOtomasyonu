namespace GüzellikmerkeziOtomasyon
{
    partial class PatronKazancForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatronKazancForm));
            this.label3 = new System.Windows.Forms.Label();
            this.kazanclbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.kapatmafoto = new System.Windows.Forms.PictureBox();
            this.kucultfoto = new System.Windows.Forms.PictureBox();
            this.kazancdatagrid = new System.Windows.Forms.DataGridView();
            this.dateTimebaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimebitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfiltre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filtrekazanc = new System.Windows.Forms.Label();
            this.Tümü = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazancdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "TL";
            // 
            // kazanclbl
            // 
            this.kazanclbl.AutoSize = true;
            this.kazanclbl.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kazanclbl.Location = new System.Drawing.Point(643, 160);
            this.kazanclbl.Name = "kazanclbl";
            this.kazanclbl.Size = new System.Drawing.Size(0, 29);
            this.kazanclbl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(917, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "GELİR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(595, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 40);
            this.label4.TabIndex = 52;
            this.label4.Text = "TOPLAM GELİR";
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.HotPink;
            this.btngeri.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btngeri.Location = new System.Drawing.Point(12, 596);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(131, 60);
            this.btngeri.TabIndex = 53;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // kapatmafoto
            // 
            this.kapatmafoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.InitialImage = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.Location = new System.Drawing.Point(1299, 21);
            this.kapatmafoto.Name = "kapatmafoto";
            this.kapatmafoto.Size = new System.Drawing.Size(31, 35);
            this.kapatmafoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapatmafoto.TabIndex = 55;
            this.kapatmafoto.TabStop = false;
            this.kapatmafoto.Click += new System.EventHandler(this.kapatmafoto_Click);
            // 
            // kucultfoto
            // 
            this.kucultfoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_drop_down_50;
            this.kucultfoto.Location = new System.Drawing.Point(1247, 21);
            this.kucultfoto.Name = "kucultfoto";
            this.kucultfoto.Size = new System.Drawing.Size(37, 35);
            this.kucultfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kucultfoto.TabIndex = 54;
            this.kucultfoto.TabStop = false;
            this.kucultfoto.Click += new System.EventHandler(this.kucultfoto_Click);
            // 
            // kazancdatagrid
            // 
            this.kazancdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kazancdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kazancdatagrid.Location = new System.Drawing.Point(273, 215);
            this.kazancdatagrid.Name = "kazancdatagrid";
            this.kazancdatagrid.RowHeadersWidth = 51;
            this.kazancdatagrid.RowTemplate.Height = 24;
            this.kazancdatagrid.Size = new System.Drawing.Size(831, 218);
            this.kazancdatagrid.TabIndex = 56;
            // 
            // dateTimebaslangic
            // 
            this.dateTimebaslangic.Location = new System.Drawing.Point(340, 514);
            this.dateTimebaslangic.Name = "dateTimebaslangic";
            this.dateTimebaslangic.Size = new System.Drawing.Size(200, 22);
            this.dateTimebaslangic.TabIndex = 57;
            // 
            // dateTimebitis
            // 
            this.dateTimebitis.Location = new System.Drawing.Point(583, 514);
            this.dateTimebitis.Name = "dateTimebitis";
            this.dateTimebitis.Size = new System.Drawing.Size(200, 22);
            this.dateTimebitis.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Başlangıc Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Bitiş Tarihi";
            // 
            // btnfiltre
            // 
            this.btnfiltre.BackColor = System.Drawing.Color.HotPink;
            this.btnfiltre.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltre.ForeColor = System.Drawing.SystemColors.Control;
            this.btnfiltre.Location = new System.Drawing.Point(518, 564);
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.Size = new System.Drawing.Size(90, 49);
            this.btnfiltre.TabIndex = 61;
            this.btnfiltre.Text = "Filtrele";
            this.btnfiltre.UseVisualStyleBackColor = false;
            this.btnfiltre.Click += new System.EventHandler(this.btnfiltre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(551, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 44);
            this.label6.TabIndex = 62;
            this.label6.Text = "AYLIK KAZANÇ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(964, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 29);
            this.label7.TabIndex = 64;
            this.label7.Text = "TL";
            // 
            // filtrekazanc
            // 
            this.filtrekazanc.AutoSize = true;
            this.filtrekazanc.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrekazanc.Location = new System.Drawing.Point(901, 564);
            this.filtrekazanc.Name = "filtrekazanc";
            this.filtrekazanc.Size = new System.Drawing.Size(0, 29);
            this.filtrekazanc.TabIndex = 63;
            // 
            // Tümü
            // 
            this.Tümü.BackColor = System.Drawing.Color.HotPink;
            this.Tümü.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tümü.ForeColor = System.Drawing.SystemColors.Control;
            this.Tümü.Location = new System.Drawing.Point(1163, 305);
            this.Tümü.Name = "Tümü";
            this.Tümü.Size = new System.Drawing.Size(121, 65);
            this.Tümü.TabIndex = 65;
            this.Tümü.Text = "Tüm Kazanç";
            this.Tümü.UseVisualStyleBackColor = false;
            this.Tümü.Click += new System.EventHandler(this.Tümü_Click);
            // 
            // PatronKazancForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1342, 668);
            this.Controls.Add(this.Tümü);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filtrekazanc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnfiltre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimebitis);
            this.Controls.Add(this.dateTimebaslangic);
            this.Controls.Add(this.kazancdatagrid);
            this.Controls.Add(this.kapatmafoto);
            this.Controls.Add(this.kucultfoto);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kazanclbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatronKazancForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatronKazancForm";
            this.Load += new System.EventHandler(this.PatronKazancForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazancdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kazanclbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.PictureBox kapatmafoto;
        private System.Windows.Forms.PictureBox kucultfoto;
        private System.Windows.Forms.DataGridView kazancdatagrid;
        private System.Windows.Forms.DateTimePicker dateTimebaslangic;
        private System.Windows.Forms.DateTimePicker dateTimebitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnfiltre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label filtrekazanc;
        private System.Windows.Forms.Button Tümü;
    }
}