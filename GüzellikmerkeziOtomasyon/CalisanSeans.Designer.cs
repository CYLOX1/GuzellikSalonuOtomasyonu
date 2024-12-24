namespace GüzellikmerkeziOtomasyon
{
    partial class CalisanSeans
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
            this.label2 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.seansdatagrid = new System.Windows.Forms.DataGridView();
            this.btnanasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seansdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(454, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 40);
            this.label2.TabIndex = 51;
            this.label2.Text = "SEANSLAR";
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.HotPink;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btngeri.Location = new System.Drawing.Point(12, 530);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(91, 41);
            this.btngeri.TabIndex = 49;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // seansdatagrid
            // 
            this.seansdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seansdatagrid.Location = new System.Drawing.Point(61, 106);
            this.seansdatagrid.Name = "seansdatagrid";
            this.seansdatagrid.RowHeadersWidth = 51;
            this.seansdatagrid.RowTemplate.Height = 24;
            this.seansdatagrid.Size = new System.Drawing.Size(945, 385);
            this.seansdatagrid.TabIndex = 48;
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.BackColor = System.Drawing.Color.HotPink;
            this.btnanasayfa.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanasayfa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnanasayfa.Location = new System.Drawing.Point(125, 530);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(122, 41);
            this.btnanasayfa.TabIndex = 50;
            this.btnanasayfa.Text = "ANASAYFA";
            this.btnanasayfa.UseVisualStyleBackColor = false;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // CalisanSeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnanasayfa);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.seansdatagrid);
            this.Name = "CalisanSeans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalisanSeans";
            this.Load += new System.EventHandler(this.CalisanSeans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seansdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.DataGridView seansdatagrid;
        private System.Windows.Forms.Button btnanasayfa;
    }
}