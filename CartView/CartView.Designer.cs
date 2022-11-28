namespace CST4708_Project
{
    partial class CartView
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
            this.CartViewBackground = new System.Windows.Forms.PictureBox();
            this.CartViewCartLabel = new System.Windows.Forms.Label();
            this.cartPhoto = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartViewBackground)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(1234, 28);
            this.menuStrip.TabIndex = 12;
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
            // CartViewBackground
            // 
            this.CartViewBackground.Image = global::CST4708_Project.Properties.Resources.formBackground;
            this.CartViewBackground.Location = new System.Drawing.Point(-17, 23);
            this.CartViewBackground.Name = "CartViewBackground";
            this.CartViewBackground.Size = new System.Drawing.Size(1269, 705);
            this.CartViewBackground.TabIndex = 13;
            this.CartViewBackground.TabStop = false;
            // 
            // CartViewCartLabel
            // 
            this.CartViewCartLabel.AutoSize = true;
            this.CartViewCartLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CartViewCartLabel.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.CartViewCartLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CartViewCartLabel.Location = new System.Drawing.Point(476, 54);
            this.CartViewCartLabel.Name = "CartViewCartLabel";
            this.CartViewCartLabel.Size = new System.Drawing.Size(350, 67);
            this.CartViewCartLabel.TabIndex = 14;
            this.CartViewCartLabel.Text = "Current Cart";
            // 
            // cartPhoto
            // 
            this.cartPhoto.Image = global::CST4708_Project.Properties.Resources.cartPhoto;
            this.cartPhoto.Location = new System.Drawing.Point(1087, 43);
            this.cartPhoto.Name = "cartPhoto";
            this.cartPhoto.Size = new System.Drawing.Size(125, 96);
            this.cartPhoto.TabIndex = 23;
            this.cartPhoto.TabStop = false;
            // 
            // CartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 740);
            this.Controls.Add(this.cartPhoto);
            this.Controls.Add(this.CartViewCartLabel);
            this.Controls.Add(this.CartViewBackground);
            this.Controls.Add(this.menuStrip);
            this.Name = "CartView";
            this.Text = "CartView";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CartView_Paint);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartViewBackground)).EndInit();
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
        private PictureBox CartViewBackground;
        private Label CartViewCartLabel;
        private PictureBox cartPhoto;
    }
}
