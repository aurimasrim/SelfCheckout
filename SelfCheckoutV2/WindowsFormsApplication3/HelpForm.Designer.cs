namespace WindowsFormsApplication3
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.buttonOk = new EnhancedGlassButton.GlassButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHelp = new EnhancedGlassButton.GlassButton();
            this.buttonAdminWindow = new EnhancedGlassButton.GlassButton();
            this.buttonClientWindow = new EnhancedGlassButton.GlassButton();
            this.buttonCheckoutWindow = new EnhancedGlassButton.GlassButton();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.AnimateGlow = true;
            this.buttonOk.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonOk.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonOk.Location = new System.Drawing.Point(307, 211);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(89, 35);
            this.buttonOk.TabIndex = 29;
            this.buttonOk.Text = "Gerai";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 212);
            this.label1.TabIndex = 30;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonHelp
            // 
            this.buttonHelp.AnimateGlow = true;
            this.buttonHelp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonHelp.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonHelp.Location = new System.Drawing.Point(6, 9);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(89, 35);
            this.buttonHelp.TabIndex = 31;
            this.buttonHelp.Text = "Pagalba";
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonAdminWindow
            // 
            this.buttonAdminWindow.AnimateGlow = true;
            this.buttonAdminWindow.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAdminWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminWindow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonAdminWindow.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonAdminWindow.Location = new System.Drawing.Point(188, 9);
            this.buttonAdminWindow.Name = "buttonAdminWindow";
            this.buttonAdminWindow.Size = new System.Drawing.Size(89, 35);
            this.buttonAdminWindow.TabIndex = 32;
            this.buttonAdminWindow.Text = "Valdytojo Langas";
            this.buttonAdminWindow.Click += new System.EventHandler(this.buttonWindow_Click);
            // 
            // buttonClientWindow
            // 
            this.buttonClientWindow.AnimateGlow = true;
            this.buttonClientWindow.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonClientWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientWindow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonClientWindow.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonClientWindow.Location = new System.Drawing.Point(362, 9);
            this.buttonClientWindow.Name = "buttonClientWindow";
            this.buttonClientWindow.Size = new System.Drawing.Size(89, 35);
            this.buttonClientWindow.TabIndex = 33;
            this.buttonClientWindow.Text = "Kliento langas";
            this.buttonClientWindow.Click += new System.EventHandler(this.buttonWindow_Click);
            // 
            // buttonCheckoutWindow
            // 
            this.buttonCheckoutWindow.AnimateGlow = true;
            this.buttonCheckoutWindow.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonCheckoutWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckoutWindow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCheckoutWindow.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonCheckoutWindow.Location = new System.Drawing.Point(516, 9);
            this.buttonCheckoutWindow.Name = "buttonCheckoutWindow";
            this.buttonCheckoutWindow.Size = new System.Drawing.Size(89, 35);
            this.buttonCheckoutWindow.TabIndex = 34;
            this.buttonCheckoutWindow.Text = "Kasos langas";
            this.buttonCheckoutWindow.Click += new System.EventHandler(this.buttonWindow_Click);
            // 
            // HelpForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.ClientSize = new System.Drawing.Size(640, 55);
            this.Controls.Add(this.buttonCheckoutWindow);
            this.Controls.Add(this.buttonClientWindow);
            this.Controls.Add(this.buttonAdminWindow);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 12);
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pagalba";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EnhancedGlassButton.GlassButton buttonOk;
        private System.Windows.Forms.Label label1;
        private EnhancedGlassButton.GlassButton buttonHelp;
        private EnhancedGlassButton.GlassButton buttonAdminWindow;
        private EnhancedGlassButton.GlassButton buttonClientWindow;
        private EnhancedGlassButton.GlassButton buttonCheckoutWindow;
    }
}