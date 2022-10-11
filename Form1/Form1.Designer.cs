namespace CST4708_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.PeripheralButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DesktopButton
            // 
            this.DesktopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DesktopButton.Location = new System.Drawing.Point(843, 62);
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
            this.LaptopButton.Location = new System.Drawing.Point(843, 184);
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
            this.MonitorButton.Location = new System.Drawing.Point(843, 306);
            this.MonitorButton.Name = "MonitorButton";
            this.MonitorButton.Size = new System.Drawing.Size(245, 116);
            this.MonitorButton.TabIndex = 2;
            this.MonitorButton.Text = "Monitors";
            this.MonitorButton.UseVisualStyleBackColor = true;
            this.MonitorButton.Click += new System.EventHandler(this.MonitorButton_Click);
            // 
            // Featured Products Label
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "FeaturedProductsLabel";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Featured Products";
            // 
            // PeripheralButton
            // 
            this.PeripheralButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeripheralButton.Location = new System.Drawing.Point(843, 428);
            this.PeripheralButton.Name = "PeripheralButton";
            this.PeripheralButton.Size = new System.Drawing.Size(245, 116);
            this.PeripheralButton.TabIndex = 4;
            this.PeripheralButton.Text = "Peripherals";
            this.PeripheralButton.UseVisualStyleBackColor = true;
            this.PeripheralButton.Click += new System.EventHandler(this.PeripheralButton_Click);
            // 
            // Form1 -> Landing Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 633);
            this.Controls.Add(this.PeripheralButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonitorButton);
            this.Controls.Add(this.LaptopButton);
            this.Controls.Add(this.DesktopButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DesktopButton;
        private Button LaptopButton;
        private Button MonitorButton;
        private Label label1;
        private Button PeripheralButton;
    }
}
