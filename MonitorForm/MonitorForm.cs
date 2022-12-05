using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST4708_Project
{
    public partial class MonitorForm : Form
    {

        SqlConnection myConn;
        SqlCommand myCmd;
        SqlDataReader myDataReader;

        public MonitorForm()
        {
            InitializeComponent();
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            MonitorFormTitleLabel.Parent = MonitorFormBackground;
            MonitorFormTitleLabel.BackColor = Color.Transparent;

            MonitorFormDescription.Parent = MonitorFormBackground;
            MonitorFormDescription.BackColor = Color.Transparent;

            LogInStatus.Parent = MonitorFormBackground;
            LogInStatus.BackColor = Color.Transparent;

            fillMonitorGridView();
        }

        public void fillMonitorGridView()
        {
            MonitorDataGridView.Rows.Clear();
            myConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\xyndr\\source\\repos\\CST4708_Project\\CST4708_Database.mdf;Integrated Security=True;Connect Timeout=30");
            myConn.Open();

            myCmd = new SqlCommand("Select * from Monitor", myConn);
            myDataReader = myCmd.ExecuteReader();

            while (myDataReader.Read())
            {
                MonitorDataGridView.Rows.Add(myDataReader["MonitorName"].ToString(), myDataReader["MonitorManufacturer"].ToString(),
                                             myDataReader["MonitorPrice"].ToString(), myDataReader["MonitorImage"]);
            }

            myDataReader.Close();
            myConn.Close();

            //stretches dataGridView for spacing between one item to the next
            for (int i = 0; i < MonitorDataGridView.Rows.Count; i++)
            {
                DataGridViewRow dgvr = MonitorDataGridView.Rows[i];
                dgvr.Height = 50;
            }
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

        private void cartPhoto_Click(object sender, EventArgs e)
        {
            CartView cart = new CartView();
            cart.Show();
            Visible = false;
        }
    }
}
