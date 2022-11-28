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
            this.LandingFormDesktopsLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.logInToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.peripheralToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LandingFormLaptopsLabel = new System.Windows.Forms.Label();
            this.LandingFormMonitorsLabel = new System.Windows.Forms.Label();
            this.LandingFormPeripheralsLabel = new System.Windows.Forms.Label();
            this.FeaturedDesktopButton = new System.Windows.Forms.Button();
            this.FeaturedLaptopButton = new System.Windows.Forms.Button();
            this.FeaturedMonitorButton = new System.Windows.Forms.Button();
            this.FeaturedPeripheralButton = new System.Windows.Forms.Button();
            this.LandingFormDescription = new System.Windows.Forms.Label();
            this.cartPhoto = new System.Windows.Forms.PictureBox();
            this.FeaturedDesktopPhoto = new System.Windows.Forms.PictureBox();
            this.FeaturedLaptopPhoto = new System.Windows.Forms.PictureBox();
            this.FeaturedMonitorPhoto = new System.Windows.Forms.PictureBox();
            this.FeaturedPeripheralPhoto = new System.Windows.Forms.PictureBox();
            this.FeaturedDesktopNameLabel = new System.Windows.Forms.Label();
            this.FeaturedLaptopNameLabel = new System.Windows.Forms.Label();
            this.FeaturedMonitorNameLabel = new System.Windows.Forms.Label();
            this.FeaturedPeripheralNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LandingFormBackground)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedDesktopPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedLaptopPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedMonitorPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedPeripheralPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LandingFormBackground
            // 
            this.LandingFormBackground.Image = global::CST4708_Project.Properties.Resources.formBackground;
            this.LandingFormBackground.Location = new System.Drawing.Point(-1, 27);
            this.LandingFormBackground.Name = "LandingFormBackground";
            this.LandingFormBackground.Size = new System.Drawing.Size(1269, 715);
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
            this.LandingFormTitleLabel.Location = new System.Drawing.Point(314, 93);
            this.LandingFormTitleLabel.Name = "LandingFormTitleLabel";
            this.LandingFormTitleLabel.Size = new System.Drawing.Size(659, 67);
            this.LandingFormTitleLabel.TabIndex = 8;
            this.LandingFormTitleLabel.Text = "Welcome To ExCaliTech!";
            // 
            // LandingFormDesktopsLabel
            // 
            this.LandingFormDesktopsLabel.AutoSize = true;
            this.LandingFormDesktopsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormDesktopsLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LandingFormDesktopsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormDesktopsLabel.Location = new System.Drawing.Point(88, 283);
            this.LandingFormDesktopsLabel.Name = "LandingFormDesktopsLabel";
            this.LandingFormDesktopsLabel.Size = new System.Drawing.Size(127, 34);
            this.LandingFormDesktopsLabel.TabIndex = 10;
            this.LandingFormDesktopsLabel.Text = "Desktops";
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
            this.menuStrip.Size = new System.Drawing.Size(1248, 28);
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
            // LandingFormLaptopsLabel
            // 
            this.LandingFormLaptopsLabel.AutoSize = true;
            this.LandingFormLaptopsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormLaptopsLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LandingFormLaptopsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormLaptopsLabel.Location = new System.Drawing.Point(405, 283);
            this.LandingFormLaptopsLabel.Name = "LandingFormLaptopsLabel";
            this.LandingFormLaptopsLabel.Size = new System.Drawing.Size(113, 34);
            this.LandingFormLaptopsLabel.TabIndex = 13;
            this.LandingFormLaptopsLabel.Text = "Laptops";
            // 
            // LandingFormMonitorsLabel
            // 
            this.LandingFormMonitorsLabel.AutoSize = true;
            this.LandingFormMonitorsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormMonitorsLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LandingFormMonitorsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormMonitorsLabel.Location = new System.Drawing.Point(716, 283);
            this.LandingFormMonitorsLabel.Name = "LandingFormMonitorsLabel";
            this.LandingFormMonitorsLabel.Size = new System.Drawing.Size(129, 34);
            this.LandingFormMonitorsLabel.TabIndex = 14;
            this.LandingFormMonitorsLabel.Text = "Monitors";
            // 
            // LandingFormPeripheralsLabel
            // 
            this.LandingFormPeripheralsLabel.AutoSize = true;
            this.LandingFormPeripheralsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormPeripheralsLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LandingFormPeripheralsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormPeripheralsLabel.Location = new System.Drawing.Point(1025, 283);
            this.LandingFormPeripheralsLabel.Name = "LandingFormPeripheralsLabel";
            this.LandingFormPeripheralsLabel.Size = new System.Drawing.Size(158, 34);
            this.LandingFormPeripheralsLabel.TabIndex = 15;
            this.LandingFormPeripheralsLabel.Text = "Peripherals";
            // 
            // FeaturedDesktopButton
            // 
            this.FeaturedDesktopButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FeaturedDesktopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeaturedDesktopButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FeaturedDesktopButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FeaturedDesktopButton.Location = new System.Drawing.Point(53, 659);
            this.FeaturedDesktopButton.Name = "FeaturedDesktopButton";
            this.FeaturedDesktopButton.Size = new System.Drawing.Size(196, 39);
            this.FeaturedDesktopButton.TabIndex = 16;
            this.FeaturedDesktopButton.Text = "View Featured Desktop";
            this.FeaturedDesktopButton.UseVisualStyleBackColor = false;
            this.FeaturedDesktopButton.Click += new System.EventHandler(this.FeaturedDesktopButton_Click);
            // 
            // FeaturedLaptopButton
            // 
            this.FeaturedLaptopButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FeaturedLaptopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeaturedLaptopButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FeaturedLaptopButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FeaturedLaptopButton.Location = new System.Drawing.Point(362, 659);
            this.FeaturedLaptopButton.Name = "FeaturedLaptopButton";
            this.FeaturedLaptopButton.Size = new System.Drawing.Size(196, 39);
            this.FeaturedLaptopButton.TabIndex = 17;
            this.FeaturedLaptopButton.Text = "View Featured Laptop";
            this.FeaturedLaptopButton.UseVisualStyleBackColor = false;
            this.FeaturedLaptopButton.Click += new System.EventHandler(this.FeaturedLaptopButton_Click);
            // 
            // FeaturedMonitorButton
            // 
            this.FeaturedMonitorButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FeaturedMonitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeaturedMonitorButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FeaturedMonitorButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FeaturedMonitorButton.Location = new System.Drawing.Point(694, 659);
            this.FeaturedMonitorButton.Name = "FeaturedMonitorButton";
            this.FeaturedMonitorButton.Size = new System.Drawing.Size(196, 39);
            this.FeaturedMonitorButton.TabIndex = 18;
            this.FeaturedMonitorButton.Text = "View Featured Monitor";
            this.FeaturedMonitorButton.UseVisualStyleBackColor = false;
            this.FeaturedMonitorButton.Click += new System.EventHandler(this.FeaturedMonitorButton_Click);
            // 
            // FeaturedPeripheralButton
            // 
            this.FeaturedPeripheralButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FeaturedPeripheralButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeaturedPeripheralButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FeaturedPeripheralButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FeaturedPeripheralButton.Location = new System.Drawing.Point(1002, 654);
            this.FeaturedPeripheralButton.Name = "FeaturedPeripheralButton";
            this.FeaturedPeripheralButton.Size = new System.Drawing.Size(196, 48);
            this.FeaturedPeripheralButton.TabIndex = 19;
            this.FeaturedPeripheralButton.Text = "View Featured Peripheral";
            this.FeaturedPeripheralButton.UseVisualStyleBackColor = false;
            this.FeaturedPeripheralButton.Click += new System.EventHandler(this.FeaturedPeripheralButton_Click);
            // 
            // LandingFormDescription
            // 
            this.LandingFormDescription.AutoSize = true;
            this.LandingFormDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormDescription.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LandingFormDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormDescription.Location = new System.Drawing.Point(114, 178);
            this.LandingFormDescription.Name = "LandingFormDescription";
            this.LandingFormDescription.Size = new System.Drawing.Size(1069, 33);
            this.LandingFormDescription.TabIndex = 20;
            this.LandingFormDescription.Text = "Check out our featured products below, and use the navigation bar above to view o" +
    "ur inventory!\r\n";
            // 
            // cartPhoto
            // 
            this.cartPhoto.Image = global::CST4708_Project.Properties.Resources.cartPhoto;
            this.cartPhoto.Location = new System.Drawing.Point(1097, 44);
            this.cartPhoto.Name = "cartPhoto";
            this.cartPhoto.Size = new System.Drawing.Size(125, 98);
            this.cartPhoto.TabIndex = 21;
            this.cartPhoto.TabStop = false;
            // 
            // FeaturedDesktopPhoto
            // 
            this.FeaturedDesktopPhoto.Location = new System.Drawing.Point(23, 334);
            this.FeaturedDesktopPhoto.Name = "FeaturedDesktopPhoto";
            this.FeaturedDesktopPhoto.Size = new System.Drawing.Size(246, 259);
            this.FeaturedDesktopPhoto.TabIndex = 22;
            this.FeaturedDesktopPhoto.TabStop = false;
            // 
            // FeaturedLaptopPhoto
            // 
            this.FeaturedLaptopPhoto.Location = new System.Drawing.Point(336, 334);
            this.FeaturedLaptopPhoto.Name = "FeaturedLaptopPhoto";
            this.FeaturedLaptopPhoto.Size = new System.Drawing.Size(246, 259);
            this.FeaturedLaptopPhoto.TabIndex = 23;
            this.FeaturedLaptopPhoto.TabStop = false;
            // 
            // FeaturedMonitorPhoto
            // 
            this.FeaturedMonitorPhoto.Location = new System.Drawing.Point(665, 334);
            this.FeaturedMonitorPhoto.Name = "FeaturedMonitorPhoto";
            this.FeaturedMonitorPhoto.Size = new System.Drawing.Size(246, 259);
            this.FeaturedMonitorPhoto.TabIndex = 24;
            this.FeaturedMonitorPhoto.TabStop = false;
            // 
            // FeaturedPeripheralPhoto
            // 
            this.FeaturedPeripheralPhoto.Location = new System.Drawing.Point(976, 334);
            this.FeaturedPeripheralPhoto.Name = "FeaturedPeripheralPhoto";
            this.FeaturedPeripheralPhoto.Size = new System.Drawing.Size(246, 259);
            this.FeaturedPeripheralPhoto.TabIndex = 25;
            this.FeaturedPeripheralPhoto.TabStop = false;
            // 
            // FeaturedDesktopNameLabel
            // 
            this.FeaturedDesktopNameLabel.AutoSize = true;
            this.FeaturedDesktopNameLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeaturedDesktopNameLabel.Location = new System.Drawing.Point(12, 617);
            this.FeaturedDesktopNameLabel.Name = "FeaturedDesktopNameLabel";
            this.FeaturedDesktopNameLabel.Size = new System.Drawing.Size(78, 20);
            this.FeaturedDesktopNameLabel.TabIndex = 26;
            this.FeaturedDesktopNameLabel.Text = "Desktop: ";
            // 
            // FeaturedLaptopNameLabel
            // 
            this.FeaturedLaptopNameLabel.AutoSize = true;
            this.FeaturedLaptopNameLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeaturedLaptopNameLabel.Location = new System.Drawing.Point(336, 617);
            this.FeaturedLaptopNameLabel.Name = "FeaturedLaptopNameLabel";
            this.FeaturedLaptopNameLabel.Size = new System.Drawing.Size(69, 20);
            this.FeaturedLaptopNameLabel.TabIndex = 27;
            this.FeaturedLaptopNameLabel.Text = "Laptop: ";
            // 
            // FeaturedMonitorNameLabel
            // 
            this.FeaturedMonitorNameLabel.AutoSize = true;
            this.FeaturedMonitorNameLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeaturedMonitorNameLabel.Location = new System.Drawing.Point(665, 617);
            this.FeaturedMonitorNameLabel.Name = "FeaturedMonitorNameLabel";
            this.FeaturedMonitorNameLabel.Size = new System.Drawing.Size(76, 20);
            this.FeaturedMonitorNameLabel.TabIndex = 28;
            this.FeaturedMonitorNameLabel.Text = "Monitor: ";
            // 
            // FeaturedPeripheralNameLabel
            // 
            this.FeaturedPeripheralNameLabel.AutoSize = true;
            this.FeaturedPeripheralNameLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeaturedPeripheralNameLabel.Location = new System.Drawing.Point(976, 617);
            this.FeaturedPeripheralNameLabel.Name = "FeaturedPeripheralNameLabel";
            this.FeaturedPeripheralNameLabel.Size = new System.Drawing.Size(91, 20);
            this.FeaturedPeripheralNameLabel.TabIndex = 29;
            this.FeaturedPeripheralNameLabel.Text = "Peripheral: ";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1248, 740);
            this.Controls.Add(this.FeaturedPeripheralNameLabel);
            this.Controls.Add(this.FeaturedMonitorNameLabel);
            this.Controls.Add(this.FeaturedLaptopNameLabel);
            this.Controls.Add(this.FeaturedDesktopNameLabel);
            this.Controls.Add(this.FeaturedPeripheralPhoto);
            this.Controls.Add(this.FeaturedMonitorPhoto);
            this.Controls.Add(this.FeaturedLaptopPhoto);
            this.Controls.Add(this.FeaturedDesktopPhoto);
            this.Controls.Add(this.cartPhoto);
            this.Controls.Add(this.LandingFormDescription);
            this.Controls.Add(this.FeaturedPeripheralButton);
            this.Controls.Add(this.FeaturedMonitorButton);
            this.Controls.Add(this.FeaturedLaptopButton);
            this.Controls.Add(this.FeaturedDesktopButton);
            this.Controls.Add(this.LandingFormPeripheralsLabel);
            this.Controls.Add(this.LandingFormMonitorsLabel);
            this.Controls.Add(this.LandingFormLaptopsLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.LandingFormDesktopsLabel);
            this.Controls.Add(this.LandingFormTitleLabel);
            this.Controls.Add(this.LandingFormBackground);
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LandingFormBackground)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedDesktopPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedLaptopPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedMonitorPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedPeripheralPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox LandingFormBackground;
        private Label LandingFormTitleLabel;
        private Label LandingFormDesktopsLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem logInToolStrip;
        private ToolStripMenuItem peripheralToolStrip;
        private ToolStripMenuItem monitorToolStrip;
        private ToolStripMenuItem laptopToolStrip;
        private ToolStripMenuItem desktopToolStrip;
        private ToolStripMenuItem homeToolStrip;
        private Label LandingFormLaptopsLabel;
        private Label LandingFormMonitorsLabel;
        private Label LandingFormPeripheralsLabel;
        private Button FeaturedDesktopButton;
        private Button FeaturedLaptopButton;
        private Button FeaturedMonitorButton;
        private Button FeaturedPeripheralButton;
        private Label LandingFormDescription;
        private PictureBox cartPhoto;
        private PictureBox FeaturedDesktopPhoto;
        private PictureBox FeaturedLaptopPhoto;
        private PictureBox FeaturedMonitorPhoto;
        private PictureBox FeaturedPeripheralPhoto;
        private Label FeaturedDesktopNameLabel;
        private Label FeaturedLaptopNameLabel;
        private Label FeaturedMonitorNameLabel;
        private Label FeaturedPeripheralNameLabel;
    }
}
