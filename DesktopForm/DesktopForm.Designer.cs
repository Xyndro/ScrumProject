namespace CST4708_Project
{
    partial class DesktopForm
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
            this.DesktopFormBackground = new System.Windows.Forms.PictureBox();
            this.DesktopFormTitleLabel = new System.Windows.Forms.Label();
            this.DesktopFormDescription = new System.Windows.Forms.Label();
            this.cartPhoto = new System.Windows.Forms.PictureBox();
            this.DesktopDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.LogInStatus = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesktopFormBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesktopDataGridView)).BeginInit();
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
            this.menuStrip.TabIndex = 4;
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
            // DesktopFormBackground
            // 
            this.DesktopFormBackground.Image = global::CST4708_Project.Properties.Resources.formBackground;
            this.DesktopFormBackground.Location = new System.Drawing.Point(0, 25);
            this.DesktopFormBackground.Name = "DesktopFormBackground";
            this.DesktopFormBackground.Size = new System.Drawing.Size(1302, 790);
            this.DesktopFormBackground.TabIndex = 5;
            this.DesktopFormBackground.TabStop = false;
            // 
            // DesktopFormTitleLabel
            // 
            this.DesktopFormTitleLabel.AutoSize = true;
            this.DesktopFormTitleLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DesktopFormTitleLabel.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.DesktopFormTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DesktopFormTitleLabel.Location = new System.Drawing.Point(438, 47);
            this.DesktopFormTitleLabel.Name = "DesktopFormTitleLabel";
            this.DesktopFormTitleLabel.Size = new System.Drawing.Size(472, 67);
            this.DesktopFormTitleLabel.TabIndex = 9;
            this.DesktopFormTitleLabel.Text = "Desktop Selection";
            // 
            // DesktopFormDescription
            // 
            this.DesktopFormDescription.AutoSize = true;
            this.DesktopFormDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DesktopFormDescription.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.DesktopFormDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DesktopFormDescription.Location = new System.Drawing.Point(391, 147);
            this.DesktopFormDescription.Name = "DesktopFormDescription";
            this.DesktopFormDescription.Size = new System.Drawing.Size(553, 34);
            this.DesktopFormDescription.TabIndex = 10;
            this.DesktopFormDescription.Text = "View our inventory of desktop products here!";
            // 
            // cartPhoto
            // 
            this.cartPhoto.Image = global::CST4708_Project.Properties.Resources.cartPhoto;
            this.cartPhoto.Location = new System.Drawing.Point(1165, 47);
            this.cartPhoto.Name = "cartPhoto";
            this.cartPhoto.Size = new System.Drawing.Size(125, 96);
            this.cartPhoto.TabIndex = 25;
            this.cartPhoto.TabStop = false;
            this.cartPhoto.Click += new System.EventHandler(this.cartPhoto_Click);
            // 
            // DesktopDataGridView
            // 
            this.DesktopDataGridView.AllowUserToAddRows = false;
            this.DesktopDataGridView.AllowUserToResizeColumns = false;
            this.DesktopDataGridView.AllowUserToResizeRows = false;
            this.DesktopDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DesktopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DesktopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column6,
            this.Column2,
            this.Column3});
            this.DesktopDataGridView.Location = new System.Drawing.Point(12, 211);
            this.DesktopDataGridView.Name = "DesktopDataGridView";
            this.DesktopDataGridView.RowHeadersWidth = 51;
            this.DesktopDataGridView.RowTemplate.Height = 29;
            this.DesktopDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DesktopDataGridView.Size = new System.Drawing.Size(1278, 589);
            this.DesktopDataGridView.TabIndex = 26;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Desktop Name";
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
            this.Column2.HeaderText = "Desktop Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 129;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Desktop Image";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // LogInStatus
            // 
            this.LogInStatus.AutoSize = true;
            this.LogInStatus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInStatus.Location = new System.Drawing.Point(12, 38);
            this.LogInStatus.Name = "LogInStatus";
            this.LogInStatus.Size = new System.Drawing.Size(232, 33);
            this.LogInStatus.TabIndex = 32;
            this.LogInStatus.Text = "Logged In As Guest";
            this.LogInStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 812);
            this.Controls.Add(this.LogInStatus);
            this.Controls.Add(this.DesktopDataGridView);
            this.Controls.Add(this.cartPhoto);
            this.Controls.Add(this.DesktopFormDescription);
            this.Controls.Add(this.DesktopFormTitleLabel);
            this.Controls.Add(this.DesktopFormBackground);
            this.Controls.Add(this.menuStrip);
            this.Name = "DesktopForm";
            this.Text = "DesktopForm";
            this.Load += new System.EventHandler(this.DesktopForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesktopFormBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesktopDataGridView)).EndInit();
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
        private PictureBox DesktopFormBackground;
        private Label DesktopFormTitleLabel;
        private Label DesktopFormDescription;
        private PictureBox cartPhoto;
        private DataGridView DesktopDataGridView;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Column3;
        private Label LogInStatus;
    }
}
