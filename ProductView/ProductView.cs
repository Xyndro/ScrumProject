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
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            ProductViewLabel.Parent = ProductViewBackground;
            ProductViewLabel.BackColor = Color.Transparent;

            ProductViewSKU.Parent = ProductViewBackground;
            ProductViewSKU.BackColor = Color.Transparent;

            ProductViewName.Parent = ProductViewBackground;
            ProductViewName.BackColor = Color.Transparent;

            ProductViewManufacturer.Parent = ProductViewBackground;
            ProductViewManufacturer.BackColor = Color.Transparent;

            ProductViewCPU.Parent = ProductViewBackground;
            ProductViewCPU.BackColor = Color.Transparent;

            ProductViewStorage.Parent = ProductViewBackground;
            ProductViewStorage.BackColor = Color.Transparent;

            ProductViewPrice.Parent = ProductViewBackground;
            ProductViewPrice.BackColor = Color.Transparent;

            ProductViewDescription.Parent = ProductViewBackground;
            ProductViewDescription.BackColor = Color.Transparent;

            NameLabel.Parent = ProductViewBackground;
            NameLabel.BackColor = Color.Transparent;

            SKULabel.Parent = ProductViewBackground;
            SKULabel.BackColor = Color.Transparent;

            ManufacturerLabel.Parent = ProductViewBackground;
            ManufacturerLabel.BackColor = Color.Transparent;

            CPULabel.Parent = ProductViewBackground;
            CPULabel.BackColor = Color.Transparent;

            StorageLabel.Parent = ProductViewBackground;
            StorageLabel.BackColor = Color.Transparent;

            DescriptionLabel.Parent = ProductViewBackground;
            DescriptionLabel.BackColor = Color.Transparent;

            LogInStatus.Parent = ProductViewBackground;
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

        private void cartPhoto_Click(object sender, EventArgs e)
        {
            CartView cart = new CartView();
            cart.Show();
            Visible = false;
        }
    }
}
