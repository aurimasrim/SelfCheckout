namespace WindowsFormsApplication3
{
    partial class AddCreditCardForm
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
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new EnhancedGlassButton.GlassButton();
            this.buttonCancel = new EnhancedGlassButton.GlassButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Barkodas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.textBoxBank = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textId.Location = new System.Drawing.Point(40, 68);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(233, 20);
            this.textId.TabIndex = 1;
            this.textId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            this.textId.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mokėjimo kortelės pridėjimas";
            // 
            // buttonOk
            // 
            this.buttonOk.AnimateGlow = true;
            this.buttonOk.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonOk.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonOk.Location = new System.Drawing.Point(184, 232);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(89, 35);
            this.buttonOk.TabIndex = 28;
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
            this.buttonCancel.Location = new System.Drawing.Point(21, 232);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 35);
            this.buttonCancel.TabIndex = 29;
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
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Id:";
            // 
            // Barkodas
            // 
            this.Barkodas.AutoSize = true;
            this.Barkodas.BackColor = System.Drawing.Color.Transparent;
            this.Barkodas.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Barkodas.Location = new System.Drawing.Point(37, 173);
            this.Barkodas.Name = "Barkodas";
            this.Barkodas.Size = new System.Drawing.Size(59, 17);
            this.Barkodas.TabIndex = 31;
            this.Barkodas.Text = "Likutis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(37, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Bankas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(37, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipas:";
            // 
            // textType
            // 
            this.textType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textType.Location = new System.Drawing.Point(40, 111);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(233, 20);
            this.textType.TabIndex = 34;
            this.textType.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrice_Validating);
            this.textType.Validated += new System.EventHandler(this.textBoxPrice_Validated);
            // 
            // textBoxBank
            // 
            this.textBoxBank.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxBank.Location = new System.Drawing.Point(40, 150);
            this.textBoxBank.Name = "textBoxBank";
            this.textBoxBank.Size = new System.Drawing.Size(233, 20);
            this.textBoxBank.TabIndex = 35;
            this.textBoxBank.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxWeight_Validating);
            this.textBoxBank.Validated += new System.EventHandler(this.textBoxWeight_Validated);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxBalance.Location = new System.Drawing.Point(40, 193);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(233, 20);
            this.textBoxBalance.TabIndex = 37;
            this.textBoxBalance.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBarcode_Validating);
            this.textBoxBalance.Validated += new System.EventHandler(this.textBoxBarcode_Validated);
            // 
            // AddCreditCardForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.ClientSize = new System.Drawing.Size(311, 280);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxBank);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Barkodas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCreditCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private EnhancedGlassButton.GlassButton buttonOk;
        private EnhancedGlassButton.GlassButton buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Barkodas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textBoxBank;
        private System.Windows.Forms.TextBox textBoxBalance;
    }
}