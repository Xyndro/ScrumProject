namespace CST4708_Project
{
    partial class PeripheralForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.logInToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.peripheralToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PeripheralFormBackground = new System.Windows.Forms.PictureBox();
            this.PeripheralFormTitleLabel = new System.Windows.Forms.Label();
            this.PeripheralFormDescription = new System.Windows.Forms.Label();
            this.PeripheralProductsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.cartPhoto = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeripheralFormBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(1292, 28);
            this.menuStrip.TabIndex = 6;
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
            // PeripheralFormBackground
            // 
            this.PeripheralFormBackground.Image = global::CST4708_Project.Properties.Resources.formBackground;
            this.PeripheralFormBackground.Location = new System.Drawing.Point(-9, 24);
            this.PeripheralFormBackground.Name = "PeripheralFormBackground";
            this.PeripheralFormBackground.Size = new System.Drawing.Size(1311, 794);
            this.PeripheralFormBackground.TabIndex = 7;
            this.PeripheralFormBackground.TabStop = false;
            // 
            // PeripheralFormTitleLabel
            // 
            this.PeripheralFormTitleLabel.AutoSize = true;
            this.PeripheralFormTitleLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PeripheralFormTitleLabel.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.PeripheralFormTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PeripheralFormTitleLabel.Location = new System.Drawing.Point(383, 58);
            this.PeripheralFormTitleLabel.Name = "PeripheralFormTitleLabel";
            this.PeripheralFormTitleLabel.Size = new System.Drawing.Size(536, 67);
            this.PeripheralFormTitleLabel.TabIndex = 9;
            this.PeripheralFormTitleLabel.Text = "Peripheral Selection";
            // 
            // PeripheralFormDescription
            // 
            this.PeripheralFormDescription.AutoSize = true;
            this.PeripheralFormDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PeripheralFormDescription.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeripheralFormDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PeripheralFormDescription.Location = new System.Drawing.Point(383, 137);
            this.PeripheralFormDescription.Name = "PeripheralFormDescription";
            this.PeripheralFormDescription.Size = new System.Drawing.Size(540, 33);
            this.PeripheralFormDescription.TabIndex = 21;
            this.PeripheralFormDescription.Text = "Check out our peripherals to go with your tech!";
            // 
            // PeripheralProductsFlowLayout
            // 
            this.PeripheralProductsFlowLayout.AutoScroll = true;
            this.PeripheralProductsFlowLayout.Location = new System.Drawing.Point(32, 202);
            this.PeripheralProductsFlowLayout.Name = "PeripheralProductsFlowLayout";
            this.PeripheralProductsFlowLayout.Size = new System.Drawing.Size(1231, 570);
            this.PeripheralProductsFlowLayout.TabIndex = 25;
            // 
            // cartPhoto
            // 
            this.cartPhoto.Image = global::CST4708_Project.Properties.Resources.cartPhoto;
            this.cartPhoto.Location = new System.Drawing.Point(1155, 40);
            this.cartPhoto.Name = "cartPhoto";
            this.cartPhoto.Size = new System.Drawing.Size(125, 96);
            this.cartPhoto.TabIndex = 26;
            this.cartPhoto.TabStop = false;
            // 
            // PeripheralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 812);
            this.Controls.Add(this.cartPhoto);
            this.Controls.Add(this.PeripheralProductsFlowLayout);
            this.Controls.Add(this.PeripheralFormDescription);
            this.Controls.Add(this.PeripheralFormTitleLabel);
            this.Controls.Add(this.PeripheralFormBackground);
            this.Controls.Add(this.menuStrip);
            this.Name = "PeripheralForm";
            this.Text = "PeripheralForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PeripheralForm_Paint);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeripheralFormBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem logInToolStrip;
        private ToolStripMenuItem peripheralToolStrip;
        private ToolStripMenuItem monitorToolStrip;
        private ToolStripMenuItem laptopToolStrip;
        private ToolStripMenuItem desktopToolStrip;
        private ToolStripMenuItem homeToolStrip;
        private PictureBox PeripheralFormBackground;
        private Label PeripheralFormTitleLabel;
        private Label PeripheralFormDescription;
        private FlowLayoutPanel PeripheralProductsFlowLayout;
        private PictureBox cartPhoto;
    }
}
