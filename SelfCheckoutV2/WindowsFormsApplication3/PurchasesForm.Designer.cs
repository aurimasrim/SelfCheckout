namespace WindowsFormsApplication3
{
    partial class PurchasesForm
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
            this.buttonCancel = new EnhancedGlassButton.GlassButton();
            this.gridPurchases = new System.Windows.Forms.DataGridView();
            this.pirkimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirkimasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pirkimai";
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
            // gridPurchases
            // 
            this.gridPurchases.AllowUserToAddRows = false;
            this.gridPurchases.AllowUserToDeleteRows = false;
            this.gridPurchases.AllowUserToResizeColumns = false;
            this.gridPurchases.AllowUserToResizeRows = false;
            this.gridPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridPurchases.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPurchases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPurchases.CausesValidation = false;
            this.gridPurchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPurchases.EnableHeadersVisualStyles = false;
            this.gridPurchases.GridColor = System.Drawing.Color.DarkCyan;
            this.gridPurchases.Location = new System.Drawing.Point(12, 29);
            this.gridPurchases.Name = "gridPurchases";
            this.gridPurchases.ReadOnly = true;
            this.gridPurchases.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridPurchases.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.gridPurchases.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPurchases.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPurchases.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gridPurchases.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPurchases.Size = new System.Drawing.Size(377, 144);
            this.gridPurchases.TabIndex = 32;
            this.gridPurchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCards_CellContentClick);
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.ClientSize = new System.Drawing.Size(414, 274);
            this.ControlBox = false;
            this.Controls.Add(this.gridPurchases);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CreditCardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirkimasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private EnhancedGlassButton.GlassButton buttonCancel;
        public System.Windows.Forms.DataGridView gridPurchases;
        private System.Windows.Forms.BindingSource pirkimasBindingSource;
    }
}