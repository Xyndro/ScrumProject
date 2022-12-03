namespace CST4708_Project
{
    partial class LaptopForm
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
            this.LaptopFormBackground = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.logInToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.peripheralToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LaptopFormTitleLabel = new System.Windows.Forms.Label();
            this.LaptopFormDescription = new System.Windows.Forms.Label();
            this.cartPhoto = new System.Windows.Forms.PictureBox();
            this.LaptopDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopFormBackground)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LaptopFormBackground
            // 
            this.LaptopFormBackground.Image = global::CST4708_Project.Properties.Resources.formBackground;
            this.LaptopFormBackground.Location = new System.Drawing.Point(0, 26);
            this.LaptopFormBackground.Name = "LaptopFormBackground";
            this.LaptopFormBackground.Size = new System.Drawing.Size(1303, 787);
            this.LaptopFormBackground.TabIndex = 2;
            this.LaptopFormBackground.TabStop = false;
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
            this.menuStrip.Size = new System.Drawing.Size(1302, 28);
            this.menuStrip.TabIndex = 3;
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
            // LaptopFormTitleLabel
            // 
            this.LaptopFormTitleLabel.AutoSize = true;
            this.LaptopFormTitleLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LaptopFormTitleLabel.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LaptopFormTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LaptopFormTitleLabel.Location = new System.Drawing.Point(439, 66);
            this.LaptopFormTitleLabel.Name = "LaptopFormTitleLabel";
            this.LaptopFormTitleLabel.Size = new System.Drawing.Size(446, 67);
            this.LaptopFormTitleLabel.TabIndex = 10;
            this.LaptopFormTitleLabel.Text = "Laptop Selection";
            // 
            // LaptopFormDescription
            // 
            this.LaptopFormDescription.AutoSize = true;
            this.LaptopFormDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LaptopFormDescription.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.LaptopFormDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LaptopFormDescription.Location = new System.Drawing.Point(387, 143);
            this.LaptopFormDescription.Name = "LaptopFormDescription";
            this.LaptopFormDescription.Size = new System.Drawing.Size(535, 34);
            this.LaptopFormDescription.TabIndex = 11;
            this.LaptopFormDescription.Text = "View our inventory of laptop products here!";
            // 
            // cartPhoto
            // 
            this.cartPhoto.Image = global::CST4708_Project.Properties.Resources.cartPhoto;
            this.cartPhoto.Location = new System.Drawing.Point(1165, 37);
            this.cartPhoto.Name = "cartPhoto";
            this.cartPhoto.Size = new System.Drawing.Size(125, 96);
            this.cartPhoto.TabIndex = 24;
            this.cartPhoto.TabStop = false;
            this.cartPhoto.Click += new System.EventHandler(this.cartPhoto_Click);
            // 
            // LaptopDataGridView
            // 
            this.LaptopDataGridView.AllowUserToAddRows = false;
            this.LaptopDataGridView.AllowUserToResizeColumns = false;
            this.LaptopDataGridView.AllowUserToResizeRows = false;
            this.LaptopDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.LaptopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaptopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column6,
            this.Column2,
            this.Column3});
            this.LaptopDataGridView.Location = new System.Drawing.Point(12, 197);
            this.LaptopDataGridView.Name = "LaptopDataGridView";
            this.LaptopDataGridView.RowHeadersWidth = 51;
            this.LaptopDataGridView.RowTemplate.Height = 29;
            this.LaptopDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LaptopDataGridView.Size = new System.Drawing.Size(1278, 589);
            this.LaptopDataGridView.TabIndex = 27;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Laptop Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Manufacturer";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Laptop Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 121;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Laptop Image";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // LaptopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1302, 812);
            this.Controls.Add(this.LaptopDataGridView);
            this.Controls.Add(this.cartPhoto);
            this.Controls.Add(this.LaptopFormDescription);
            this.Controls.Add(this.LaptopFormTitleLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.LaptopFormBackground);
            this.Name = "LaptopForm";
            this.Text = "LaptopForm";
            this.Load += new System.EventHandler(this.LaptopForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LaptopForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.LaptopFormBackground)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox LaptopFormBackground;
        private MenuStrip menuStrip;
        private ToolStripMenuItem logInToolStrip;
        private ToolStripMenuItem peripheralToolStrip;
        private ToolStripMenuItem monitorToolStrip;
        private ToolStripMenuItem laptopToolStrip;
        private ToolStripMenuItem desktopToolStrip;
        private ToolStripMenuItem homeToolStrip;
        private Label LaptopFormTitleLabel;
        private Label LaptopFormDescription;
        private PictureBox cartPhoto;
        private DataGridView LaptopDataGridView;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Column3;
    }
}
