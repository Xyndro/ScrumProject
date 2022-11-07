namespace CST4708_Project
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }
       
        private void DesktopButton_Click(object sender, EventArgs e) //navigation to Desktop Form
        {
            DesktopForm desktops = new DesktopForm();
            desktops.Show();
            Visible = false;
        }

        private void LaptopButton_Click(object sender, EventArgs e) //navigation to Laptop Form
        {
            LaptopForm laptops = new LaptopForm();
            laptops.Show();
            Visible = false;

        }

        private void PeripheralButton_Click(object sender, EventArgs e) //navigation to Peripheral Form
        {
            PeripheralForm peripherals = new PeripheralForm();
            peripherals.Show();
            Visible = false;
        }

        private void MonitorButton_Click(object sender, EventArgs e) //navigation to Monitor Form
        {
            MonitorForm monitors = new MonitorForm();
            monitors.Show();
            Visible = false;
        }

        private void LandingForm_Paint(object sender, PaintEventArgs e)  //LandingForm_Paint -> creates our symbol in the form using graphics object
        {
            Graphics graphic = e.Graphics;
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            graphic.FillRectangle(orangeBrush, 30, 50, 120, 90);
            graphic.FillRectangle(blueBrush, 50, 70, 81, 50);

        }
    }
}
