namespace CST4708_Project
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }
       
        private void DesktopButton_Click(object sender, EventArgs e) //navigation to Desktop Button form
        {
            DesktopForm desktops = new DesktopForm();
            desktops.Show();
            Visible = false;
        }

        private void LaptopButton_Click(object sender, EventArgs e)
        {
            LaptopForm laptops = new LaptopForm();
            laptops.Show();
            Visible = false;

        }

        private void PeripheralButton_Click(object sender, EventArgs e)
        {
            PeripheralForm peripherals = new PeripheralForm();
            peripherals.Show();
            Visible = false;
        }

        private void MonitorButton_Click(object sender, EventArgs e)
        {
            MonitorForm monitors = new MonitorForm();
            monitors.Show();
            Visible = false;
        }
    }
}
