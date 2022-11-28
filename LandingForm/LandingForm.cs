namespace CST4708_Project
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        //LandingForm_Load -> Upon loading, labels become transparent to blend in with background picture box
        //Spaces seperate each element on form
        private void LandingForm_Load(object sender, EventArgs e)
        {
            LandingFormTitleLabel.Parent = LandingFormBackground;
            LandingFormTitleLabel.BackColor = Color.Transparent;

            LandingFormDescription.Parent = LandingFormBackground;
            LandingFormDescription.BackColor = Color.Transparent;

            LandingFormDesktopsLabel.Parent = LandingFormBackground;
            LandingFormDesktopsLabel.BackColor = Color.Transparent;

            LandingFormLaptopsLabel.Parent = LandingFormBackground;
            LandingFormLaptopsLabel.BackColor = Color.Transparent;

            LandingFormMonitorsLabel.Parent = LandingFormBackground;
            LandingFormMonitorsLabel.BackColor = Color.Transparent;

            LandingFormPeripheralsLabel.Parent = LandingFormBackground;
            LandingFormPeripheralsLabel.BackColor = Color.Transparent;

            FeaturedDesktopNameLabel.Parent = LandingFormBackground;
            FeaturedDesktopNameLabel.BackColor = Color.Transparent;

            FeaturedLaptopNameLabel.Parent = LandingFormBackground;
            FeaturedLaptopNameLabel.BackColor = Color.Transparent;

            FeaturedMonitorNameLabel.Parent = LandingFormBackground;
            FeaturedMonitorNameLabel.BackColor = Color.Transparent;

            FeaturedPeripheralNameLabel.Parent = LandingFormBackground;
            FeaturedPeripheralNameLabel.BackColor = Color.Transparent;

        }

        //LandingFormBackground -> creates our symbol on the picture box using graphics object
        //Graphic located at top left of form under menu strip
        private void LandingFormBackground_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            graphic.FillRectangle(orangeBrush, 20, 20, 90, 80);
            graphic.FillRectangle(blueBrush, 39, 40, 52, 40);
        }


        //methods below are click events for navigation
        //---------------------------------------------------------------------------------------
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

        private void LandingFormToDesktopsButton_Click(object sender, EventArgs e)
        {
            DesktopForm desktop = new DesktopForm();
            desktop.Show();
            Visible = false;
        }

        private void LandingFormToLaptopsButton_Click(object sender, EventArgs e)
        {
            LaptopForm laptop = new LaptopForm();
            laptop.Show();
            Visible = false;
        }

        private void LandingFormToMonitorsButton_Click(object sender, EventArgs e)
        {
            MonitorForm monitor = new MonitorForm();
            monitor.Show();
            Visible = false;
        }

        private void LandingFormToPeripheralsButton_Click(object sender, EventArgs e)
        {
            PeripheralForm peripheral = new PeripheralForm();
            peripheral.Show();
            Visible = false;
        }

        //Methods to see featured products
        private void FeaturedDesktopButton_Click(object sender, EventArgs e)
        {

        }

        private void FeaturedLaptopButton_Click(object sender, EventArgs e)
        {

        }

        private void FeaturedMonitorButton_Click(object sender, EventArgs e)
        {

        }

        private void FeaturedPeripheralButton_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------------------------
    }
}
