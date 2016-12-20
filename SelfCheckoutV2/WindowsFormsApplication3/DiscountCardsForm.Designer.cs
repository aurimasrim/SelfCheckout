namespace WindowsFormsApplication3
{
    partial class DiscountCardsForm
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
            this.buttonSubmit = new EnhancedGlassButton.GlassButton();
            this.buttonCancel = new EnhancedGlassButton.GlassButton();
            this.gridCards = new System.Windows.Forms.DataGridView();
            this.nuolaidukorteleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRefresh = new EnhancedGlassButton.GlassButton();
            this.nuolaidu_korteleTableAdapter = new WindowsFormsApplication3.ShopDBDataSet2TableAdapters.Nuolaidu_korteleTableAdapter();
            this.shopDBDataSet2 = new WindowsFormsApplication3.ShopDBDataSet2();
            ((System.ComponentModel.ISupportInitialize)(this.gridCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuolaidukorteleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuolaidų kortelės";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.AnimateGlow = true;
            this.buttonSubmit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonSubmit.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonSubmit.Location = new System.Drawing.Point(293, 186);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(89, 35);
            this.buttonSubmit.TabIndex = 28;
            this.buttonSubmit.Text = "Patvirtinti pakeitimus";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
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
            this.gridCards.AllowUserToResizeColumns = false;
            this.gridCards.AllowUserToResizeRows = false;
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
            this.gridCards.EnableHeadersVisualStyles = false;
            this.gridCards.GridColor = System.Drawing.Color.DarkCyan;
            this.gridCards.Location = new System.Drawing.Point(15, 29);
            this.gridCards.Name = "gridCards";
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
            // nuolaidukorteleBindingSource
            // 
            this.nuolaidukorteleBindingSource.DataMember = "Nuolaidu_kortele";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.AnimateGlow = true;
            this.buttonRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonRefresh.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonRefresh.Location = new System.Drawing.Point(158, 186);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(89, 35);
            this.buttonRefresh.TabIndex = 33;
            this.buttonRefresh.Text = "Atnaujinti";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // nuolaidu_korteleTableAdapter
            // 
            this.nuolaidu_korteleTableAdapter.ClearBeforeFill = true;
            // 
            // shopDBDataSet2
            // 
            this.shopDBDataSet2.DataSetName = "ShopDBDataSet2";
            this.shopDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DiscountCardsForm
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.ClientSize = new System.Drawing.Size(414, 274);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.gridCards);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscountCardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CreditCardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuolaidukorteleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private EnhancedGlassButton.GlassButton buttonSubmit;
        private EnhancedGlassButton.GlassButton buttonCancel;
        public System.Windows.Forms.DataGridView gridCards;
        private System.Windows.Forms.BindingSource nuolaidukorteleBindingSource;
        private EnhancedGlassButton.GlassButton buttonRefresh;
        private ShopDBDataSet2TableAdapters.Nuolaidu_korteleTableAdapter nuolaidu_korteleTableAdapter;
        private ShopDBDataSet2 shopDBDataSet2;
    }
}