namespace WindowsFormsApplication3
{
    partial class AddressForm
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
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new EnhancedGlassButton.GlassButton();
            this.buttonCancel = new EnhancedGlassButton.GlassButton();
            this.SuspendLayout();
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxAddress.Location = new System.Drawing.Point(12, 38);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(233, 20);
            this.textBoxAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Įveskite adresą iš Voverys.lt:";
            // 
            // buttonOk
            // 
            this.buttonOk.AnimateGlow = true;
            this.buttonOk.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonOk.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonOk.Location = new System.Drawing.Point(156, 64);
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
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCancel.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonCancel.Location = new System.Drawing.Point(15, 64);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 35);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Atšaukti";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddressForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.ClientSize = new System.Drawing.Size(257, 105);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label1;
        private EnhancedGlassButton.GlassButton buttonOk;
        private EnhancedGlassButton.GlassButton buttonCancel;
    }
}