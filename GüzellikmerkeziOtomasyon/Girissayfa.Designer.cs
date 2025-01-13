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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Girissayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.grspanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.kaditxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.kapatmafoto = new System.Windows.Forms.PictureBox();
            this.kucultfoto = new System.Windows.Forms.PictureBox();
            this.kapatfoto = new System.Windows.Forms.PictureBox();
            this.grspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(656, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "GİRİŞ";
            // 
            // grspanel
            // 
            this.grspanel.BackColor = System.Drawing.Color.SeaShell;
            this.grspanel.Controls.Add(this.pictureBox2);
            this.grspanel.Controls.Add(this.pictureBox1);
            this.grspanel.Controls.Add(this.sifretxt);
            this.grspanel.Controls.Add(this.kaditxt);
            this.grspanel.Controls.Add(this.label3);
            this.grspanel.Controls.Add(this.label2);
            this.grspanel.Location = new System.Drawing.Point(369, 99);
            this.grspanel.Name = "grspanel";
            this.grspanel.Size = new System.Drawing.Size(638, 379);
            this.grspanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(264, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(507, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 40);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sifretxt
            // 
            this.sifretxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifretxt.Location = new System.Drawing.Point(232, 254);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(252, 22);
            this.sifretxt.TabIndex = 3;
            // 
            // kaditxt
            // 
            this.kaditxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kaditxt.Location = new System.Drawing.Point(232, 185);
            this.kaditxt.Name = "kaditxt";
            this.kaditxt.Size = new System.Drawing.Size(252, 22);
            this.kaditxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 185);
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
            this.btngiris.Location = new System.Drawing.Point(642, 501);
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
            this.label4.Location = new System.Drawing.Point(21, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "KAPAT";
            // 
            // kapatmafoto
            // 
            this.kapatmafoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.InitialImage = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.Location = new System.Drawing.Point(1299, 12);
            this.kapatmafoto.Name = "kapatmafoto";
            this.kapatmafoto.Size = new System.Drawing.Size(31, 35);
            this.kapatmafoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapatmafoto.TabIndex = 10;
            this.kapatmafoto.TabStop = false;
            this.kapatmafoto.Click += new System.EventHandler(this.kapatmafoto_Click);
            // 
            // kucultfoto
            // 
            this.kucultfoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_drop_down_50;
            this.kucultfoto.Location = new System.Drawing.Point(1256, 12);
            this.kucultfoto.Name = "kucultfoto";
            this.kucultfoto.Size = new System.Drawing.Size(37, 35);
            this.kucultfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kucultfoto.TabIndex = 9;
            this.kucultfoto.TabStop = false;
            this.kucultfoto.Click += new System.EventHandler(this.kucultfoto_Click);
            // 
            // kapatfoto
            // 
            this.kapatfoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_shutdown_64;
            this.kapatfoto.Location = new System.Drawing.Point(12, 558);
            this.kapatfoto.Name = "kapatfoto";
            this.kapatfoto.Size = new System.Drawing.Size(68, 70);
            this.kapatfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapatfoto.TabIndex = 7;
            this.kapatfoto.TabStop = false;
            this.kapatfoto.Click += new System.EventHandler(this.kapatfoto_Click);
            // 
            // Girissayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1342, 668);
            this.Controls.Add(this.kapatmafoto);
            this.Controls.Add(this.kucultfoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kapatfoto);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.grspanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Girissayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Girissayfa_Load);
            this.grspanel.ResumeLayout(false);
            this.grspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PictureBox kucultfoto;
        private System.Windows.Forms.PictureBox kapatmafoto;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

