namespace GüzellikmerkeziOtomasyon
{
    partial class PatronArayuz
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
            this.btnfiyat = new System.Windows.Forms.Button();
            this.btncalisan = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmusteri = new System.Windows.Forms.Button();
            this.btnkazanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfiyat
            // 
            this.btnfiyat.BackColor = System.Drawing.Color.HotPink;
            this.btnfiyat.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiyat.Location = new System.Drawing.Point(641, 443);
            this.btnfiyat.Name = "btnfiyat";
            this.btnfiyat.Size = new System.Drawing.Size(231, 73);
            this.btnfiyat.TabIndex = 18;
            this.btnfiyat.Text = "FİYAT DÜZENLEME";
            this.btnfiyat.UseVisualStyleBackColor = false;
            this.btnfiyat.Click += new System.EventHandler(this.btnfiyat_Click);
            // 
            // btncalisan
            // 
            this.btncalisan.BackColor = System.Drawing.Color.HotPink;
            this.btncalisan.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalisan.Location = new System.Drawing.Point(499, 346);
            this.btncalisan.Name = "btncalisan";
            this.btncalisan.Size = new System.Drawing.Size(227, 75);
            this.btncalisan.TabIndex = 17;
            this.btncalisan.Text = "ÇALIŞANLARI DÜZENLE";
            this.btncalisan.UseVisualStyleBackColor = false;
            this.btncalisan.Click += new System.EventHandler(this.btncalisan_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.HotPink;
            this.btncıkıs.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncıkıs.ForeColor = System.Drawing.SystemColors.Control;
            this.btncıkıs.Location = new System.Drawing.Point(6, 537);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(91, 41);
            this.btncıkıs.TabIndex = 16;
            this.btncıkıs.Text = "ÇIKIŞ";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(261, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "PATRON ARA YÜZÜNE HOŞGELDİNİZ";
            // 
            // btnmusteri
            // 
            this.btnmusteri.BackColor = System.Drawing.Color.HotPink;
            this.btnmusteri.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmusteri.Location = new System.Drawing.Point(339, 246);
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.Size = new System.Drawing.Size(247, 75);
            this.btnmusteri.TabIndex = 14;
            this.btnmusteri.Text = "MÜŞTERİLERİ  DÜZENLE";
            this.btnmusteri.UseVisualStyleBackColor = false;
            this.btnmusteri.Click += new System.EventHandler(this.btnmusteri_Click);
            // 
            // btnkazanc
            // 
            this.btnkazanc.BackColor = System.Drawing.Color.HotPink;
            this.btnkazanc.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkazanc.Location = new System.Drawing.Point(174, 150);
            this.btnkazanc.Name = "btnkazanc";
            this.btnkazanc.Size = new System.Drawing.Size(241, 77);
            this.btnkazanc.TabIndex = 13;
            this.btnkazanc.Text = "KAZANCI GÖRÜNTÜLE";
            this.btnkazanc.UseVisualStyleBackColor = false;
            this.btnkazanc.Click += new System.EventHandler(this.btnkazanc_Click);
            // 
            // PatronArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.btnfiyat);
            this.Controls.Add(this.btncalisan);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmusteri);
            this.Controls.Add(this.btnkazanc);
            this.Name = "PatronArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatronArayüz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfiyat;
        private System.Windows.Forms.Button btncalisan;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmusteri;
        private System.Windows.Forms.Button btnkazanc;
    }
}