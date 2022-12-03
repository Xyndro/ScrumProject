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
    public partial class PeripheralForm : Form
    {

        SqlConnection myConn;
        SqlCommand myCmd;
        SqlDataReader myDataReader;

        public PeripheralForm()
        {
            InitializeComponent();
        }

        private void PeripheralForm_Load(object sender, EventArgs e)
        {
            PeripheralFormTitleLabel.Parent = PeripheralFormBackground;
            PeripheralFormTitleLabel.BackColor = Color.Transparent;

            PeripheralFormDescription.Parent = PeripheralFormBackground;
            PeripheralFormDescription.BackColor = Color.Transparent;

            fillPeripheralDataGridView();
        }

        public void fillPeripheralDataGridView()
        {
            PeripheralDataGridView.Rows.Clear();
            myConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\xyndr\\source\\repos\\CST4708_Project\\CST4708_Database.mdf;Integrated Security=True;Connect Timeout=30");
            myConn.Open();

            myCmd = new SqlCommand("Select * from Peripheral", myConn);
            myDataReader = myCmd.ExecuteReader();

            while (myDataReader.Read())
            {
                PeripheralDataGridView.Rows.Add(myDataReader["PeripheralName"].ToString(),
                                             myDataReader["PeripheralPrice"].ToString(), myDataReader["PeripheralImage"]);
            }

            myDataReader.Close();
            myConn.Close();

            //stretches dataGridView for spacing between one item to the next
            for (int i = 0; i < PeripheralDataGridView.Rows.Count; i++)
            {
                DataGridViewRow dgvr = PeripheralDataGridView.Rows[i];
                dgvr.Height = 50;
            }
        }

        private void PeripheralForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            graphic.FillRectangle(orangeBrush, 20, 20, 90, 80);
            graphic.FillRectangle(blueBrush, 39, 40, 52, 40);
        }

        //methods for navigation
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
