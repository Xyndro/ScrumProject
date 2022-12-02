using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
namespace CST4708_Project
{
    public partial class LandingForm : Form
    {
        SqlConnection myConn;
        SqlCommand myCmd;
        SqlDataReader myDataReader;

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

            DesktopNameDisplay();
            LaptopNameDisplay();
            MonitorNameDisplay();
            PeripheralNameDisplay();

        }

        public void DesktopNameDisplay()
        {
            //sql connection to fill in label with database information
            myConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\xyndr\\source\\repos\\CST4708_Project\\CST4708_Database.mdf;Integrated Security=True;Connect Timeout=30");
            myConn.Open();
            String desktopLabelQuery = "Select DesktopName From Desktop Where DesktopName = 'XPS Desktop'";
            myCmd = new SqlCommand(desktopLabelQuery, myConn);
            myDataReader = myCmd.ExecuteReader();

            while (myDataReader.Read())
            {
                DesktopFeature.Text = myDataReader.GetValue(0).ToString();
            }
            myConn.Close();
        }

        public void LaptopNameDisplay()
        {
            //sql connection to fill in label with database information
            myConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\xyndr\\source\\repos\\CST4708_Project\\CST4708_Database.mdf;Integrated Security=True;Connect Timeout=30");
            myConn.Open();
            String laptopLabelQuery = "Select LaptopName From Laptop Where LaptopName = 'TUF Gaming Laptop'";
            myCmd = new SqlCommand(laptopLabelQuery, myConn);
            myDataReader = myCmd.ExecuteReader();

            while (myDataReader.Read())
            {
                LaptopFeature.Text = myDataReader.GetValue(0).ToString();
            }
            myConn.Close();
        }

        public void MonitorNameDisplay()
        {
            //sql connection to fill in label with database information
            myConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\xyndr\\source\\repos\\CST4708_Project\\CST4708_Database.mdf;Integrated Security=True;Connect Timeout=30");
            myConn.Open();
            String monitorLabelQuery = "Select MonitorName From Monitor Where MonitorName = 'LED FHD FreeSync HDMI Monitor'";
            myCmd = new SqlCommand(monitorLabelQuery, myConn);
            myDataReader = myCmd.ExecuteReader();

            while (myDataReader.Read())
            {
                MonitorFeature.Text = myDataReader.GetValue(0).ToString();
            }
            myConn.Close();
        }


        public void PeripheralNameDisplay()
        {
            //sql connection to fill in label with database information
            myConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\xyndr\\source\\repos\\CST4708_Project\\CST4708_Database.mdf;Integrated Security=True;Connect Timeout=30");
            myConn.Open();
            String peripheralLabelQuery = "Select PeripheralName From Peripheral Where PeripheralName = 'PULSE 3D Wireless Headset'";
            myCmd = new SqlCommand(peripheralLabelQuery, myConn);
            myDataReader = myCmd.ExecuteReader();

            while (myDataReader.Read())
            {
                PeripheralFeature.Text = myDataReader.GetValue(0).ToString();
            }
            myConn.Close();
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

        private void cartPhoto_Click(object sender, EventArgs e)
        {
            CartView cart = new CartView();
            cart.Show();
            Visible = false;
        }

        //---------------------------------------------------------------------------------------
    }
}
