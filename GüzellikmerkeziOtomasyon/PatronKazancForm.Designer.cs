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
            this.label3 = new System.Windows.Forms.Label();
            this.kazanclbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.kapatmafoto = new System.Windows.Forms.PictureBox();
            this.kucultfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "TL";
            // 
            // kazanclbl
            // 
            this.kazanclbl.AutoSize = true;
            this.kazanclbl.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kazanclbl.Location = new System.Drawing.Point(462, 293);
            this.kazanclbl.Name = "kazanclbl";
            this.kazanclbl.Size = new System.Drawing.Size(79, 29);
            this.kazanclbl.TabIndex = 4;
            this.kazanclbl.Text = "XXXX ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(380, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "TOPLAM GELİR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(381, 31);
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
            this.btngeri.Location = new System.Drawing.Point(12, 522);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(120, 49);
            this.btngeri.TabIndex = 53;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // kapatmafoto
            // 
            this.kapatmafoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.InitialImage = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.Location = new System.Drawing.Point(1017, 12);
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
            this.kucultfoto.Location = new System.Drawing.Point(965, 12);
            this.kucultfoto.Name = "kucultfoto";
            this.kucultfoto.Size = new System.Drawing.Size(37, 35);
            this.kucultfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kucultfoto.TabIndex = 54;
            this.kucultfoto.TabStop = false;
            this.kucultfoto.Click += new System.EventHandler(this.kucultfoto_Click);
            // 
            // PatronKazancForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1060, 583);
            this.Controls.Add(this.kapatmafoto);
            this.Controls.Add(this.kucultfoto);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kazanclbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatronKazancForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatronKazancForm";
            this.Load += new System.EventHandler(this.PatronKazancForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).EndInit();
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
    }
}