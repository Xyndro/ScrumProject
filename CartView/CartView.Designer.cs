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
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProceedToCheckoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogInStatus = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartViewBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
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
            this.CartViewBackground.Size = new System.Drawing.Size(1269, 722);
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
            this.CartViewCartLabel.Location = new System.Drawing.Point(456, 60);
            this.CartViewCartLabel.Name = "CartViewCartLabel";
            this.CartViewCartLabel.Size = new System.Drawing.Size(350, 67);
            this.CartViewCartLabel.TabIndex = 14;
            this.CartViewCartLabel.Text = "Current Cart";
            // 
            // cartPhoto
            // 
            this.cartPhoto.Image = global::CST4708_Project.Properties.Resources.cartPhoto;
            this.cartPhoto.Location = new System.Drawing.Point(1097, 41);
            this.cartPhoto.Name = "cartPhoto";
            this.cartPhoto.Size = new System.Drawing.Size(125, 96);
            this.cartPhoto.TabIndex = 23;
            this.cartPhoto.TabStop = false;
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.AllowUserToAddRows = false;
            this.CartDataGridView.AllowUserToResizeColumns = false;
            this.CartDataGridView.AllowUserToResizeRows = false;
            this.CartDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column2,
            this.Column3});
            this.CartDataGridView.Location = new System.Drawing.Point(128, 156);
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.RowHeadersWidth = 51;
            this.CartDataGridView.RowTemplate.Height = 29;
            this.CartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGridView.Size = new System.Drawing.Size(1008, 493);
            this.CartDataGridView.TabIndex = 27;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Item Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
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
            // ProceedToCheckoutButton
            // 
            this.ProceedToCheckoutButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProceedToCheckoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProceedToCheckoutButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ProceedToCheckoutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProceedToCheckoutButton.Location = new System.Drawing.Point(523, 676);
            this.ProceedToCheckoutButton.Name = "ProceedToCheckoutButton";
            this.ProceedToCheckoutButton.Size = new System.Drawing.Size(196, 39);
            this.ProceedToCheckoutButton.TabIndex = 28;
            this.ProceedToCheckoutButton.Text = "Proceed To Checkout";
            this.ProceedToCheckoutButton.UseVisualStyleBackColor = false;
            this.ProceedToCheckoutButton.Click += new System.EventHandler(this.ProceedToCheckoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            // 
            // LogInStatus
            // 
            this.LogInStatus.AutoSize = true;
            this.LogInStatus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInStatus.Location = new System.Drawing.Point(0, 28);
            this.LogInStatus.Name = "LogInStatus";
            this.LogInStatus.Size = new System.Drawing.Size(232, 33);
            this.LogInStatus.TabIndex = 30;
            this.LogInStatus.Text = "Logged In As Guest";
            this.LogInStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 740);
            this.Controls.Add(this.LogInStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProceedToCheckoutButton);
            this.Controls.Add(this.CartDataGridView);
            this.Controls.Add(this.cartPhoto);
            this.Controls.Add(this.CartViewCartLabel);
            this.Controls.Add(this.CartViewBackground);
            this.Controls.Add(this.menuStrip);
            this.Name = "CartView";
            this.Text = "CartView";
            this.Load += new System.EventHandler(this.CartView_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartViewBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
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
        private DataGridView CartDataGridView;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Column3;
        private Button ProceedToCheckoutButton;
        private Label label1;
        private Label LogInStatus;
    }
}
