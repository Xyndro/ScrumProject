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
            this.LandingFormToDesktopsButton = new System.Windows.Forms.Button();
            this.LandingFormToLaptopsButton = new System.Windows.Forms.Button();
            this.LandingFormToMonitorsButton = new System.Windows.Forms.Button();
            this.LandingFormToPeripheralsButton = new System.Windows.Forms.Button();
            this.LandingFormDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LandingFormBackground)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LandingFormBackground
            // 
            this.LandingFormBackground.Image = global::CST4708_Project.Properties.Resources.formBackground;
            this.LandingFormBackground.Location = new System.Drawing.Point(-1, 27);
            this.LandingFormBackground.Name = "LandingFormBackground";
            this.LandingFormBackground.Size = new System.Drawing.Size(1220, 715);
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
            this.LandingFormTitleLabel.Location = new System.Drawing.Point(274, 92);
            this.LandingFormTitleLabel.Name = "LandingFormTitleLabel";
            this.LandingFormTitleLabel.Size = new System.Drawing.Size(646, 67);
            this.LandingFormTitleLabel.TabIndex = 8;
            this.LandingFormTitleLabel.Text = "Welcome To ExcaliTech!";
            // 
            // LandingFormDesktopsLabel
            // 
            this.LandingFormDesktopsLabel.AutoSize = true;
            this.LandingFormDesktopsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormDesktopsLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LandingFormDesktopsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormDesktopsLabel.Location = new System.Drawing.Point(87, 283);
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
            // LandingFormLaptopsLabel
            // 
            this.LandingFormLaptopsLabel.AutoSize = true;
            this.LandingFormLaptopsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormLaptopsLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LandingFormLaptopsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormLaptopsLabel.Location = new System.Drawing.Point(378, 283);
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
            this.LandingFormMonitorsLabel.Location = new System.Drawing.Point(665, 283);
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
            this.LandingFormPeripheralsLabel.Location = new System.Drawing.Point(964, 283);
            this.LandingFormPeripheralsLabel.Name = "LandingFormPeripheralsLabel";
            this.LandingFormPeripheralsLabel.Size = new System.Drawing.Size(158, 34);
            this.LandingFormPeripheralsLabel.TabIndex = 15;
            this.LandingFormPeripheralsLabel.Text = "Peripherals";
            // 
            // LandingFormToDesktopsButton
            // 
            this.LandingFormToDesktopsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LandingFormToDesktopsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LandingFormToDesktopsButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LandingFormToDesktopsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LandingFormToDesktopsButton.Location = new System.Drawing.Point(52, 659);
            this.LandingFormToDesktopsButton.Name = "LandingFormToDesktopsButton";
            this.LandingFormToDesktopsButton.Size = new System.Drawing.Size(196, 39);
            this.LandingFormToDesktopsButton.TabIndex = 16;
            this.LandingFormToDesktopsButton.Text = "View Featured Desktop";
            this.LandingFormToDesktopsButton.UseVisualStyleBackColor = false;
            this.LandingFormToDesktopsButton.Click += new System.EventHandler(this.LandingFormToDesktopsButton_Click);
            // 
            // LandingFormToLaptopsButton
            // 
            this.LandingFormToLaptopsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LandingFormToLaptopsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LandingFormToLaptopsButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LandingFormToLaptopsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LandingFormToLaptopsButton.Location = new System.Drawing.Point(341, 659);
            this.LandingFormToLaptopsButton.Name = "LandingFormToLaptopsButton";
            this.LandingFormToLaptopsButton.Size = new System.Drawing.Size(196, 39);
            this.LandingFormToLaptopsButton.TabIndex = 17;
            this.LandingFormToLaptopsButton.Text = "View Featured Laptop";
            this.LandingFormToLaptopsButton.UseVisualStyleBackColor = false;
            this.LandingFormToLaptopsButton.Click += new System.EventHandler(this.LandingFormToLaptopsButton_Click);
            // 
            // LandingFormToMonitorsButton
            // 
            this.LandingFormToMonitorsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LandingFormToMonitorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LandingFormToMonitorsButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LandingFormToMonitorsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LandingFormToMonitorsButton.Location = new System.Drawing.Point(629, 659);
            this.LandingFormToMonitorsButton.Name = "LandingFormToMonitorsButton";
            this.LandingFormToMonitorsButton.Size = new System.Drawing.Size(196, 39);
            this.LandingFormToMonitorsButton.TabIndex = 18;
            this.LandingFormToMonitorsButton.Text = "View Featured Monitor";
            this.LandingFormToMonitorsButton.UseVisualStyleBackColor = false;
            this.LandingFormToMonitorsButton.Click += new System.EventHandler(this.LandingFormToMonitorsButton_Click);
            // 
            // LandingFormToPeripheralsButton
            // 
            this.LandingFormToPeripheralsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LandingFormToPeripheralsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LandingFormToPeripheralsButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LandingFormToPeripheralsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LandingFormToPeripheralsButton.Location = new System.Drawing.Point(951, 654);
            this.LandingFormToPeripheralsButton.Name = "LandingFormToPeripheralsButton";
            this.LandingFormToPeripheralsButton.Size = new System.Drawing.Size(196, 48);
            this.LandingFormToPeripheralsButton.TabIndex = 19;
            this.LandingFormToPeripheralsButton.Text = "View Featured Peripheral";
            this.LandingFormToPeripheralsButton.UseVisualStyleBackColor = false;
            this.LandingFormToPeripheralsButton.Click += new System.EventHandler(this.LandingFormToPeripheralsButton_Click);
            // 
            // LandingFormDescription
            // 
            this.LandingFormDescription.AutoSize = true;
            this.LandingFormDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LandingFormDescription.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LandingFormDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LandingFormDescription.Location = new System.Drawing.Point(87, 179);
            this.LandingFormDescription.Name = "LandingFormDescription";
            this.LandingFormDescription.Size = new System.Drawing.Size(1069, 33);
            this.LandingFormDescription.TabIndex = 20;
            this.LandingFormDescription.Text = "Check out our featured products below, and use the navigation bar above to view o" +
    "ur inventory!\r\n";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1219, 740);
            this.Controls.Add(this.LandingFormDescription);
            this.Controls.Add(this.LandingFormToPeripheralsButton);
            this.Controls.Add(this.LandingFormToMonitorsButton);
            this.Controls.Add(this.LandingFormToLaptopsButton);
            this.Controls.Add(this.LandingFormToDesktopsButton);
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
        private Button LandingFormToDesktopsButton;
        private Button LandingFormToLaptopsButton;
        private Button LandingFormToMonitorsButton;
        private Button LandingFormToPeripheralsButton;
        private Label LandingFormDescription;
    }
}
