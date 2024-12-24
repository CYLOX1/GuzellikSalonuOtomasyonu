namespace GüzellikmerkeziOtomasyon
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
            this.seanslardatagrid = new System.Windows.Forms.DataGridView();
            this.btngeri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seanslardatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // seanslardatagrid
            // 
            this.seanslardatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seanslardatagrid.Location = new System.Drawing.Point(38, 72);
            this.seanslardatagrid.Name = "seanslardatagrid";
            this.seanslardatagrid.RowHeadersWidth = 51;
            this.seanslardatagrid.RowTemplate.Height = 24;
            this.seanslardatagrid.Size = new System.Drawing.Size(992, 431);
            this.seanslardatagrid.TabIndex = 0;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.HotPink;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btngeri.Location = new System.Drawing.Point(12, 530);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(122, 41);
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
            this.label2.Location = new System.Drawing.Point(448, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 40);
            this.label2.TabIndex = 52;
            this.label2.Text = "SEANSLAR";
            // 
            // CalisanSeansGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.seanslardatagrid);
            this.Name = "CalisanSeansGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeansGoruntule";
            ((System.ComponentModel.ISupportInitialize)(this.seanslardatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView seanslardatagrid;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label label2;
    }
}