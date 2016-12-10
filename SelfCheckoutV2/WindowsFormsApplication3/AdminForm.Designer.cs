﻿namespace WindowsFormsApplication3
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new EnhancedGlassButton.GlassButton();
            this.buttonReadInternet = new EnhancedGlassButton.GlassButton();
            this.buttonReadFile = new EnhancedGlassButton.GlassButton();
            this.buttonApprove = new EnhancedGlassButton.GlassButton();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattributesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDiscount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSort = new EnhancedGlassButton.GlassButton();
            this.comboCategories = new System.Windows.Forms.ComboBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDiscount = new EnhancedGlassButton.GlassButton();
            this.buttonScanWithCamera = new EnhancedGlassButton.GlassButton();
            this.buttonAddProduct = new EnhancedGlassButton.GlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Valdytojas";
            // 
            // buttonClose
            // 
            this.buttonClose.AnimateGlow = true;
            this.buttonClose.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonClose.CausesValidation = false;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonClose.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Location = new System.Drawing.Point(625, 63);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(89, 46);
            this.buttonClose.TabIndex = 26;
            this.buttonClose.Text = "Išjungti programą";
            // 
            // buttonReadInternet
            // 
            this.buttonReadInternet.AnimateGlow = true;
            this.buttonReadInternet.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonReadInternet.CausesValidation = false;
            this.buttonReadInternet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReadInternet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonReadInternet.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonReadInternet.Location = new System.Drawing.Point(196, 63);
            this.buttonReadInternet.Name = "buttonReadInternet";
            this.buttonReadInternet.Size = new System.Drawing.Size(168, 46);
            this.buttonReadInternet.TabIndex = 28;
            this.buttonReadInternet.Text = "Skaityti produktų\r\nduomenis iš interneto";
            this.buttonReadInternet.Click += new System.EventHandler(this.buttonReadInternet_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.AnimateGlow = true;
            this.buttonReadFile.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonReadFile.CausesValidation = false;
            this.buttonReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReadFile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonReadFile.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonReadFile.Location = new System.Drawing.Point(12, 63);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(143, 46);
            this.buttonReadFile.TabIndex = 29;
            this.buttonReadFile.Text = "Skaityti produktų \r\nduomenis iš failo";
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonApprove
            // 
            this.buttonApprove.AnimateGlow = true;
            this.buttonApprove.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonApprove.CausesValidation = false;
            this.buttonApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApprove.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonApprove.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonApprove.Location = new System.Drawing.Point(421, 63);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(116, 46);
            this.buttonApprove.TabIndex = 30;
            this.buttonApprove.Text = "Patvirtinti pirkėjo amžių";
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeColumns = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.AutoGenerateColumns = false;
            this.gridProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProducts.CausesValidation = false;
            this.gridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.pattributesDataGridViewTextBoxColumn,
            this.makeDiscount,
            this.removeProduct});
            this.gridProducts.DataSource = this.productBindingSource;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.GridColor = System.Drawing.Color.DarkCyan;
            this.gridProducts.Location = new System.Drawing.Point(24, 124);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridProducts.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.gridProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProducts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gridProducts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(690, 205);
            this.gridProducts.TabIndex = 31;
            this.gridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellContentClick);
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "Pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Kaina";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 40;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Svoris";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 45;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barkodas";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Width = 105;
            // 
            // pattributesDataGridViewTextBoxColumn
            // 
            this.pattributesDataGridViewTextBoxColumn.DataPropertyName = "Pattributes";
            this.pattributesDataGridViewTextBoxColumn.HeaderText = "Atributai";
            this.pattributesDataGridViewTextBoxColumn.Name = "pattributesDataGridViewTextBoxColumn";
            this.pattributesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makeDiscount
            // 
            this.makeDiscount.HeaderText = "Padaryti nuolaidą";
            this.makeDiscount.Name = "makeDiscount";
            this.makeDiscount.ReadOnly = true;
            this.makeDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.makeDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.makeDiscount.Text = "Nuolaida";
            this.makeDiscount.UseColumnTextForButtonValue = true;
            this.makeDiscount.Width = 60;
            // 
            // removeProduct
            // 
            this.removeProduct.HeaderText = "Pašalinti";
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.ReadOnly = true;
            this.removeProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.removeProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.removeProduct.Text = "Pašalinti";
            this.removeProduct.UseColumnTextForButtonValue = true;
            this.removeProduct.Width = 60;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApplication3.Product);
            // 
            // buttonSort
            // 
            this.buttonSort.AnimateGlow = true;
            this.buttonSort.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSort.CausesValidation = false;
            this.buttonSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSort.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonSort.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonSort.Location = new System.Drawing.Point(625, 335);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(89, 35);
            this.buttonSort.TabIndex = 32;
            this.buttonSort.Text = "Surūšiuoti";
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboCategories
            // 
            this.comboCategories.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboCategories.CausesValidation = false;
            this.comboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategories.FormattingEnabled = true;
            this.comboCategories.Items.AddRange(new object[] {
            "Alkoholiniai gėrimai",
            "Nealkoholiniai gėrimai",
            "Vaisiai",
            "Daržovės",
            "Pieno produktai"});
            this.comboCategories.Location = new System.Drawing.Point(64, 366);
            this.comboCategories.Name = "comboCategories";
            this.comboCategories.Size = new System.Drawing.Size(131, 21);
            this.comboCategories.TabIndex = 33;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDiscount.Location = new System.Drawing.Point(214, 367);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(31, 20);
            this.textBoxDiscount.TabIndex = 34;
            this.textBoxDiscount.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDiscount_Validating);
            this.textBoxDiscount.Validated += new System.EventHandler(this.textBoxDiscount_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(75, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(193, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nuolaida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(245, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "%";
            // 
            // buttonDiscount
            // 
            this.buttonDiscount.AnimateGlow = true;
            this.buttonDiscount.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiscount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonDiscount.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonDiscount.Location = new System.Drawing.Point(274, 359);
            this.buttonDiscount.Name = "buttonDiscount";
            this.buttonDiscount.Size = new System.Drawing.Size(90, 35);
            this.buttonDiscount.TabIndex = 38;
            this.buttonDiscount.Text = "Pritaikyti nuolaidą";
            this.buttonDiscount.Click += new System.EventHandler(this.buttonDiscount_Click);
            // 
            // buttonScanWithCamera
            // 
            this.buttonScanWithCamera.AnimateGlow = true;
            this.buttonScanWithCamera.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonScanWithCamera.CausesValidation = false;
            this.buttonScanWithCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonScanWithCamera.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonScanWithCamera.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonScanWithCamera.Location = new System.Drawing.Point(530, 335);
            this.buttonScanWithCamera.Name = "buttonScanWithCamera";
            this.buttonScanWithCamera.Size = new System.Drawing.Size(89, 35);
            this.buttonScanWithCamera.TabIndex = 39;
            this.buttonScanWithCamera.Text = "Skenuoti su kamera";
            this.buttonScanWithCamera.Click += new System.EventHandler(this.buttonScanWithCamera_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.AnimateGlow = true;
            this.buttonAddProduct.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAddProduct.CausesValidation = false;
            this.buttonAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddProduct.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonAddProduct.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonAddProduct.Location = new System.Drawing.Point(435, 335);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(89, 35);
            this.buttonAddProduct.TabIndex = 40;
            this.buttonAddProduct.Text = "Pridėti prekę";
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 402);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonScanWithCamera);
            this.Controls.Add(this.buttonDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.comboCategories);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonReadInternet);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(0, 63);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private EnhancedGlassButton.GlassButton buttonClose;
        private EnhancedGlassButton.GlassButton buttonReadInternet;
        private EnhancedGlassButton.GlassButton buttonReadFile;
        private EnhancedGlassButton.GlassButton buttonApprove;
        public System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private EnhancedGlassButton.GlassButton buttonSort;
        private System.Windows.Forms.ComboBox comboCategories;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private EnhancedGlassButton.GlassButton buttonDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattributesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn makeDiscount;
        private System.Windows.Forms.DataGridViewButtonColumn removeProduct;
        private EnhancedGlassButton.GlassButton buttonScanWithCamera;
        private EnhancedGlassButton.GlassButton buttonAddProduct;
    }
}