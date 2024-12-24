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
            this.label2.Location = new System.Drawing.Point(545, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "SENAS ZAMANI";
            // 
            // tarihzamanaracı
            // 
            this.tarihzamanaracı.Location = new System.Drawing.Point(527, 196);
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
            this.btnonay.Location = new System.Drawing.Point(516, 389);
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
            this.hizmetlist.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hizmetlist.FormattingEnabled = true;
            this.hizmetlist.Items.AddRange(new object[] {
            "Manikür",
            "Pedikür",
            "Epilasyon ",
            "Kalıcı Makyaj",
            "Kirpik ",
            "Cilt Bakımı",
            "Protez Tırnak"});
            this.hizmetlist.Location = new System.Drawing.Point(145, 136);
            this.hizmetlist.Name = "hizmetlist";
            this.hizmetlist.Size = new System.Drawing.Size(253, 337);
            this.hizmetlist.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(211, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "HİZMETLER";
            // 
            // CalisanHizmetsecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tarihzamanaracı);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnonay);
            this.Controls.Add(this.hizmetlist);
            this.Name = "CalisanHizmetsecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hizmetsecim";
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
    }
}