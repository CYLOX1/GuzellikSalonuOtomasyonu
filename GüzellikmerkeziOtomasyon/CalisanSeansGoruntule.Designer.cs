﻿namespace GüzellikmerkeziOtomasyon
{
    partial class CalisanSeansGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanSeansGoruntule));
            this.seanslardatagrid = new System.Windows.Forms.DataGridView();
            this.btngeri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kapatmafoto = new System.Windows.Forms.PictureBox();
            this.kucultfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.seanslardatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // seanslardatagrid
            // 
            this.seanslardatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seanslardatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seanslardatagrid.Location = new System.Drawing.Point(106, 92);
            this.seanslardatagrid.Name = "seanslardatagrid";
            this.seanslardatagrid.RowHeadersWidth = 51;
            this.seanslardatagrid.RowTemplate.Height = 24;
            this.seanslardatagrid.Size = new System.Drawing.Size(1119, 431);
            this.seanslardatagrid.TabIndex = 0;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.HotPink;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btngeri.Location = new System.Drawing.Point(12, 605);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(94, 51);
            this.btngeri.TabIndex = 51;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(580, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 40);
            this.label2.TabIndex = 52;
            this.label2.Text = "SEANSLAR";
            // 
            // kapatmafoto
            // 
            this.kapatmafoto.Image = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.InitialImage = global::GüzellikmerkeziOtomasyon.Properties.Resources.icons8_close_50;
            this.kapatmafoto.Location = new System.Drawing.Point(1299, 12);
            this.kapatmafoto.Name = "kapatmafoto";
            this.kapatmafoto.Size = new System.Drawing.Size(31, 35);
            this.kapatmafoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapatmafoto.TabIndex = 54;
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
            this.kucultfoto.TabIndex = 53;
            this.kucultfoto.TabStop = false;
            this.kucultfoto.Click += new System.EventHandler(this.kucultfoto_Click);
            // 
            // CalisanSeansGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1342, 668);
            this.Controls.Add(this.kapatmafoto);
            this.Controls.Add(this.kucultfoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.seanslardatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalisanSeansGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeansGoruntule";
            this.Load += new System.EventHandler(this.CalisanSeansGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seanslardatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatmafoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucultfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView seanslardatagrid;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox kapatmafoto;
        private System.Windows.Forms.PictureBox kucultfoto;
    }
}