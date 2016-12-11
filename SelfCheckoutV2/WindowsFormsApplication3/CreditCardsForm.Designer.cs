namespace WindowsFormsApplication3
{
    partial class CreditCardsForm
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
            this.buttonAdd = new EnhancedGlassButton.GlassButton();
            this.buttonCancel = new EnhancedGlassButton.GlassButton();
            this.gridCards = new System.Windows.Forms.DataGridView();
            this.mokejimokorteleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDBDataSet = new WindowsFormsApplication3.ShopDBDataSet();
            this.mokejimo_korteleTableAdapter = new WindowsFormsApplication3.ShopDBDataSetTableAdapters.Mokejimo_korteleTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slaptažodžiosaltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slaptažodžiohashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likutisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokejimokorteleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mokėjimo kortelės";
            // 
            // buttonAdd
            // 
            this.buttonAdd.AnimateGlow = true;
            this.buttonAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonAdd.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonAdd.Location = new System.Drawing.Point(198, 227);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 35);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Pridėti naują";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AnimateGlow = true;
            this.buttonCancel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCancel.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonCancel.Location = new System.Drawing.Point(15, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 35);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Atgal";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // gridCards
            // 
            this.gridCards.AllowUserToAddRows = false;
            this.gridCards.AllowUserToDeleteRows = false;
            this.gridCards.AllowUserToResizeColumns = false;
            this.gridCards.AllowUserToResizeRows = false;
            this.gridCards.AutoGenerateColumns = false;
            this.gridCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCards.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridCards.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCards.CausesValidation = false;
            this.gridCards.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipasDataGridViewTextBoxColumn,
            this.bankasDataGridViewTextBoxColumn,
            this.slaptažodžiosaltDataGridViewTextBoxColumn,
            this.slaptažodžiohashDataGridViewTextBoxColumn,
            this.likutisDataGridViewTextBoxColumn,
            this.remove});
            this.gridCards.DataSource = this.mokejimokorteleBindingSource;
            this.gridCards.EnableHeadersVisualStyles = false;
            this.gridCards.GridColor = System.Drawing.Color.DarkCyan;
            this.gridCards.Location = new System.Drawing.Point(15, 29);
            this.gridCards.Name = "gridCards";
            this.gridCards.ReadOnly = true;
            this.gridCards.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridCards.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.gridCards.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCards.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridCards.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gridCards.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridCards.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCards.Size = new System.Drawing.Size(377, 144);
            this.gridCards.TabIndex = 32;
            this.gridCards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCards_CellContentClick);
            // 
            // mokejimokorteleBindingSource
            // 
            this.mokejimokorteleBindingSource.DataMember = "Mokejimo_kortele";
            this.mokejimokorteleBindingSource.DataSource = this.shopDBDataSet;
            // 
            // shopDBDataSet
            // 
            this.shopDBDataSet.DataSetName = "ShopDBDataSet";
            this.shopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mokejimo_korteleTableAdapter
            // 
            this.mokejimo_korteleTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipasDataGridViewTextBoxColumn
            // 
            this.tipasDataGridViewTextBoxColumn.DataPropertyName = "Tipas";
            this.tipasDataGridViewTextBoxColumn.HeaderText = "Tipas";
            this.tipasDataGridViewTextBoxColumn.Name = "tipasDataGridViewTextBoxColumn";
            this.tipasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankasDataGridViewTextBoxColumn
            // 
            this.bankasDataGridViewTextBoxColumn.DataPropertyName = "Bankas";
            this.bankasDataGridViewTextBoxColumn.HeaderText = "Bankas";
            this.bankasDataGridViewTextBoxColumn.Name = "bankasDataGridViewTextBoxColumn";
            this.bankasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slaptažodžiosaltDataGridViewTextBoxColumn
            // 
            this.slaptažodžiosaltDataGridViewTextBoxColumn.DataPropertyName = "Slaptažodžio_salt";
            this.slaptažodžiosaltDataGridViewTextBoxColumn.HeaderText = "Slaptažodžio_salt";
            this.slaptažodžiosaltDataGridViewTextBoxColumn.Name = "slaptažodžiosaltDataGridViewTextBoxColumn";
            this.slaptažodžiosaltDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slaptažodžiohashDataGridViewTextBoxColumn
            // 
            this.slaptažodžiohashDataGridViewTextBoxColumn.DataPropertyName = "Slaptažodžio_hash";
            this.slaptažodžiohashDataGridViewTextBoxColumn.HeaderText = "Slaptažodžio_hash";
            this.slaptažodžiohashDataGridViewTextBoxColumn.Name = "slaptažodžiohashDataGridViewTextBoxColumn";
            this.slaptažodžiohashDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // likutisDataGridViewTextBoxColumn
            // 
            this.likutisDataGridViewTextBoxColumn.DataPropertyName = "likutis";
            this.likutisDataGridViewTextBoxColumn.HeaderText = "likutis";
            this.likutisDataGridViewTextBoxColumn.Name = "likutisDataGridViewTextBoxColumn";
            this.likutisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remove
            // 
            this.remove.HeaderText = "Pašalinti";
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remove.Text = "Pašalinti";
            this.remove.UseColumnTextForButtonValue = true;
            // 
            // CreditCardsForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.ClientSize = new System.Drawing.Size(414, 274);
            this.ControlBox = false;
            this.Controls.Add(this.gridCards);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreditCardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CreditCardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokejimokorteleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private EnhancedGlassButton.GlassButton buttonAdd;
        private EnhancedGlassButton.GlassButton buttonCancel;
        public System.Windows.Forms.DataGridView gridCards;
        private ShopDBDataSet shopDBDataSet;
        private System.Windows.Forms.BindingSource mokejimokorteleBindingSource;
        public ShopDBDataSetTableAdapters.Mokejimo_korteleTableAdapter mokejimo_korteleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slaptažodžiosaltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slaptažodžiohashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn likutisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
    }
}