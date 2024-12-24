namespace GüzellikmerkeziOtomasyon
{
    partial class CalisanArayuz
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
            this.btnseansduzen = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmusteriduzen = new System.Windows.Forms.Button();
            this.btnyenimusteri = new System.Windows.Forms.Button();
            this.btnseansbak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnseansduzen
            // 
            this.btnseansduzen.BackColor = System.Drawing.Color.HotPink;
            this.btnseansduzen.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseansduzen.Location = new System.Drawing.Point(494, 375);
            this.btnseansduzen.Name = "btnseansduzen";
            this.btnseansduzen.Size = new System.Drawing.Size(242, 74);
            this.btnseansduzen.TabIndex = 21;
            this.btnseansduzen.Text = "SEANS DÜZENLE";
            this.btnseansduzen.UseVisualStyleBackColor = false;
            this.btnseansduzen.Click += new System.EventHandler(this.btnseansduzen_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.HotPink;
            this.btncıkıs.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncıkıs.ForeColor = System.Drawing.SystemColors.Control;
            this.btncıkıs.Location = new System.Drawing.Point(12, 530);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(91, 41);
            this.btncıkıs.TabIndex = 20;
            this.btncıkıs.Text = "ÇIKIŞ";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(236, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "ÇALIŞAN ARA YÜZÜNE HOŞ GELDİNİZ";
            // 
            // btnmusteriduzen
            // 
            this.btnmusteriduzen.BackColor = System.Drawing.Color.HotPink;
            this.btnmusteriduzen.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmusteriduzen.Location = new System.Drawing.Point(322, 254);
            this.btnmusteriduzen.Name = "btnmusteriduzen";
            this.btnmusteriduzen.Size = new System.Drawing.Size(253, 74);
            this.btnmusteriduzen.TabIndex = 18;
            this.btnmusteriduzen.Text = "MÜŞTERİ DÜZENLE";
            this.btnmusteriduzen.UseVisualStyleBackColor = false;
            this.btnmusteriduzen.Click += new System.EventHandler(this.btnmusteriduzen_Click);
            // 
            // btnyenimusteri
            // 
            this.btnyenimusteri.BackColor = System.Drawing.Color.HotPink;
            this.btnyenimusteri.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyenimusteri.Location = new System.Drawing.Point(161, 134);
            this.btnyenimusteri.Name = "btnyenimusteri";
            this.btnyenimusteri.Size = new System.Drawing.Size(247, 74);
            this.btnyenimusteri.TabIndex = 17;
            this.btnyenimusteri.Text = "YENİ MÜŞTERİ";
            this.btnyenimusteri.UseVisualStyleBackColor = false;
            this.btnyenimusteri.Click += new System.EventHandler(this.btnyenimusteri_Click);
            // 
            // btnseansbak
            // 
            this.btnseansbak.BackColor = System.Drawing.Color.HotPink;
            this.btnseansbak.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseansbak.Location = new System.Drawing.Point(692, 482);
            this.btnseansbak.Name = "btnseansbak";
            this.btnseansbak.Size = new System.Drawing.Size(247, 74);
            this.btnseansbak.TabIndex = 22;
            this.btnseansbak.Text = "SEANS GÖRÜNTÜLE";
            this.btnseansbak.UseVisualStyleBackColor = false;
            this.btnseansbak.Click += new System.EventHandler(this.btnseansbak_Click);
            // 
            // CalisanArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.btnseansbak);
            this.Controls.Add(this.btnseansduzen);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmusteriduzen);
            this.Controls.Add(this.btnyenimusteri);
            this.Name = "CalisanArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnseansduzen;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmusteriduzen;
        private System.Windows.Forms.Button btnyenimusteri;
        private System.Windows.Forms.Button btnseansbak;
    }
}