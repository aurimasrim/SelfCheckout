namespace WindowsFormsApplication3
{
    partial class DiscountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.buttonCancel = new EnhancedGlassButton.GlassButton();
            this.buttonOk = new EnhancedGlassButton.GlassButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuolaida procentais:";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDiscount.Location = new System.Drawing.Point(39, 39);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(173, 20);
            this.textBoxDiscount.TabIndex = 1;
            this.textBoxDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDiscount_KeyDown);
            this.textBoxDiscount.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDiscount_Validating);
            this.textBoxDiscount.Validated += new System.EventHandler(this.textBoxDiscount_Validated);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AnimateGlow = true;
            this.buttonCancel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCancel.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonCancel.Location = new System.Drawing.Point(15, 65);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 35);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Atšaukti";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AnimateGlow = true;
            this.buttonOk.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonOk.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonOk.Location = new System.Drawing.Point(151, 65);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(89, 35);
            this.buttonOk.TabIndex = 31;
            this.buttonOk.Text = "Pritaikyti nuolaidą";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // DiscountForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(252, 113);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private EnhancedGlassButton.GlassButton buttonCancel;
        private EnhancedGlassButton.GlassButton buttonOk;
    }
}