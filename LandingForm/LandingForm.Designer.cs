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
            this.DesktopButton = new System.Windows.Forms.Button();
            this.LaptopButton = new System.Windows.Forms.Button();
            this.MonitorButton = new System.Windows.Forms.Button();
            this.PeripheralButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.peripheralToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DesktopButton
            // 
            this.DesktopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DesktopButton.Location = new System.Drawing.Point(28, 352);
            this.DesktopButton.Name = "DesktopButton";
            this.DesktopButton.Size = new System.Drawing.Size(245, 116);
            this.DesktopButton.TabIndex = 0;
            this.DesktopButton.Text = "Desktops";
            this.DesktopButton.UseVisualStyleBackColor = true;
            this.DesktopButton.Click += new System.EventHandler(this.DesktopButton_Click);
            // 
            // LaptopButton
            // 
            this.LaptopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaptopButton.Location = new System.Drawing.Point(332, 352);
            this.LaptopButton.Name = "LaptopButton";
            this.LaptopButton.Size = new System.Drawing.Size(245, 116);
            this.LaptopButton.TabIndex = 1;
            this.LaptopButton.Text = "Laptops";
            this.LaptopButton.UseVisualStyleBackColor = true;
            this.LaptopButton.Click += new System.EventHandler(this.LaptopButton_Click);
            // 
            // MonitorButton
            // 
            this.MonitorButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonitorButton.Location = new System.Drawing.Point(641, 352);
            this.MonitorButton.Name = "MonitorButton";
            this.MonitorButton.Size = new System.Drawing.Size(245, 116);
            this.MonitorButton.TabIndex = 2;
            this.MonitorButton.Text = "Monitors";
            this.MonitorButton.UseVisualStyleBackColor = true;
            this.MonitorButton.Click += new System.EventHandler(this.MonitorButton_Click);
            // 
            // PeripheralButton
            // 
            this.PeripheralButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeripheralButton.Location = new System.Drawing.Point(935, 352);
            this.PeripheralButton.Name = "PeripheralButton";
            this.PeripheralButton.Size = new System.Drawing.Size(245, 116);
            this.PeripheralButton.TabIndex = 4;
            this.PeripheralButton.Text = "Peripherals";
            this.PeripheralButton.UseVisualStyleBackColor = true;
            this.PeripheralButton.Click += new System.EventHandler(this.PeripheralButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStrip,
            this.peripheralToolStrip,
            this.monitorToolStrip,
            this.laptopToolStrip,
            this.desktopToolStrip,
            this.homeToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(1208, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(92, 24);
            this.aboutToolStrip.Text = "About Us";
            // 
            // peripheralToolStrip
            // 
            this.peripheralToolStrip.Name = "peripheralToolStrip";
            this.peripheralToolStrip.Size = new System.Drawing.Size(103, 24);
            this.peripheralToolStrip.Text = "Peripherals";
            // 
            // monitorToolStrip
            // 
            this.monitorToolStrip.Name = "monitorToolStrip";
            this.monitorToolStrip.Size = new System.Drawing.Size(88, 24);
            this.monitorToolStrip.Text = "Monitors";
            // 
            // laptopToolStrip
            // 
            this.laptopToolStrip.Name = "laptopToolStrip";
            this.laptopToolStrip.Size = new System.Drawing.Size(81, 24);
            this.laptopToolStrip.Text = "Laptops";
            // 
            // desktopToolStrip
            // 
            this.desktopToolStrip.Name = "desktopToolStrip";
            this.desktopToolStrip.Size = new System.Drawing.Size(90, 24);
            this.desktopToolStrip.Text = "Desktops";
            // 
            // homeToolStrip
            // 
            this.homeToolStrip.Name = "homeToolStrip";
            this.homeToolStrip.Size = new System.Drawing.Size(67, 24);
            this.homeToolStrip.Text = "Home";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1208, 668);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.PeripheralButton);
            this.Controls.Add(this.MonitorButton);
            this.Controls.Add(this.LaptopButton);
            this.Controls.Add(this.DesktopButton);
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LandingForm_Paint);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DesktopButton;
        private Button LaptopButton;
        private Button MonitorButton;
        private Button PeripheralButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem aboutToolStrip;
        private ToolStripMenuItem peripheralToolStrip;
        private ToolStripMenuItem monitorToolStrip;
        private ToolStripMenuItem laptopToolStrip;
        private ToolStripMenuItem desktopToolStrip;
        private ToolStripMenuItem homeToolStrip;
    }
}
