namespace CST4708_Project
{
    partial class ProductView
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
            this.ProductViewBackground = new System.Windows.Forms.PictureBox();
            this.ProductViewLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.logInToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.peripheralToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cartPhoto = new System.Windows.Forms.PictureBox();
            this.ProductViewPicture = new System.Windows.Forms.PictureBox();
            this.ProductViewName = new System.Windows.Forms.Label();
            this.ProductViewManufacturer = new System.Windows.Forms.Label();
            this.ProductViewSKU = new System.Windows.Forms.Label();
            this.ProductViewCPU = new System.Windows.Forms.Label();
            this.ProductViewStorage = new System.Windows.Forms.Label();
            this.ProductViewPrice = new System.Windows.Forms.Label();
            this.ProductViewDescription = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProductViewAddToCartButton = new System.Windows.Forms.Button();
            this.SKULabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.StorageLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductViewBackground)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductViewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductViewBackground
            // 
            this.ProductViewBackground.Image = global::CST4708_Project.Properties.Resources.formBackground;
            this.ProductViewBackground.Location = new System.Drawing.Point(-1, 24);
            this.ProductViewBackground.Name = "ProductViewBackground";
            this.ProductViewBackground.Size = new System.Drawing.Size(1235, 703);
            this.ProductViewBackground.TabIndex = 8;
            this.ProductViewBackground.TabStop = false;
            // 
            // ProductViewLabel
            // 
            this.ProductViewLabel.AutoSize = true;
            this.ProductViewLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ProductViewLabel.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ProductViewLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductViewLabel.Location = new System.Drawing.Point(361, 84);
            this.ProductViewLabel.Name = "ProductViewLabel";
            this.ProductViewLabel.Size = new System.Drawing.Size(529, 67);
            this.ProductViewLabel.TabIndex = 10;
            this.ProductViewLabel.Text = "Currently Viewing...";
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
            // cartPhoto
            // 
            this.cartPhoto.Image = global::CST4708_Project.Properties.Resources.cartPhoto;
            this.cartPhoto.Location = new System.Drawing.Point(1059, 45);
            this.cartPhoto.Name = "cartPhoto";
            this.cartPhoto.Size = new System.Drawing.Size(125, 96);
            this.cartPhoto.TabIndex = 22;
            this.cartPhoto.TabStop = false;
            this.cartPhoto.Click += new System.EventHandler(this.cartPhoto_Click);
            // 
            // ProductViewPicture
            // 
            this.ProductViewPicture.Location = new System.Drawing.Point(53, 203);
            this.ProductViewPicture.Name = "ProductViewPicture";
            this.ProductViewPicture.Size = new System.Drawing.Size(436, 476);
            this.ProductViewPicture.TabIndex = 23;
            this.ProductViewPicture.TabStop = false;
            // 
            // ProductViewName
            // 
            this.ProductViewName.AutoSize = true;
            this.ProductViewName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductViewName.Location = new System.Drawing.Point(646, 273);
            this.ProductViewName.Name = "ProductViewName";
            this.ProductViewName.Size = new System.Drawing.Size(62, 22);
            this.ProductViewName.TabIndex = 24;
            this.ProductViewName.Text = "Name:";
            // 
            // ProductViewManufacturer
            // 
            this.ProductViewManufacturer.AutoSize = true;
            this.ProductViewManufacturer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductViewManufacturer.Location = new System.Drawing.Point(646, 328);
            this.ProductViewManufacturer.Name = "ProductViewManufacturer";
            this.ProductViewManufacturer.Size = new System.Drawing.Size(121, 22);
            this.ProductViewManufacturer.TabIndex = 25;
            this.ProductViewManufacturer.Text = "Manufacturer:";
            // 
            // ProductViewSKU
            // 
            this.ProductViewSKU.AutoSize = true;
            this.ProductViewSKU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductViewSKU.Location = new System.Drawing.Point(646, 219);
            this.ProductViewSKU.Name = "ProductViewSKU";
            this.ProductViewSKU.Size = new System.Drawing.Size(122, 22);
            this.ProductViewSKU.TabIndex = 26;
            this.ProductViewSKU.Text = "SKU Number:";
            // 
            // ProductViewCPU
            // 
            this.ProductViewCPU.AutoSize = true;
            this.ProductViewCPU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductViewCPU.Location = new System.Drawing.Point(646, 378);
            this.ProductViewCPU.Name = "ProductViewCPU";
            this.ProductViewCPU.Size = new System.Drawing.Size(53, 22);
            this.ProductViewCPU.TabIndex = 27;
            this.ProductViewCPU.Text = "CPU:";
            // 
            // ProductViewStorage
            // 
            this.ProductViewStorage.AutoSize = true;
            this.ProductViewStorage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductViewStorage.Location = new System.Drawing.Point(646, 429);
            this.ProductViewStorage.Name = "ProductViewStorage";
            this.ProductViewStorage.Size = new System.Drawing.Size(129, 22);
            this.ProductViewStorage.TabIndex = 28;
            this.ProductViewStorage.Text = "Storage Space:";
            // 
            // ProductViewPrice
            // 
            this.ProductViewPrice.AutoSize = true;
            this.ProductViewPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductViewPrice.Location = new System.Drawing.Point(646, 482);
            this.ProductViewPrice.Name = "ProductViewPrice";
            this.ProductViewPrice.Size = new System.Drawing.Size(58, 22);
            this.ProductViewPrice.TabIndex = 29;
            this.ProductViewPrice.Text = "Price:";
            // 
            // ProductViewDescription
            // 
            this.ProductViewDescription.AutoSize = true;
            this.ProductViewDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductViewDescription.Location = new System.Drawing.Point(646, 535);
            this.ProductViewDescription.Name = "ProductViewDescription";
            this.ProductViewDescription.Size = new System.Drawing.Size(109, 22);
            this.ProductViewDescription.TabIndex = 30;
            this.ProductViewDescription.Text = "Description:";
            // 
            // ProductViewAddToCartButton
            // 
            this.ProductViewAddToCartButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductViewAddToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductViewAddToCartButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ProductViewAddToCartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductViewAddToCartButton.Location = new System.Drawing.Point(774, 640);
            this.ProductViewAddToCartButton.Name = "ProductViewAddToCartButton";
            this.ProductViewAddToCartButton.Size = new System.Drawing.Size(196, 39);
            this.ProductViewAddToCartButton.TabIndex = 32;
            this.ProductViewAddToCartButton.Text = "Add To Cart";
            this.ProductViewAddToCartButton.UseVisualStyleBackColor = false;
            // 
            // SKULabel
            // 
            this.SKULabel.AutoSize = true;
            this.SKULabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SKULabel.Location = new System.Drawing.Point(824, 219);
            this.SKULabel.Name = "SKULabel";
            this.SKULabel.Size = new System.Drawing.Size(158, 22);
            this.SKULabel.TabIndex = 33;
            this.SKULabel.Text = "Product SKU Here";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(824, 273);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(166, 22);
            this.NameLabel.TabIndex = 34;
            this.NameLabel.Text = "Product Name Here";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManufacturerLabel.Location = new System.Drawing.Point(824, 328);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(225, 22);
            this.ManufacturerLabel.TabIndex = 35;
            this.ManufacturerLabel.Text = "Product Manufacturer Here";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPULabel.Location = new System.Drawing.Point(824, 378);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(157, 22);
            this.CPULabel.TabIndex = 36;
            this.CPULabel.Text = "Product CPU Here";
            // 
            // StorageLabel
            // 
            this.StorageLabel.AutoSize = true;
            this.StorageLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StorageLabel.Location = new System.Drawing.Point(824, 429);
            this.StorageLabel.Name = "StorageLabel";
            this.StorageLabel.Size = new System.Drawing.Size(180, 22);
            this.StorageLabel.TabIndex = 37;
            this.StorageLabel.Text = "Product Storage Here";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(824, 482);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(162, 22);
            this.PriceLabel.TabIndex = 38;
            this.PriceLabel.Text = "Product Price Here";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(824, 535);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(213, 22);
            this.DescriptionLabel.TabIndex = 39;
            this.DescriptionLabel.Text = "Product Description Here";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1234, 722);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.StorageLabel);
            this.Controls.Add(this.CPULabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SKULabel);
            this.Controls.Add(this.ProductViewAddToCartButton);
            this.Controls.Add(this.ProductViewDescription);
            this.Controls.Add(this.ProductViewPrice);
            this.Controls.Add(this.ProductViewStorage);
            this.Controls.Add(this.ProductViewCPU);
            this.Controls.Add(this.ProductViewSKU);
            this.Controls.Add(this.ProductViewManufacturer);
            this.Controls.Add(this.ProductViewName);
            this.Controls.Add(this.ProductViewPicture);
            this.Controls.Add(this.cartPhoto);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.ProductViewLabel);
            this.Controls.Add(this.ProductViewBackground);
            this.Name = "ProductView";
            this.Text = "ProductView";
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductView_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ProductViewBackground)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductViewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox ProductViewBackground;
        private Label ProductViewLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem logInToolStrip;
        private ToolStripMenuItem peripheralToolStrip;
        private ToolStripMenuItem monitorToolStrip;
        private ToolStripMenuItem laptopToolStrip;
        private ToolStripMenuItem desktopToolStrip;
        private ToolStripMenuItem homeToolStrip;
        private PictureBox cartPhoto;
        private PictureBox ProductViewPicture;
        private Label ProductViewName;
        private Label ProductViewManufacturer;
        private Label ProductViewSKU;
        private Label ProductViewCPU;
        private Label ProductViewStorage;
        private Label ProductViewPrice;
        private Label ProductViewDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ProductViewAddToCartButton;
        private Label SKULabel;
        private Label NameLabel;
        private Label ManufacturerLabel;
        private Label CPULabel;
        private Label StorageLabel;
        private Label PriceLabel;
        private Label DescriptionLabel;
    }
}
