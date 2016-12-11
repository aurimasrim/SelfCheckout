namespace WindowsFormsApplication3
{
    partial class ClientForm
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
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picture500Euros = new System.Windows.Forms.PictureBox();
            this.picture200Euros = new System.Windows.Forms.PictureBox();
            this.picture100Euros = new System.Windows.Forms.PictureBox();
            this.picture50Euros = new System.Windows.Forms.PictureBox();
            this.picture20Euros = new System.Windows.Forms.PictureBox();
            this.picture10Euros = new System.Windows.Forms.PictureBox();
            this.picture5Euros = new System.Windows.Forms.PictureBox();
            this.picture1Cent = new System.Windows.Forms.PictureBox();
            this.picture2Cents = new System.Windows.Forms.PictureBox();
            this.picture20Cents = new System.Windows.Forms.PictureBox();
            this.picture2Euros = new System.Windows.Forms.PictureBox();
            this.picture5Cents = new System.Windows.Forms.PictureBox();
            this.picture50Cents = new System.Windows.Forms.PictureBox();
            this.picture10Cents = new System.Windows.Forms.PictureBox();
            this.picture1Euro = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInsert = new EnhancedGlassButton.GlassButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prekeDataSet = new WindowsFormsApplication3.PrekeDataSet();
            this.prekeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prekeTableAdapter = new WindowsFormsApplication3.PrekeDataSetTableAdapters.PrekeTableAdapter();
            this.barkodasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kainaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svorisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atributaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.putProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture500Euros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture200Euros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture100Euros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture50Euros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture20Euros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture10Euros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5Euros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1Cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2Cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture20Cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2Euros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5Cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture50Cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture10Cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1Euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.barkodasDataGridViewTextBoxColumn,
            this.pavadinimasDataGridViewTextBoxColumn,
            this.kainaDataGridViewTextBoxColumn,
            this.svorisDataGridViewTextBoxColumn,
            this.kategorijaDataGridViewTextBoxColumn,
            this.atributaiDataGridViewTextBoxColumn,
            this.scanProduct,
            this.putProduct});
            this.gridProducts.DataSource = this.prekeBindingSource;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.GridColor = System.Drawing.Color.DarkCyan;
            this.gridProducts.Location = new System.Drawing.Point(12, 68);
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
            this.gridProducts.TabIndex = 1;
            this.gridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellContentClick);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxCardNumber.Location = new System.Drawing.Point(12, 306);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(207, 20);
            this.textBoxCardNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kreditinės kortelės nr:";
            // 
            // picture500Euros
            // 
            this.picture500Euros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture500Euros.Image = global::WindowsFormsApplication3.Properties.Resources._500euro_fr_ES1_Specimen_RGB_72dpi;
            this.picture500Euros.Location = new System.Drawing.Point(610, 430);
            this.picture500Euros.Name = "picture500Euros";
            this.picture500Euros.Size = new System.Drawing.Size(92, 49);
            this.picture500Euros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture500Euros.TabIndex = 19;
            this.picture500Euros.TabStop = false;
            this.picture500Euros.Click += new System.EventHandler(this.picture500Euros_Click);
            // 
            // picture200Euros
            // 
            this.picture200Euros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture200Euros.Image = global::WindowsFormsApplication3.Properties.Resources._200euro_fr_ES1_Specimen_RGB_72dpi;
            this.picture200Euros.Location = new System.Drawing.Point(512, 430);
            this.picture200Euros.Name = "picture200Euros";
            this.picture200Euros.Size = new System.Drawing.Size(92, 49);
            this.picture200Euros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture200Euros.TabIndex = 18;
            this.picture200Euros.TabStop = false;
            this.picture200Euros.Click += new System.EventHandler(this.picture200Euros_Click);
            // 
            // picture100Euros
            // 
            this.picture100Euros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture100Euros.Image = global::WindowsFormsApplication3.Properties.Resources._100euro_fr_ES1_Specimen_RGB_72dpi;
            this.picture100Euros.Location = new System.Drawing.Point(414, 430);
            this.picture100Euros.Name = "picture100Euros";
            this.picture100Euros.Size = new System.Drawing.Size(92, 49);
            this.picture100Euros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture100Euros.TabIndex = 17;
            this.picture100Euros.TabStop = false;
            this.picture100Euros.Click += new System.EventHandler(this.picture100Euros_Click);
            // 
            // picture50Euros
            // 
            this.picture50Euros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture50Euros.Image = global::WindowsFormsApplication3.Properties.Resources._50euro_fr_ES1_Specimen_RGB_72dpi;
            this.picture50Euros.Location = new System.Drawing.Point(316, 430);
            this.picture50Euros.Name = "picture50Euros";
            this.picture50Euros.Size = new System.Drawing.Size(92, 49);
            this.picture50Euros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture50Euros.TabIndex = 16;
            this.picture50Euros.TabStop = false;
            this.picture50Euros.Click += new System.EventHandler(this.picture50Euros_Click);
            // 
            // picture20Euros
            // 
            this.picture20Euros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture20Euros.Image = global::WindowsFormsApplication3.Properties.Resources._20euro_fr_ES1_Specimen_RGB_72dpi;
            this.picture20Euros.Location = new System.Drawing.Point(218, 430);
            this.picture20Euros.Name = "picture20Euros";
            this.picture20Euros.Size = new System.Drawing.Size(92, 49);
            this.picture20Euros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture20Euros.TabIndex = 15;
            this.picture20Euros.TabStop = false;
            this.picture20Euros.Click += new System.EventHandler(this.picture20Euros_Click);
            // 
            // picture10Euros
            // 
            this.picture10Euros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture10Euros.Image = global::WindowsFormsApplication3.Properties.Resources._10euro_fr_ES1_Specimen_RGB_72dpi;
            this.picture10Euros.Location = new System.Drawing.Point(120, 430);
            this.picture10Euros.Name = "picture10Euros";
            this.picture10Euros.Size = new System.Drawing.Size(92, 49);
            this.picture10Euros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture10Euros.TabIndex = 14;
            this.picture10Euros.TabStop = false;
            this.picture10Euros.Click += new System.EventHandler(this.picture10Euros_Click);
            // 
            // picture5Euros
            // 
            this.picture5Euros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture5Euros.Image = global::WindowsFormsApplication3.Properties.Resources._5euro_fr_ES1_Specimen_RGB_72dpi;
            this.picture5Euros.Location = new System.Drawing.Point(22, 430);
            this.picture5Euros.Name = "picture5Euros";
            this.picture5Euros.Size = new System.Drawing.Size(92, 49);
            this.picture5Euros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture5Euros.TabIndex = 13;
            this.picture5Euros.TabStop = false;
            this.picture5Euros.Click += new System.EventHandler(this.picture5Euros_Click);
            // 
            // picture1Cent
            // 
            this.picture1Cent.BackColor = System.Drawing.Color.Transparent;
            this.picture1Cent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture1Cent.Image = global::WindowsFormsApplication3.Properties.Resources._1_cent;
            this.picture1Cent.Location = new System.Drawing.Point(20, 343);
            this.picture1Cent.Name = "picture1Cent";
            this.picture1Cent.Size = new System.Drawing.Size(80, 81);
            this.picture1Cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1Cent.TabIndex = 12;
            this.picture1Cent.TabStop = false;
            this.picture1Cent.Click += new System.EventHandler(this.picture1Cent_Click);
            // 
            // picture2Cents
            // 
            this.picture2Cents.BackColor = System.Drawing.Color.Transparent;
            this.picture2Cents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture2Cents.Image = global::WindowsFormsApplication3.Properties.Resources._2_cents;
            this.picture2Cents.Location = new System.Drawing.Point(106, 343);
            this.picture2Cents.Name = "picture2Cents";
            this.picture2Cents.Size = new System.Drawing.Size(80, 81);
            this.picture2Cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2Cents.TabIndex = 11;
            this.picture2Cents.TabStop = false;
            this.picture2Cents.Click += new System.EventHandler(this.picture2Cents_Click);
            // 
            // picture20Cents
            // 
            this.picture20Cents.BackColor = System.Drawing.Color.Transparent;
            this.picture20Cents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture20Cents.Image = global::WindowsFormsApplication3.Properties.Resources.Euro_20_Cent;
            this.picture20Cents.Location = new System.Drawing.Point(364, 343);
            this.picture20Cents.Name = "picture20Cents";
            this.picture20Cents.Size = new System.Drawing.Size(80, 81);
            this.picture20Cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture20Cents.TabIndex = 10;
            this.picture20Cents.TabStop = false;
            this.picture20Cents.Click += new System.EventHandler(this.picture20Cents_Click);
            // 
            // picture2Euros
            // 
            this.picture2Euros.BackColor = System.Drawing.Color.Transparent;
            this.picture2Euros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture2Euros.Image = global::WindowsFormsApplication3.Properties.Resources.Euro_2;
            this.picture2Euros.Location = new System.Drawing.Point(622, 343);
            this.picture2Euros.Name = "picture2Euros";
            this.picture2Euros.Size = new System.Drawing.Size(80, 81);
            this.picture2Euros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2Euros.TabIndex = 9;
            this.picture2Euros.TabStop = false;
            this.picture2Euros.Click += new System.EventHandler(this.picture2Euros_Click);
            // 
            // picture5Cents
            // 
            this.picture5Cents.BackColor = System.Drawing.Color.Transparent;
            this.picture5Cents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture5Cents.Image = global::WindowsFormsApplication3.Properties.Resources._5_cents;
            this.picture5Cents.Location = new System.Drawing.Point(192, 343);
            this.picture5Cents.Name = "picture5Cents";
            this.picture5Cents.Size = new System.Drawing.Size(80, 81);
            this.picture5Cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture5Cents.TabIndex = 8;
            this.picture5Cents.TabStop = false;
            this.picture5Cents.Click += new System.EventHandler(this.picture5Cents_Click);
            // 
            // picture50Cents
            // 
            this.picture50Cents.BackColor = System.Drawing.Color.Transparent;
            this.picture50Cents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture50Cents.Image = global::WindowsFormsApplication3.Properties.Resources.Euro_50_Cent;
            this.picture50Cents.Location = new System.Drawing.Point(450, 343);
            this.picture50Cents.Name = "picture50Cents";
            this.picture50Cents.Size = new System.Drawing.Size(80, 81);
            this.picture50Cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture50Cents.TabIndex = 7;
            this.picture50Cents.TabStop = false;
            this.picture50Cents.Click += new System.EventHandler(this.picture50Cents_Click);
            // 
            // picture10Cents
            // 
            this.picture10Cents.BackColor = System.Drawing.Color.Transparent;
            this.picture10Cents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture10Cents.Image = global::WindowsFormsApplication3.Properties.Resources.Euro_10_Cent;
            this.picture10Cents.Location = new System.Drawing.Point(278, 343);
            this.picture10Cents.Name = "picture10Cents";
            this.picture10Cents.Size = new System.Drawing.Size(80, 81);
            this.picture10Cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture10Cents.TabIndex = 6;
            this.picture10Cents.TabStop = false;
            this.picture10Cents.Click += new System.EventHandler(this.picture10Cents_Click);
            // 
            // picture1Euro
            // 
            this.picture1Euro.BackColor = System.Drawing.Color.Transparent;
            this.picture1Euro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture1Euro.Image = global::WindowsFormsApplication3.Properties.Resources.Euro_1;
            this.picture1Euro.Location = new System.Drawing.Point(536, 343);
            this.picture1Euro.Name = "picture1Euro";
            this.picture1Euro.Size = new System.Drawing.Size(80, 81);
            this.picture1Euro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1Euro.TabIndex = 5;
            this.picture1Euro.TabStop = false;
            this.picture1Euro.Click += new System.EventHandler(this.picture1Euro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Klientas";
            // 
            // buttonInsert
            // 
            this.buttonInsert.AnimateGlow = true;
            this.buttonInsert.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonInsert.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonInsert.Location = new System.Drawing.Point(225, 298);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(109, 35);
            this.buttonInsert.TabIndex = 28;
            this.buttonInsert.Text = "Įdėti kortelę";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsertCard_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApplication3.Product);
            // 
            // prekeDataSet
            // 
            this.prekeDataSet.DataSetName = "PrekeDataSet";
            this.prekeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prekeBindingSource
            // 
            this.prekeBindingSource.DataMember = "Preke";
            this.prekeBindingSource.DataSource = this.prekeDataSet;
            // 
            // prekeTableAdapter
            // 
            this.prekeTableAdapter.ClearBeforeFill = true;
            // 
            // barkodasDataGridViewTextBoxColumn
            // 
            this.barkodasDataGridViewTextBoxColumn.DataPropertyName = "Barkodas";
            this.barkodasDataGridViewTextBoxColumn.HeaderText = "Barkodas";
            this.barkodasDataGridViewTextBoxColumn.Name = "barkodasDataGridViewTextBoxColumn";
            this.barkodasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pavadinimasDataGridViewTextBoxColumn
            // 
            this.pavadinimasDataGridViewTextBoxColumn.DataPropertyName = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.Name = "pavadinimasDataGridViewTextBoxColumn";
            this.pavadinimasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kainaDataGridViewTextBoxColumn
            // 
            this.kainaDataGridViewTextBoxColumn.DataPropertyName = "Kaina";
            this.kainaDataGridViewTextBoxColumn.HeaderText = "Kaina";
            this.kainaDataGridViewTextBoxColumn.Name = "kainaDataGridViewTextBoxColumn";
            this.kainaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svorisDataGridViewTextBoxColumn
            // 
            this.svorisDataGridViewTextBoxColumn.DataPropertyName = "Svoris";
            this.svorisDataGridViewTextBoxColumn.HeaderText = "Svoris";
            this.svorisDataGridViewTextBoxColumn.Name = "svorisDataGridViewTextBoxColumn";
            this.svorisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategorijaDataGridViewTextBoxColumn
            // 
            this.kategorijaDataGridViewTextBoxColumn.DataPropertyName = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.HeaderText = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.Name = "kategorijaDataGridViewTextBoxColumn";
            this.kategorijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atributaiDataGridViewTextBoxColumn
            // 
            this.atributaiDataGridViewTextBoxColumn.DataPropertyName = "Atributai";
            this.atributaiDataGridViewTextBoxColumn.HeaderText = "Atributai";
            this.atributaiDataGridViewTextBoxColumn.Name = "atributaiDataGridViewTextBoxColumn";
            this.atributaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scanProduct
            // 
            this.scanProduct.HeaderText = "Skenuoti";
            this.scanProduct.Name = "scanProduct";
            this.scanProduct.ReadOnly = true;
            this.scanProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.scanProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.scanProduct.Text = "Skenuoti";
            this.scanProduct.UseColumnTextForButtonValue = true;
            this.scanProduct.Width = 60;
            // 
            // putProduct
            // 
            this.putProduct.HeaderText = "Padėti";
            this.putProduct.Name = "putProduct";
            this.putProduct.ReadOnly = true;
            this.putProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.putProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.putProduct.Text = "Padėti";
            this.putProduct.UseColumnTextForButtonValue = true;
            this.putProduct.Width = 60;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 493);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picture500Euros);
            this.Controls.Add(this.picture200Euros);
            this.Controls.Add(this.picture100Euros);
            this.Controls.Add(this.picture50Euros);
            this.Controls.Add(this.picture20Euros);
            this.Controls.Add(this.picture10Euros);
            this.Controls.Add(this.picture5Euros);
            this.Controls.Add(this.picture1Cent);
            this.Controls.Add(this.picture2Cents);
            this.Controls.Add(this.picture20Cents);
            this.Controls.Add(this.picture2Euros);
            this.Controls.Add(this.picture5Cents);
            this.Controls.Add(this.picture50Cents);
            this.Controls.Add(this.picture10Cents);
            this.Controls.Add(this.picture1Euro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.gridProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 450);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Klientas";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture500Euros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture200Euros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture100Euros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture50Euros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture20Euros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture10Euros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5Euros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1Cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2Cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture20Cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2Euros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5Cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture50Cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture10Cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1Euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture1Euro;
        private System.Windows.Forms.PictureBox picture10Cents;
        private System.Windows.Forms.PictureBox picture50Cents;
        private System.Windows.Forms.PictureBox picture5Cents;
        private System.Windows.Forms.PictureBox picture2Euros;
        private System.Windows.Forms.PictureBox picture20Cents;
        private System.Windows.Forms.PictureBox picture2Cents;
        private System.Windows.Forms.PictureBox picture1Cent;
        private System.Windows.Forms.PictureBox picture5Euros;
        private System.Windows.Forms.PictureBox picture10Euros;
        private System.Windows.Forms.PictureBox picture20Euros;
        private System.Windows.Forms.PictureBox picture50Euros;
        private System.Windows.Forms.PictureBox picture100Euros;
        private System.Windows.Forms.PictureBox picture200Euros;
        private System.Windows.Forms.PictureBox picture500Euros;
        public System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label2;
        private EnhancedGlassButton.GlassButton buttonInsert;
        public System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Timer timer1;
        private PrekeDataSet prekeDataSet;
        private System.Windows.Forms.BindingSource prekeBindingSource;
        private PrekeDataSetTableAdapters.PrekeTableAdapter prekeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kainaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svorisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atributaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn scanProduct;
        private System.Windows.Forms.DataGridViewButtonColumn putProduct;
    }
}