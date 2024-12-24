namespace GüzellikmerkeziOtomasyon
{
    partial class PatronMüsteriDuzenleme
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
            this.btndegistir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.musteridatagrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musteridatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btndegistir
            // 
            this.btndegistir.BackColor = System.Drawing.Color.HotPink;
            this.btndegistir.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndegistir.ForeColor = System.Drawing.SystemColors.Control;
            this.btndegistir.Location = new System.Drawing.Point(768, 429);
            this.btndegistir.Name = "btndegistir";
            this.btndegistir.Size = new System.Drawing.Size(146, 75);
            this.btndegistir.TabIndex = 40;
            this.btndegistir.Text = "DEĞİŞTİR";
            this.btndegistir.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "TEL NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "SOYADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "ADI";
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(290, 485);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(190, 22);
            this.soyadtxt.TabIndex = 36;
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(290, 429);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(190, 22);
            this.adtxt.TabIndex = 35;
            // 
            // teltxt
            // 
            this.teltxt.Location = new System.Drawing.Point(290, 538);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(190, 22);
            this.teltxt.TabIndex = 34;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.HotPink;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsil.Location = new System.Drawing.Point(593, 429);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(146, 75);
            this.btnsil.TabIndex = 33;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.HotPink;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btngeri.Location = new System.Drawing.Point(12, 530);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(91, 41);
            this.btngeri.TabIndex = 32;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // musteridatagrid
            // 
            this.musteridatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteridatagrid.Location = new System.Drawing.Point(42, 81);
            this.musteridatagrid.Name = "musteridatagrid";
            this.musteridatagrid.RowHeadersWidth = 51;
            this.musteridatagrid.RowTemplate.Height = 24;
            this.musteridatagrid.Size = new System.Drawing.Size(957, 313);
            this.musteridatagrid.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(371, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 40);
            this.label4.TabIndex = 53;
            this.label4.Text = "MÜŞTERİ DÜZENLE";
            // 
            // PatronMüsteriDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndegistir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soyadtxt);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.teltxt);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.musteridatagrid);
            this.Name = "PatronMüsteriDuzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatronMüsteriDüzenleme";
            ((System.ComponentModel.ISupportInitialize)(this.musteridatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndegistir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.DataGridView musteridatagrid;
        private System.Windows.Forms.Label label4;
    }
}