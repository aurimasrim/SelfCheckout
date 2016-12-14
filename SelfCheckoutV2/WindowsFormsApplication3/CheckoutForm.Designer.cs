namespace WindowsFormsApplication3
{
    partial class CheckoutForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridScannedProducts = new System.Windows.Forms.DataGridView();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSearch = new EnhancedGlassButton.GlassButton();
            this.buttonPay = new EnhancedGlassButton.GlassButton();
            this.boxTotal = new System.Windows.Forms.Label();
            this.labelApproval = new System.Windows.Forms.Label();
            this.buttonScanWithCamera = new EnhancedGlassButton.GlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridScannedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuskenavę prekę pasverkite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(255, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mokėti:";
            // 
            // gridScannedProducts
            // 
            this.gridScannedProducts.AllowUserToAddRows = false;
            this.gridScannedProducts.AllowUserToDeleteRows = false;
            this.gridScannedProducts.AllowUserToResizeColumns = false;
            this.gridScannedProducts.AllowUserToResizeRows = false;
            this.gridScannedProducts.AutoGenerateColumns = false;
            this.gridScannedProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridScannedProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridScannedProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridScannedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridScannedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridScannedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.gridScannedProducts.DataSource = this.productBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridScannedProducts.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridScannedProducts.EnableHeadersVisualStyles = false;
            this.gridScannedProducts.GridColor = System.Drawing.Color.DarkCyan;
            this.gridScannedProducts.Location = new System.Drawing.Point(22, 57);
            this.gridScannedProducts.Name = "gridScannedProducts";
            this.gridScannedProducts.ReadOnly = true;
            this.gridScannedProducts.RowHeadersVisible = false;
            this.gridScannedProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridScannedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridScannedProducts.Size = new System.Drawing.Size(378, 166);
            this.gridScannedProducts.TabIndex = 6;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "Pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pnameDataGridViewTextBoxColumn.Width = 310;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Kaina";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.priceDataGridViewTextBoxColumn.Width = 50;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApplication3.Product);
            // 
            // buttonSearch
            // 
            this.buttonSearch.AnimateGlow = true;
            this.buttonSearch.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonSearch.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonSearch.Location = new System.Drawing.Point(435, 172);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 35);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "Ieškoti pagal barkodą";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.AnimateGlow = true;
            this.buttonPay.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonPay.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonPay.Location = new System.Drawing.Point(435, 221);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(127, 35);
            this.buttonPay.TabIndex = 29;
            this.buttonPay.Text = "Apmokėti";
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // boxTotal
            // 
            this.boxTotal.AutoSize = true;
            this.boxTotal.BackColor = System.Drawing.Color.Transparent;
            this.boxTotal.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTotal.Location = new System.Drawing.Point(317, 226);
            this.boxTotal.Name = "boxTotal";
            this.boxTotal.Size = new System.Drawing.Size(20, 26);
            this.boxTotal.TabIndex = 35;
            this.boxTotal.Text = " ";
            // 
            // labelApproval
            // 
            this.labelApproval.AutoSize = true;
            this.labelApproval.BackColor = System.Drawing.Color.Transparent;
            this.labelApproval.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApproval.ForeColor = System.Drawing.Color.Red;
            this.labelApproval.Location = new System.Drawing.Point(406, 87);
            this.labelApproval.Name = "labelApproval";
            this.labelApproval.Size = new System.Drawing.Size(147, 34);
            this.labelApproval.TabIndex = 36;
            this.labelApproval.Text = "Reikia darbuotojo\r\npatvirtinimo!";
            this.labelApproval.Visible = false;
            // 
            // buttonScanWithCamera
            // 
            this.buttonScanWithCamera.AnimateGlow = true;
            this.buttonScanWithCamera.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonScanWithCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonScanWithCamera.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonScanWithCamera.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonScanWithCamera.Location = new System.Drawing.Point(435, 131);
            this.buttonScanWithCamera.Name = "buttonScanWithCamera";
            this.buttonScanWithCamera.Size = new System.Drawing.Size(127, 35);
            this.buttonScanWithCamera.TabIndex = 37;
            this.buttonScanWithCamera.Text = "Skenuoti skeneriu";
            this.buttonScanWithCamera.Click += new System.EventHandler(this.buttonScanWithCamera_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.buttonScanWithCamera);
            this.Controls.Add(this.labelApproval);
            this.Controls.Add(this.boxTotal);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.gridScannedProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(750, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckoutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Savitarnos kasa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckoutForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckoutForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckoutForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckoutForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.gridScannedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private EnhancedGlassButton.GlassButton buttonSearch;
        private EnhancedGlassButton.GlassButton buttonPay;
        public System.Windows.Forms.Label boxTotal;
        private System.Windows.Forms.DataGridView gridScannedProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label labelApproval;
        private EnhancedGlassButton.GlassButton buttonScanWithCamera;
    }
}

