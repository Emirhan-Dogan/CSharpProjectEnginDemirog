namespace Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxKategoriAra = new System.Windows.Forms.GroupBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.dgwUrünler = new System.Windows.Forms.DataGridView();
            this.tbxIsimAra = new System.Windows.Forms.TextBox();
            this.lblIsimAra = new System.Windows.Forms.Label();
            this.gbxIsim = new System.Windows.Forms.GroupBox();
            this.gbxKategoriAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrünler)).BeginInit();
            this.gbxIsim.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKategoriAra
            // 
            this.gbxKategoriAra.Controls.Add(this.lblKategori);
            this.gbxKategoriAra.Controls.Add(this.cbxKategori);
            this.gbxKategoriAra.Location = new System.Drawing.Point(12, 12);
            this.gbxKategoriAra.Name = "gbxKategoriAra";
            this.gbxKategoriAra.Size = new System.Drawing.Size(329, 77);
            this.gbxKategoriAra.TabIndex = 0;
            this.gbxKategoriAra.TabStop = false;
            this.gbxKategoriAra.Text = "Kategori";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(6, 25);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(60, 15);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori : ";
            // 
            // cbxKategori
            // 
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(86, 22);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(183, 23);
            this.cbxKategori.TabIndex = 0;
            this.cbxKategori.SelectedIndexChanged += new System.EventHandler(this.cbxKategori_SelectedIndexChanged);
            // 
            // dgwUrünler
            // 
            this.dgwUrünler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwUrünler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrünler.Location = new System.Drawing.Point(12, 95);
            this.dgwUrünler.Name = "dgwUrünler";
            this.dgwUrünler.RowTemplate.Height = 25;
            this.dgwUrünler.Size = new System.Drawing.Size(776, 343);
            this.dgwUrünler.TabIndex = 1;
            // 
            // tbxIsimAra
            // 
            this.tbxIsimAra.Location = new System.Drawing.Point(143, 30);
            this.tbxIsimAra.Name = "tbxIsimAra";
            this.tbxIsimAra.Size = new System.Drawing.Size(169, 23);
            this.tbxIsimAra.TabIndex = 2;
            this.tbxIsimAra.TextChanged += new System.EventHandler(this.tbxIsimAra_TextChanged);
            // 
            // lblIsimAra
            // 
            this.lblIsimAra.AutoSize = true;
            this.lblIsimAra.Location = new System.Drawing.Point(11, 33);
            this.lblIsimAra.Name = "lblIsimAra";
            this.lblIsimAra.Size = new System.Drawing.Size(126, 15);
            this.lblIsimAra.TabIndex = 1;
            this.lblIsimAra.Text = "Ürün ismine göre ara : ";
            // 
            // gbxIsim
            // 
            this.gbxIsim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxIsim.Controls.Add(this.lblIsimAra);
            this.gbxIsim.Controls.Add(this.tbxIsimAra);
            this.gbxIsim.Location = new System.Drawing.Point(459, 12);
            this.gbxIsim.Name = "gbxIsim";
            this.gbxIsim.Size = new System.Drawing.Size(329, 77);
            this.gbxIsim.TabIndex = 0;
            this.gbxIsim.TabStop = false;
            this.gbxIsim.Text = "İsim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwUrünler);
            this.Controls.Add(this.gbxIsim);
            this.Controls.Add(this.gbxKategoriAra);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Ürün Listele";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxKategoriAra.ResumeLayout(false);
            this.gbxKategoriAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrünler)).EndInit();
            this.gbxIsim.ResumeLayout(false);
            this.gbxIsim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxKategoriAra;
        private Label lblKategori;
        private ComboBox cbxKategori;
        private DataGridView dgwUrünler;
        private TextBox tbxIsimAra;
        private Label lblIsimAra;
        private GroupBox gbxIsim;
    }
}