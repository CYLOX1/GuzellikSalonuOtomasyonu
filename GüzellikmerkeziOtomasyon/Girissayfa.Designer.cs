namespace GüzellikmerkeziOtomasyon
{
    partial class Girissayfa
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
            this.label1 = new System.Windows.Forms.Label();
            this.grspanel = new System.Windows.Forms.Panel();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.kaditxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kapatfoto = new System.Windows.Forms.PictureBox();
            this.grspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapatfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(463, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "GİRİŞ";
            // 
            // grspanel
            // 
            this.grspanel.BackColor = System.Drawing.Color.SeaShell;
            this.grspanel.Controls.Add(this.sifretxt);
            this.grspanel.Controls.Add(this.kaditxt);
            this.grspanel.Controls.Add(this.label3);
            this.grspanel.Controls.Add(this.label2);
            this.grspanel.Location = new System.Drawing.Point(194, 115);
            this.grspanel.Name = "grspanel";
            this.grspanel.Size = new System.Drawing.Size(663, 289);
            this.grspanel.TabIndex = 2;
            // 
            // sifretxt
            // 
            this.sifretxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifretxt.Location = new System.Drawing.Point(232, 152);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(252, 22);
            this.sifretxt.TabIndex = 3;
            // 
            // kaditxt
            // 
            this.kaditxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kaditxt.Location = new System.Drawing.Point(232, 83);
            this.kaditxt.Name = "kaditxt";
            this.kaditxt.Size = new System.Drawing.Size(252, 22);
            this.kaditxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.HotPink;
            this.btngiris.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngiris.Location = new System.Drawing.Point(458, 447);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(133, 71);
            this.btngiris.TabIndex = 5;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "KAPAT";
            // 
            // kapatfoto
            // 
            this.kapatfoto.Location = new System.Drawing.Point(12, 501);
            this.kapatfoto.Name = "kapatfoto";
            this.kapatfoto.Size = new System.Drawing.Size(51, 54);
            this.kapatfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapatfoto.TabIndex = 7;
            this.kapatfoto.TabStop = false;
            // 
            // Girissayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kapatfoto);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.grspanel);
            this.Controls.Add(this.label1);
            this.Name = "Girissayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grspanel.ResumeLayout(false);
            this.grspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapatfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grspanel;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.TextBox kaditxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox kapatfoto;
    }
}

