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
            this.cartPhoto = new System.Windows.Forms.PictureBox();
            this.PeripheralDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.LogInStatus = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeripheralFormBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeripheralDataGridView)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(1295, 28);
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
            this.PeripheralFormBackground.Size = new System.Drawing.Size(1310, 794);
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
            this.PeripheralFormDescription.Location = new System.Drawing.Point(383, 159);
            this.PeripheralFormDescription.Name = "PeripheralFormDescription";
            this.PeripheralFormDescription.Size = new System.Drawing.Size(540, 33);
            this.PeripheralFormDescription.TabIndex = 21;
            this.PeripheralFormDescription.Text = "Check out our peripherals to go with your tech!";
            // 
            // cartPhoto
            // 
            this.cartPhoto.Image = global::CST4708_Project.Properties.Resources.cartPhoto;
            this.cartPhoto.Location = new System.Drawing.Point(1155, 40);
            this.cartPhoto.Name = "cartPhoto";
            this.cartPhoto.Size = new System.Drawing.Size(125, 96);
            this.cartPhoto.TabIndex = 26;
            this.cartPhoto.TabStop = false;
            this.cartPhoto.Click += new System.EventHandler(this.cartPhoto_Click);
            // 
            // PeripheralDataGridView
            // 
            this.PeripheralDataGridView.AllowUserToAddRows = false;
            this.PeripheralDataGridView.AllowUserToResizeColumns = false;
            this.PeripheralDataGridView.AllowUserToResizeRows = false;
            this.PeripheralDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.PeripheralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeripheralDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column2,
            this.Column3});
            this.PeripheralDataGridView.Location = new System.Drawing.Point(12, 211);
            this.PeripheralDataGridView.Name = "PeripheralDataGridView";
            this.PeripheralDataGridView.RowHeadersWidth = 51;
            this.PeripheralDataGridView.RowTemplate.Height = 29;
            this.PeripheralDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PeripheralDataGridView.Size = new System.Drawing.Size(1278, 589);
            this.PeripheralDataGridView.TabIndex = 27;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Peripheral Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Peripheral Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 128;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Peripheral Image";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // LogInStatus
            // 
            this.LogInStatus.AutoSize = true;
            this.LogInStatus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInStatus.Location = new System.Drawing.Point(0, 28);
            this.LogInStatus.Name = "LogInStatus";
            this.LogInStatus.Size = new System.Drawing.Size(232, 33);
            this.LogInStatus.TabIndex = 31;
            this.LogInStatus.Text = "Logged In As Guest";
            this.LogInStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeripheralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 812);
            this.Controls.Add(this.LogInStatus);
            this.Controls.Add(this.PeripheralDataGridView);
            this.Controls.Add(this.cartPhoto);
            this.Controls.Add(this.PeripheralFormDescription);
            this.Controls.Add(this.PeripheralFormTitleLabel);
            this.Controls.Add(this.PeripheralFormBackground);
            this.Controls.Add(this.menuStrip);
            this.Name = "PeripheralForm";
            this.Text = "PeripheralForm";
            this.Load += new System.EventHandler(this.PeripheralForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeripheralFormBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeripheralDataGridView)).EndInit();
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
        private PictureBox cartPhoto;
        private DataGridView PeripheralDataGridView;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Column3;
        private Label LogInStatus;
    }
}
