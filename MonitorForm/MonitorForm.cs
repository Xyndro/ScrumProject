using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST4708_Project
{
    public partial class MonitorForm : Form
    {
        public MonitorForm()
        {
            InitializeComponent();
        }

        //MonitorFormBackground -> creates our symbol on the picture box using graphics object
        //Graphic located at top left of form under menu strip
        private void MonitorForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            graphic.FillRectangle(orangeBrush, 20, 20, 90, 80);
            graphic.FillRectangle(blueBrush, 39, 40, 52, 40);
        }

        //method for navigation
        private void homeToolStrip_Click(object sender, EventArgs e)
        {
            LandingForm home = new LandingForm();
            home.Show();
            Visible = false;
        }

        private void desktopToolStrip_Click(object sender, EventArgs e)
        {
            DesktopForm desktop = new DesktopForm();
            desktop.Show();
            Visible = false;
        }

        private void laptopToolStrip_Click(object sender, EventArgs e)
        {
            LaptopForm laptop = new LaptopForm();
            laptop.Show();
            Visible = false;
        }

        private void monitorToolStrip_Click(object sender, EventArgs e)
        {
            MonitorForm monitor = new MonitorForm();
            monitor.Show();
            Visible = false;
        }

        private void peripheralToolStrip_Click(object sender, EventArgs e)
        {
            PeripheralForm peripheral = new PeripheralForm();
            peripheral.Show();
            Visible = false;
        }

        private void logInToolStrip_Click(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            logIn.Show();
            Visible = false;
        }
    }
}
