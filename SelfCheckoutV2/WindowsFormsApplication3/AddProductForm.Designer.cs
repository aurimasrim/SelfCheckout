namespace WindowsFormsApplication3
{
    partial class AddProductForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new EnhancedGlassButton.GlassButton();
            this.buttonCancel = new EnhancedGlassButton.GlassButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Barkodas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxPaidTare = new System.Windows.Forms.CheckBox();
            this.checkBoxAlcohol = new System.Windows.Forms.CheckBox();
            this.comboCategories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxName.Location = new System.Drawing.Point(40, 68);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            this.textBoxName.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prekės pridėjimas";
            // 
            // buttonOk
            // 
            this.buttonOk.AnimateGlow = true;
            this.buttonOk.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonOk.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonOk.Location = new System.Drawing.Point(184, 330);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(89, 35);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Gerai";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AnimateGlow = true;
            this.buttonCancel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCancel.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonCancel.Location = new System.Drawing.Point(12, 330);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 35);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Atšaukti";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(37, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Pavadinimas:";
            // 
            // Barkodas
            // 
            this.Barkodas.AutoSize = true;
            this.Barkodas.BackColor = System.Drawing.Color.Transparent;
            this.Barkodas.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Barkodas.Location = new System.Drawing.Point(37, 173);
            this.Barkodas.Name = "Barkodas";
            this.Barkodas.Size = new System.Drawing.Size(80, 17);
            this.Barkodas.TabIndex = 31;
            this.Barkodas.Text = "Barkodas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(37, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Svoris:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(37, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kaina:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPrice.Location = new System.Drawing.Point(40, 111);
            this.textBoxPrice.MaxLength = 8;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(233, 20);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrice_Validating);
            this.textBoxPrice.Validated += new System.EventHandler(this.textBoxPrice_Validated);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxWeight.Location = new System.Drawing.Point(40, 150);
            this.textBoxWeight.MaxLength = 7;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(233, 20);
            this.textBoxWeight.TabIndex = 3;
            this.textBoxWeight.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxWeight_Validating);
            this.textBoxWeight.Validated += new System.EventHandler(this.textBoxWeight_Validated);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxBarcode.Location = new System.Drawing.Point(40, 193);
            this.textBoxBarcode.MaxLength = 13;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(233, 20);
            this.textBoxBarcode.TabIndex = 4;
            this.textBoxBarcode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBarcode_Validating);
            this.textBoxBarcode.Validated += new System.EventHandler(this.textBoxBarcode_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(37, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Atributai:";
            // 
            // checkBoxPaidTare
            // 
            this.checkBoxPaidTare.AutoSize = true;
            this.checkBoxPaidTare.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPaidTare.Location = new System.Drawing.Point(57, 298);
            this.checkBoxPaidTare.Name = "checkBoxPaidTare";
            this.checkBoxPaidTare.Size = new System.Drawing.Size(88, 17);
            this.checkBoxPaidTare.TabIndex = 6;
            this.checkBoxPaidTare.Text = "Mokama tara";
            this.checkBoxPaidTare.UseVisualStyleBackColor = false;
            // 
            // checkBoxAlcohol
            // 
            this.checkBoxAlcohol.AutoSize = true;
            this.checkBoxAlcohol.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAlcohol.Location = new System.Drawing.Point(168, 298);
            this.checkBoxAlcohol.Name = "checkBoxAlcohol";
            this.checkBoxAlcohol.Size = new System.Drawing.Size(71, 17);
            this.checkBoxAlcohol.TabIndex = 7;
            this.checkBoxAlcohol.Text = "Reikia 18";
            this.checkBoxAlcohol.UseVisualStyleBackColor = false;
            // 
            // comboCategories
            // 
            this.comboCategories.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboCategories.CausesValidation = false;
            this.comboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategories.FormattingEnabled = true;
            this.comboCategories.Location = new System.Drawing.Point(40, 239);
            this.comboCategories.Name = "comboCategories";
            this.comboCategories.Size = new System.Drawing.Size(131, 21);
            this.comboCategories.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(37, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Kategorija:";
            // 
            // AddProductForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.ClientSize = new System.Drawing.Size(311, 377);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboCategories);
            this.Controls.Add(this.checkBoxAlcohol);
            this.Controls.Add(this.checkBoxPaidTare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Barkodas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private EnhancedGlassButton.GlassButton buttonOk;
        private EnhancedGlassButton.GlassButton buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Barkodas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxPaidTare;
        private System.Windows.Forms.CheckBox checkBoxAlcohol;
        private System.Windows.Forms.ComboBox comboCategories;
        private System.Windows.Forms.Label label6;
    }
}