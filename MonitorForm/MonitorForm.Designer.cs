namespace CST4708_Project
{
    partial class MonitorForm
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
            this.MonitorFormBackground = new System.Windows.Forms.PictureBox();
            this.MonitorFormTitleLabel = new System.Windows.Forms.Label();
            this.MonitorFormDescription = new System.Windows.Forms.Label();
            this.cartPhoto = new System.Windows.Forms.PictureBox();
            this.MonitorDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorFormBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorDataGridView)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(1302, 28);
            this.menuStrip.TabIndex = 5;
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
            // MonitorFormBackground
            // 
            this.MonitorFormBackground.Image = global::CST4708_Project.Properties.Resources.formBackground;
            this.MonitorFormBackground.Location = new System.Drawing.Point(0, 25);
            this.MonitorFormBackground.Name = "MonitorFormBackground";
            this.MonitorFormBackground.Size = new System.Drawing.Size(1302, 805);
            this.MonitorFormBackground.TabIndex = 6;
            this.MonitorFormBackground.TabStop = false;
            // 
            // MonitorFormTitleLabel
            // 
            this.MonitorFormTitleLabel.AutoSize = true;
            this.MonitorFormTitleLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MonitorFormTitleLabel.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.MonitorFormTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MonitorFormTitleLabel.Location = new System.Drawing.Point(423, 74);
            this.MonitorFormTitleLabel.Name = "MonitorFormTitleLabel";
            this.MonitorFormTitleLabel.Size = new System.Drawing.Size(475, 67);
            this.MonitorFormTitleLabel.TabIndex = 9;
            this.MonitorFormTitleLabel.Text = "Monitor Selection";
            // 
            // MonitorFormDescription
            // 
            this.MonitorFormDescription.AutoSize = true;
            this.MonitorFormDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MonitorFormDescription.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.MonitorFormDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MonitorFormDescription.Location = new System.Drawing.Point(378, 170);
            this.MonitorFormDescription.Name = "MonitorFormDescription";
            this.MonitorFormDescription.Size = new System.Drawing.Size(553, 34);
            this.MonitorFormDescription.TabIndex = 11;
            this.MonitorFormDescription.Text = "View our inventory of desktop products here!";
            // 
            // cartPhoto
            // 
            this.cartPhoto.Image = global::CST4708_Project.Properties.Resources.cartPhoto;
            this.cartPhoto.Location = new System.Drawing.Point(1165, 45);
            this.cartPhoto.Name = "cartPhoto";
            this.cartPhoto.Size = new System.Drawing.Size(125, 96);
            this.cartPhoto.TabIndex = 25;
            this.cartPhoto.TabStop = false;
            this.cartPhoto.Click += new System.EventHandler(this.cartPhoto_Click);
            // 
            // MonitorDataGridView
            // 
            this.MonitorDataGridView.AllowUserToAddRows = false;
            this.MonitorDataGridView.AllowUserToResizeColumns = false;
            this.MonitorDataGridView.AllowUserToResizeRows = false;
            this.MonitorDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.MonitorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonitorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column6,
            this.Column2,
            this.Column3});
            this.MonitorDataGridView.Location = new System.Drawing.Point(12, 225);
            this.MonitorDataGridView.Name = "MonitorDataGridView";
            this.MonitorDataGridView.RowHeadersWidth = 51;
            this.MonitorDataGridView.RowTemplate.Height = 29;
            this.MonitorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MonitorDataGridView.Size = new System.Drawing.Size(1278, 589);
            this.MonitorDataGridView.TabIndex = 27;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Monitor Name";
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
            this.Column2.HeaderText = "Monitor Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 127;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Monitor Image";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 826);
            this.Controls.Add(this.MonitorDataGridView);
            this.Controls.Add(this.cartPhoto);
            this.Controls.Add(this.MonitorFormDescription);
            this.Controls.Add(this.MonitorFormTitleLabel);
            this.Controls.Add(this.MonitorFormBackground);
            this.Controls.Add(this.menuStrip);
            this.Name = "MonitorForm";
            this.Text = "MonitorForm";
            this.Load += new System.EventHandler(this.MonitorForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MonitorForm_Paint);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorFormBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorDataGridView)).EndInit();
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
        private PictureBox MonitorFormBackground;
        private Label MonitorFormTitleLabel;
        private Label MonitorFormDescription;
        private PictureBox cartPhoto;
        private DataGridView MonitorDataGridView;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Column3;
    }
}
