namespace CST4708_Project
{
    partial class LandingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LandingFormBackground = new System.Windows.Forms.PictureBox();
            this.LandingFormTitleLabel = new System.Windows.Forms.Label();
            this.LandingFormDescription = new System.Windows.Forms.Label();
            this.LandingFormDesktopLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.logInToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.peripheralToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LandingFormDesktopDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LandingFormBackground)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LandingFormBackground
            // 
            this.LandingFormBackground.Image = global::CST4708_Project.Properties.Resources.formBackground;
            this.LandingFormBackground.Location = new System.Drawing.Point(-1, 27);
            this.LandingFormBackground.Name = "LandingFormBackground";
            this.LandingFormBackground.Size = new System.Drawing.Size(1220, 655);
            this.LandingFormBackground.TabIndex = 7;
            this.LandingFormBackground.TabStop = false;
            this.LandingFormBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.LandingFormBackground_Paint);
            // 
            // LandingFormTitleLabel
            // 
            this.LandingFormTitleLabel.AutoSize = true;
            this.LandingFormTitleLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormTitleLabel.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LandingFormTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormTitleLabel.Location = new System.Drawing.Point(465, 93);
            this.LandingFormTitleLabel.Name = "LandingFormTitleLabel";
            this.LandingFormTitleLabel.Size = new System.Drawing.Size(276, 67);
            this.LandingFormTitleLabel.TabIndex = 8;
            this.LandingFormTitleLabel.Text = "Welcome!";
            // 
            // LandingFormDescription
            // 
            this.LandingFormDescription.AutoSize = true;
            this.LandingFormDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormDescription.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LandingFormDescription.Location = new System.Drawing.Point(160, 173);
            this.LandingFormDescription.Name = "LandingFormDescription";
            this.LandingFormDescription.Size = new System.Drawing.Size(887, 42);
            this.LandingFormDescription.TabIndex = 9;
            this.LandingFormDescription.Text = "Please use the navigation bar above to browse our products!";
            // 
            // LandingFormDesktopLabel
            // 
            this.LandingFormDesktopLabel.AutoSize = true;
            this.LandingFormDesktopLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormDesktopLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LandingFormDesktopLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormDesktopLabel.Location = new System.Drawing.Point(131, 273);
            this.LandingFormDesktopLabel.Name = "LandingFormDesktopLabel";
            this.LandingFormDesktopLabel.Size = new System.Drawing.Size(127, 34);
            this.LandingFormDesktopLabel.TabIndex = 10;
            this.LandingFormDesktopLabel.Text = "Desktops";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStrip,
            this.peripheralToolStrip,
            this.monitorToolStrip,
            this.laptopToolStrip,
            this.desktopToolStrip,
            this.homeToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(1219, 28);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip";
            // 
            // logInToolStrip
            // 
            this.logInToolStrip.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logInToolStrip.Name = "logInToolStrip";
            this.logInToolStrip.Size = new System.Drawing.Size(76, 24);
            this.logInToolStrip.Text = "Log In";
            this.logInToolStrip.Click += new System.EventHandler(this.logInToolStrip_Click);
            // 
            // peripheralToolStrip
            // 
            this.peripheralToolStrip.Name = "peripheralToolStrip";
            this.peripheralToolStrip.Size = new System.Drawing.Size(103, 24);
            this.peripheralToolStrip.Text = "Peripherals";
            this.peripheralToolStrip.Click += new System.EventHandler(this.peripheralToolStrip_Click);
            // 
            // monitorToolStrip
            // 
            this.monitorToolStrip.Name = "monitorToolStrip";
            this.monitorToolStrip.Size = new System.Drawing.Size(88, 24);
            this.monitorToolStrip.Text = "Monitors";
            this.monitorToolStrip.Click += new System.EventHandler(this.monitorToolStrip_Click);
            // 
            // laptopToolStrip
            // 
            this.laptopToolStrip.Name = "laptopToolStrip";
            this.laptopToolStrip.Size = new System.Drawing.Size(81, 24);
            this.laptopToolStrip.Text = "Laptops";
            this.laptopToolStrip.Click += new System.EventHandler(this.laptopToolStrip_Click);
            // 
            // desktopToolStrip
            // 
            this.desktopToolStrip.Name = "desktopToolStrip";
            this.desktopToolStrip.Size = new System.Drawing.Size(90, 24);
            this.desktopToolStrip.Text = "Desktops";
            this.desktopToolStrip.Click += new System.EventHandler(this.desktopToolStrip_Click);
            // 
            // homeToolStrip
            // 
            this.homeToolStrip.Name = "homeToolStrip";
            this.homeToolStrip.Size = new System.Drawing.Size(67, 24);
            this.homeToolStrip.Text = "Home";
            this.homeToolStrip.Click += new System.EventHandler(this.homeToolStrip_Click);
            // 
            // LandingFormDesktopDescription
            // 
            this.LandingFormDesktopDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormDesktopDescription.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LandingFormDesktopDescription.Location = new System.Drawing.Point(12, 317);
            this.LandingFormDesktopDescription.Name = "LandingFormDesktopDescription";
            this.LandingFormDesktopDescription.Size = new System.Drawing.Size(369, 88);
            this.LandingFormDesktopDescription.TabIndex = 12;
            this.LandingFormDesktopDescription.Text = "Here, you can browse our great selection of desktop\r\nproducts, all with amazing s" +
    "pecs, and their own \r\nunique characteristics. Click DESKTOPS to check them out!";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1219, 681);
            this.Controls.Add(this.LandingFormDesktopDescription);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.LandingFormDesktopLabel);
            this.Controls.Add(this.LandingFormDescription);
            this.Controls.Add(this.LandingFormTitleLabel);
            this.Controls.Add(this.LandingFormBackground);
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LandingFormBackground)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox LandingFormBackground;
        private Label LandingFormTitleLabel;
        private Label LandingFormDescription;
        private Label LandingFormDesktopLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem logInToolStrip;
        private ToolStripMenuItem peripheralToolStrip;
        private ToolStripMenuItem monitorToolStrip;
        private ToolStripMenuItem laptopToolStrip;
        private ToolStripMenuItem desktopToolStrip;
        private ToolStripMenuItem homeToolStrip;
        private Label LandingFormDesktopDescription;
    }
}
