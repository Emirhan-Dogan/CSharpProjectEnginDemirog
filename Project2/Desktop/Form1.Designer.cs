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
            this.dgwUrünler = new System.Windows.Forms.DataGridView();
            this.gbxIsim = new System.Windows.Forms.GroupBox();
            this.lblIsimAra = new System.Windows.Forms.Label();
            this.tbxIsimAra = new System.Windows.Forms.TextBox();
            this.gbxKategoriAra = new System.Windows.Forms.GroupBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.btnReflesh = new System.Windows.Forms.Button();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.cbxAddedCategory = new System.Windows.Forms.ComboBox();
            this.tbxAddedUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddedUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxAddedQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxAddedProductName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddedQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblAddedUnitsInStock = new System.Windows.Forms.Label();
            this.lblAddedUnitPrice = new System.Windows.Forms.Label();
            this.lblAddedCategoryId = new System.Windows.Forms.Label();
            this.lblAddedProductName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.cbxUpdatedCategory = new System.Windows.Forms.ComboBox();
            this.tbxUpdatedUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdatedUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxUpdatedQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdatedProductName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdatedQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUpdatedUnitsInStock = new System.Windows.Forms.Label();
            this.lblUpdatedUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdatedCategory = new System.Windows.Forms.Label();
            this.lblUpdatedProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrünler)).BeginInit();
            this.gbxIsim.SuspendLayout();
            this.gbxKategoriAra.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUrünler
            // 
            this.dgwUrünler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwUrünler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrünler.Location = new System.Drawing.Point(2, 95);
            this.dgwUrünler.Name = "dgwUrünler";
            this.dgwUrünler.RowTemplate.Height = 25;
            this.dgwUrünler.Size = new System.Drawing.Size(776, 319);
            this.dgwUrünler.TabIndex = 4;
            this.dgwUrünler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrünler_CellClick);
            // 
            // gbxIsim
            // 
            this.gbxIsim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxIsim.Controls.Add(this.lblIsimAra);
            this.gbxIsim.Controls.Add(this.tbxIsimAra);
            this.gbxIsim.Location = new System.Drawing.Point(459, 12);
            this.gbxIsim.Name = "gbxIsim";
            this.gbxIsim.Size = new System.Drawing.Size(329, 77);
            this.gbxIsim.TabIndex = 2;
            this.gbxIsim.TabStop = false;
            this.gbxIsim.Text = "İsim";
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
            // tbxIsimAra
            // 
            this.tbxIsimAra.Location = new System.Drawing.Point(143, 30);
            this.tbxIsimAra.Name = "tbxIsimAra";
            this.tbxIsimAra.Size = new System.Drawing.Size(169, 23);
            this.tbxIsimAra.TabIndex = 2;
            this.tbxIsimAra.TextChanged += new System.EventHandler(this.tbxIsimAra_TextChanged);
            // 
            // gbxKategoriAra
            // 
            this.gbxKategoriAra.Controls.Add(this.lblKategori);
            this.gbxKategoriAra.Controls.Add(this.cbxKategori);
            this.gbxKategoriAra.Location = new System.Drawing.Point(12, 12);
            this.gbxKategoriAra.Name = "gbxKategoriAra";
            this.gbxKategoriAra.Size = new System.Drawing.Size(329, 77);
            this.gbxKategoriAra.TabIndex = 3;
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
            // btnReflesh
            // 
            this.btnReflesh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReflesh.Location = new System.Drawing.Point(362, 12);
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Size = new System.Drawing.Size(75, 23);
            this.btnReflesh.TabIndex = 5;
            this.btnReflesh.Text = "Yenile";
            this.btnReflesh.UseVisualStyleBackColor = true;
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxProductAdd.Controls.Add(this.cbxAddedCategory);
            this.gbxProductAdd.Controls.Add(this.tbxAddedUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxAddedUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.tbxAddedQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxAddedProductName);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.lblAddedQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblAddedUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.lblAddedUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblAddedCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblAddedProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 450);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(339, 176);
            this.gbxProductAdd.TabIndex = 6;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Ürün Ekle";
            // 
            // cbxAddedCategory
            // 
            this.cbxAddedCategory.FormattingEnabled = true;
            this.cbxAddedCategory.Location = new System.Drawing.Point(59, 75);
            this.cbxAddedCategory.Name = "cbxAddedCategory";
            this.cbxAddedCategory.Size = new System.Drawing.Size(117, 23);
            this.cbxAddedCategory.TabIndex = 7;
            // 
            // tbxAddedUnitPrice
            // 
            this.tbxAddedUnitPrice.Location = new System.Drawing.Point(76, 122);
            this.tbxAddedUnitPrice.Name = "tbxAddedUnitPrice";
            this.tbxAddedUnitPrice.Size = new System.Drawing.Size(100, 23);
            this.tbxAddedUnitPrice.TabIndex = 6;
            // 
            // tbxAddedUnitsInStock
            // 
            this.tbxAddedUnitsInStock.Location = new System.Drawing.Point(229, 26);
            this.tbxAddedUnitsInStock.Name = "tbxAddedUnitsInStock";
            this.tbxAddedUnitsInStock.Size = new System.Drawing.Size(100, 23);
            this.tbxAddedUnitsInStock.TabIndex = 6;
            // 
            // tbxAddedQuantityPerUnit
            // 
            this.tbxAddedQuantityPerUnit.Location = new System.Drawing.Point(229, 75);
            this.tbxAddedQuantityPerUnit.Name = "tbxAddedQuantityPerUnit";
            this.tbxAddedQuantityPerUnit.Size = new System.Drawing.Size(100, 23);
            this.tbxAddedQuantityPerUnit.TabIndex = 6;
            // 
            // tbxAddedProductName
            // 
            this.tbxAddedProductName.Location = new System.Drawing.Point(59, 26);
            this.tbxAddedProductName.Name = "tbxAddedProductName";
            this.tbxAddedProductName.Size = new System.Drawing.Size(100, 23);
            this.tbxAddedProductName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddedQuantityPerUnit
            // 
            this.lblAddedQuantityPerUnit.AutoSize = true;
            this.lblAddedQuantityPerUnit.Location = new System.Drawing.Point(187, 78);
            this.lblAddedQuantityPerUnit.Name = "lblAddedQuantityPerUnit";
            this.lblAddedQuantityPerUnit.Size = new System.Drawing.Size(36, 15);
            this.lblAddedQuantityPerUnit.TabIndex = 4;
            this.lblAddedQuantityPerUnit.Text = "Paket";
            // 
            // lblAddedUnitsInStock
            // 
            this.lblAddedUnitsInStock.AutoSize = true;
            this.lblAddedUnitsInStock.Location = new System.Drawing.Point(165, 29);
            this.lblAddedUnitsInStock.Name = "lblAddedUnitsInStock";
            this.lblAddedUnitsInStock.Size = new System.Drawing.Size(64, 15);
            this.lblAddedUnitsInStock.TabIndex = 3;
            this.lblAddedUnitsInStock.Text = "Stok Adedi";
            // 
            // lblAddedUnitPrice
            // 
            this.lblAddedUnitPrice.AutoSize = true;
            this.lblAddedUnitPrice.Location = new System.Drawing.Point(6, 125);
            this.lblAddedUnitPrice.Name = "lblAddedUnitPrice";
            this.lblAddedUnitPrice.Size = new System.Drawing.Size(64, 15);
            this.lblAddedUnitPrice.TabIndex = 2;
            this.lblAddedUnitPrice.Text = "Ürün Fiyatı";
            // 
            // lblAddedCategoryId
            // 
            this.lblAddedCategoryId.AutoSize = true;
            this.lblAddedCategoryId.Location = new System.Drawing.Point(6, 78);
            this.lblAddedCategoryId.Name = "lblAddedCategoryId";
            this.lblAddedCategoryId.Size = new System.Drawing.Size(51, 15);
            this.lblAddedCategoryId.TabIndex = 1;
            this.lblAddedCategoryId.Text = "Kategori";
            // 
            // lblAddedProductName
            // 
            this.lblAddedProductName.AutoSize = true;
            this.lblAddedProductName.Location = new System.Drawing.Point(6, 29);
            this.lblAddedProductName.Name = "lblAddedProductName";
            this.lblAddedProductName.Size = new System.Drawing.Size(54, 15);
            this.lblAddedProductName.TabIndex = 0;
            this.lblAddedProductName.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(713, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProductUpdate.Controls.Add(this.cbxUpdatedCategory);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdatedUnitPrice);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdatedUnitsInStock);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdatedQuantityPerUnit);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdatedProductName);
            this.gbxProductUpdate.Controls.Add(this.btnUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUpdatedQuantityPerUnit);
            this.gbxProductUpdate.Controls.Add(this.lblUpdatedUnitsInStock);
            this.gbxProductUpdate.Controls.Add(this.lblUpdatedUnitPrice);
            this.gbxProductUpdate.Controls.Add(this.lblUpdatedCategory);
            this.gbxProductUpdate.Controls.Add(this.lblUpdatedProductName);
            this.gbxProductUpdate.Location = new System.Drawing.Point(449, 450);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(339, 176);
            this.gbxProductUpdate.TabIndex = 6;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Ürün Güncelle";
            // 
            // cbxUpdatedCategory
            // 
            this.cbxUpdatedCategory.FormattingEnabled = true;
            this.cbxUpdatedCategory.Location = new System.Drawing.Point(59, 75);
            this.cbxUpdatedCategory.Name = "cbxUpdatedCategory";
            this.cbxUpdatedCategory.Size = new System.Drawing.Size(117, 23);
            this.cbxUpdatedCategory.TabIndex = 7;
            // 
            // tbxUpdatedUnitPrice
            // 
            this.tbxUpdatedUnitPrice.Location = new System.Drawing.Point(76, 122);
            this.tbxUpdatedUnitPrice.Name = "tbxUpdatedUnitPrice";
            this.tbxUpdatedUnitPrice.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdatedUnitPrice.TabIndex = 6;
            // 
            // tbxUpdatedUnitsInStock
            // 
            this.tbxUpdatedUnitsInStock.Location = new System.Drawing.Point(229, 26);
            this.tbxUpdatedUnitsInStock.Name = "tbxUpdatedUnitsInStock";
            this.tbxUpdatedUnitsInStock.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdatedUnitsInStock.TabIndex = 6;
            // 
            // tbxUpdatedQuantityPerUnit
            // 
            this.tbxUpdatedQuantityPerUnit.Location = new System.Drawing.Point(229, 75);
            this.tbxUpdatedQuantityPerUnit.Name = "tbxUpdatedQuantityPerUnit";
            this.tbxUpdatedQuantityPerUnit.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdatedQuantityPerUnit.TabIndex = 6;
            // 
            // tbxUpdatedProductName
            // 
            this.tbxUpdatedProductName.Location = new System.Drawing.Point(59, 26);
            this.tbxUpdatedProductName.Name = "tbxUpdatedProductName";
            this.tbxUpdatedProductName.Size = new System.Drawing.Size(100, 23);
            this.tbxUpdatedProductName.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 44);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdatedQuantityPerUnit
            // 
            this.lblUpdatedQuantityPerUnit.AutoSize = true;
            this.lblUpdatedQuantityPerUnit.Location = new System.Drawing.Point(187, 78);
            this.lblUpdatedQuantityPerUnit.Name = "lblUpdatedQuantityPerUnit";
            this.lblUpdatedQuantityPerUnit.Size = new System.Drawing.Size(36, 15);
            this.lblUpdatedQuantityPerUnit.TabIndex = 4;
            this.lblUpdatedQuantityPerUnit.Text = "Paket";
            // 
            // lblUpdatedUnitsInStock
            // 
            this.lblUpdatedUnitsInStock.AutoSize = true;
            this.lblUpdatedUnitsInStock.Location = new System.Drawing.Point(165, 29);
            this.lblUpdatedUnitsInStock.Name = "lblUpdatedUnitsInStock";
            this.lblUpdatedUnitsInStock.Size = new System.Drawing.Size(64, 15);
            this.lblUpdatedUnitsInStock.TabIndex = 3;
            this.lblUpdatedUnitsInStock.Text = "Stok Adedi";
            // 
            // lblUpdatedUnitPrice
            // 
            this.lblUpdatedUnitPrice.AutoSize = true;
            this.lblUpdatedUnitPrice.Location = new System.Drawing.Point(6, 125);
            this.lblUpdatedUnitPrice.Name = "lblUpdatedUnitPrice";
            this.lblUpdatedUnitPrice.Size = new System.Drawing.Size(64, 15);
            this.lblUpdatedUnitPrice.TabIndex = 2;
            this.lblUpdatedUnitPrice.Text = "Ürün Fiyatı";
            // 
            // lblUpdatedCategory
            // 
            this.lblUpdatedCategory.AutoSize = true;
            this.lblUpdatedCategory.Location = new System.Drawing.Point(6, 78);
            this.lblUpdatedCategory.Name = "lblUpdatedCategory";
            this.lblUpdatedCategory.Size = new System.Drawing.Size(51, 15);
            this.lblUpdatedCategory.TabIndex = 1;
            this.lblUpdatedCategory.Text = "Kategori";
            // 
            // lblUpdatedProductName
            // 
            this.lblUpdatedProductName.AutoSize = true;
            this.lblUpdatedProductName.Location = new System.Drawing.Point(6, 29);
            this.lblUpdatedProductName.Name = "lblUpdatedProductName";
            this.lblUpdatedProductName.Size = new System.Drawing.Size(54, 15);
            this.lblUpdatedProductName.TabIndex = 0;
            this.lblUpdatedProductName.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.btnReflesh);
            this.Controls.Add(this.dgwUrünler);
            this.Controls.Add(this.gbxIsim);
            this.Controls.Add(this.gbxKategoriAra);
            this.MinimumSize = new System.Drawing.Size(816, 677);
            this.Name = "Form1";
            this.Text = "Ürün Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrünler)).EndInit();
            this.gbxIsim.ResumeLayout(false);
            this.gbxIsim.PerformLayout();
            this.gbxKategoriAra.ResumeLayout(false);
            this.gbxKategoriAra.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwUrünler;
        private GroupBox gbxIsim;
        private Label lblIsimAra;
        private TextBox tbxIsimAra;
        private GroupBox gbxKategoriAra;
        private Label lblKategori;
        private ComboBox cbxKategori;
        private Button btnReflesh;
        private GroupBox gbxProductAdd;
        private TextBox tbxAddedUnitPrice;
        private TextBox tbxAddedUnitsInStock;
        private TextBox tbxAddedQuantityPerUnit;
        private TextBox tbxAddedProductName;
        private Button btnAdd;
        private Label lblAddedQuantityPerUnit;
        private Label lblAddedUnitsInStock;
        private Label lblAddedUnitPrice;
        private Label lblAddedCategoryId;
        private Label lblAddedProductName;
        private Button btnDelete;
        private ComboBox cbxAddedCategory;
        private GroupBox gbxProductUpdate;
        private ComboBox cbxUpdatedCategory;
        private TextBox tbxUpdatedUnitPrice;
        private TextBox tbxUpdatedUnitsInStock;
        private TextBox tbxUpdatedQuantityPerUnit;
        private TextBox tbxUpdatedProductName;
        private Button btnUpdate;
        private Label lblUpdatedQuantityPerUnit;
        private Label lblUpdatedUnitsInStock;
        private Label lblUpdatedUnitPrice;
        private Label lblUpdatedCategory;
        private Label lblUpdatedProductName;
    }
}