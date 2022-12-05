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
    public partial class CartView : Form
    {
        public CartView()
        {
            InitializeComponent();
        }

        private void CartView_Load(object sender, EventArgs e)
        {
            CartViewCartLabel.Parent = CartViewBackground;
            CartViewCartLabel.BackColor = Color.Transparent;

            LogInStatus.Parent = CartViewBackground;
            LogInStatus.BackColor = Color.Transparent;
        }

        //navigation methods
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

        private void ProceedToCheckoutButton_Click(object sender, EventArgs e)
        {
            BillingAndAddressingForm billingAddressing = new BillingAndAddressingForm();
            billingAddressing.Show();
            Visible = false;
        }
    }
}
