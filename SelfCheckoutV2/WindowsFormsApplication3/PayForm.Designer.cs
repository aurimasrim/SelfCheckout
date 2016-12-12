namespace WindowsFormsApplication3
{
    partial class PayForm
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCash = new EnhancedGlassButton.GlassButton();
            this.buttonCard = new EnhancedGlassButton.GlassButton();
            this.boxTotal = new System.Windows.Forms.Label();
            this.buttonValidate = new EnhancedGlassButton.GlassButton();
            this.buttonBack = new EnhancedGlassButton.GlassButton();
            this.textBagCount = new System.Windows.Forms.TextBox();
            this.buttonOk = new EnhancedGlassButton.GlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPassword.Location = new System.Drawing.Point(179, 183);
            this.textBoxPassword.MaxLength = 4;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Visible = false;
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            this.textBoxPassword.Validated += new System.EventHandler(this.textBoxPassword_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(99, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Įdėkite kortelę ir įveskite slaptažodį";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liko mokėti:";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources.Euro_banknotes;
            this.pictureBox1.Location = new System.Drawing.Point(300, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.buttonCash_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApplication3.Properties.Resources.credit_cards_icon_11;
            this.pictureBox2.Location = new System.Drawing.Point(58, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.buttonCard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(115, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kiek maišelių panaudojote?";
            // 
            // buttonCash
            // 
            this.buttonCash.AnimateGlow = true;
            this.buttonCash.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCash.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCash.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonCash.Location = new System.Drawing.Point(312, 133);
            this.buttonCash.Name = "buttonCash";
            this.buttonCash.Size = new System.Drawing.Size(89, 35);
            this.buttonCash.TabIndex = 32;
            this.buttonCash.Text = "Grynaisiais pinigais";
            this.buttonCash.Visible = false;
            this.buttonCash.Click += new System.EventHandler(this.buttonCash_Click);
            // 
            // buttonCard
            // 
            this.buttonCard.AnimateGlow = true;
            this.buttonCard.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCard.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCard.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonCard.Location = new System.Drawing.Point(73, 133);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Size = new System.Drawing.Size(89, 35);
            this.buttonCard.TabIndex = 33;
            this.buttonCard.Text = "Kreditine kortele";
            this.buttonCard.Visible = false;
            this.buttonCard.Click += new System.EventHandler(this.buttonCard_Click);
            // 
            // boxTotal
            // 
            this.boxTotal.AutoSize = true;
            this.boxTotal.BackColor = System.Drawing.Color.Transparent;
            this.boxTotal.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTotal.Location = new System.Drawing.Point(200, 75);
            this.boxTotal.Name = "boxTotal";
            this.boxTotal.Size = new System.Drawing.Size(20, 26);
            this.boxTotal.TabIndex = 34;
            this.boxTotal.Text = " ";
            this.boxTotal.Visible = false;
            // 
            // buttonValidate
            // 
            this.buttonValidate.AnimateGlow = true;
            this.buttonValidate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonValidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonValidate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonValidate.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonValidate.Location = new System.Drawing.Point(190, 209);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(89, 35);
            this.buttonValidate.TabIndex = 35;
            this.buttonValidate.Text = "Gerai";
            this.buttonValidate.Visible = false;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AnimateGlow = true;
            this.buttonBack.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonBack.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonBack.Location = new System.Drawing.Point(22, 209);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(89, 35);
            this.buttonBack.TabIndex = 36;
            this.buttonBack.Text = "Grįžti atgal";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBagCount
            // 
            this.textBagCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBagCount.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBagCount.Location = new System.Drawing.Point(190, 75);
            this.textBagCount.MaxLength = 2;
            this.textBagCount.Name = "textBagCount";
            this.textBagCount.Size = new System.Drawing.Size(65, 66);
            this.textBagCount.TabIndex = 38;
            this.textBagCount.Text = "0";
            this.textBagCount.Validating += new System.ComponentModel.CancelEventHandler(this.textBagCount_Validating);
            this.textBagCount.Validated += new System.EventHandler(this.textBagCount_Validated);
            // 
            // buttonOk
            // 
            this.buttonOk.AnimateGlow = true;
            this.buttonOk.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonOk.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.buttonOk.Location = new System.Drawing.Point(190, 209);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(89, 35);
            this.buttonOk.TabIndex = 37;
            this.buttonOk.Text = "Gerai";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.mosaic_background_1;
            this.ClientSize = new System.Drawing.Size(462, 261);
            this.Controls.Add(this.textBagCount);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.boxTotal);
            this.Controls.Add(this.buttonCard);
            this.Controls.Add(this.buttonCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(750, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Apmokėjimas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PayForm_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.PayForm_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PayForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PayForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PayForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private EnhancedGlassButton.GlassButton buttonCash;
        private EnhancedGlassButton.GlassButton buttonCard;
        public System.Windows.Forms.Label boxTotal;
        private EnhancedGlassButton.GlassButton buttonValidate;
        private EnhancedGlassButton.GlassButton buttonBack;
        private System.Windows.Forms.TextBox textBagCount;
        private EnhancedGlassButton.GlassButton buttonOk;
    }
}