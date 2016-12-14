namespace WindowsFormsApplication3
{
    partial class CameraScanForm
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
            this.pictureBoxVideo = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonBack = new EnhancedGlassButton.GlassButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVideo
            // 
            this.pictureBoxVideo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxVideo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxVideo.Name = "pictureBoxVideo";
            this.pictureBoxVideo.Size = new System.Drawing.Size(495, 295);
            this.pictureBoxVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVideo.TabIndex = 34;
            this.pictureBoxVideo.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonBack
            // 
            this.buttonBack.AnimateGlow = true;
            this.buttonBack.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonBack.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonBack.Location = new System.Drawing.Point(39, 313);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(89, 35);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Grįžti atgal";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApplication3.Product);
            // 
            // CameraScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxVideo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(0, 63);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraScanForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraScanForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CameraScanForm_FormClosed);
            this.Load += new System.EventHandler(this.CameraScanForm_Load);
            this.VisibleChanged += new System.EventHandler(this.CameraScanForm_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CameraScan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CameraScan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CameraScan_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxVideo;
        private System.Windows.Forms.Timer timer;
        private EnhancedGlassButton.GlassButton buttonBack;
    }
}