namespace Freelancer.FormsUI
{
    partial class Form1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategroyId = new System.Windows.Forms.Label();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.btnFiltreSifirla = new System.Windows.Forms.Button();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxProductAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.BackColor = System.Drawing.Color.White;
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(14, 21);
            this.gbxCategory.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxCategory.Size = new System.Drawing.Size(267, 121);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.BackColor = System.Drawing.Color.Thistle;
            this.cbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(72, 48);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(169, 25);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(8, 51);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(133, 31);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.BackColor = System.Drawing.Color.White;
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(453, 21);
            this.gbxProductName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxProductName.Size = new System.Drawing.Size(259, 121);
            this.gbxProductName.TabIndex = 0;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(72, 48);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(165, 25);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(8, 51);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(79, 31);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // dgwProduct
            // 
            this.dgwProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(14, 148);
            this.dgwProduct.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersVisible = false;
            this.dgwProduct.Size = new System.Drawing.Size(698, 212);
            this.dgwProduct.TabIndex = 1;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnRemove);
            this.gbxProductAdd.Controls.Add(this.btnUpdate);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStock);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxProductName2);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblCategroyId);
            this.gbxProductAdd.Controls.Add(this.lblProductName2);
            this.gbxProductAdd.Location = new System.Drawing.Point(14, 382);
            this.gbxProductAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbxProductAdd.Size = new System.Drawing.Size(698, 213);
            this.gbxProductAdd.TabIndex = 2;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Envanter İşlemleri";
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(540, 150);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 31);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Ürün Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(540, 93);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 31);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Ürün Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(540, 36);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(165, 61);
            this.cbxCategoryId.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(315, 25);
            this.cbxCategoryId.TabIndex = 2;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(165, 153);
            this.tbxQuantityPerUnit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(315, 25);
            this.tbxQuantityPerUnit.TabIndex = 1;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(165, 122);
            this.tbxStock.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(315, 25);
            this.tbxStock.TabIndex = 1;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(165, 93);
            this.tbxUnitPrice.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(315, 25);
            this.tbxUnitPrice.TabIndex = 1;
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(165, 33);
            this.tbxProductName2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(315, 25);
            this.tbxProductName2.TabIndex = 1;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(23, 156);
            this.lblQuantityPerUnit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(133, 31);
            this.lblQuantityPerUnit.TabIndex = 0;
            this.lblQuantityPerUnit.Text = "Birim Adet";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(23, 127);
            this.lblStock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(133, 31);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stok Adedi";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Location = new System.Drawing.Point(23, 95);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(133, 31);
            this.lblUnitPrice.TabIndex = 0;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblCategroyId
            // 
            this.lblCategroyId.Location = new System.Drawing.Point(23, 67);
            this.lblCategroyId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategroyId.Name = "lblCategroyId";
            this.lblCategroyId.Size = new System.Drawing.Size(133, 31);
            this.lblCategroyId.TabIndex = 0;
            this.lblCategroyId.Text = "Kategori ID";
            // 
            // lblProductName2
            // 
            this.lblProductName2.Location = new System.Drawing.Point(23, 36);
            this.lblProductName2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(133, 31);
            this.lblProductName2.TabIndex = 0;
            this.lblProductName2.Text = "Ürün Adı";
            // 
            // btnFiltreSifirla
            // 
            this.btnFiltreSifirla.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnFiltreSifirla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnFiltreSifirla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFiltreSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreSifirla.Location = new System.Drawing.Point(303, 55);
            this.btnFiltreSifirla.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnFiltreSifirla.Name = "btnFiltreSifirla";
            this.btnFiltreSifirla.Size = new System.Drawing.Size(129, 50);
            this.btnFiltreSifirla.TabIndex = 3;
            this.btnFiltreSifirla.Text = "Filtreleri Sıfırla";
            this.btnFiltreSifirla.UseVisualStyleBackColor = true;
            this.btnFiltreSifirla.Click += new System.EventHandler(this.btnFiltreSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 611);
            this.Controls.Add(this.btnFiltreSifirla);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envanter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnFiltreSifirla;

        private System.Windows.Forms.Button btnRemove;

        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.Label lblCategroyId;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.DataGridView dgwProduct;

        #endregion
    }
}