using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST4708_Project
{
    public partial class LaptopForm : Form
    {
        SqlConnection myConn;
        SqlCommand myCmd;
        SqlDataReader myDataReader;


        public LaptopForm()
        {
            InitializeComponent();
        }

        private void LaptopForm_Load(object sender, EventArgs e)
        {
            LaptopFormTitleLabel.Parent = LaptopFormBackground;
            LaptopFormTitleLabel.BackColor = Color.Transparent;

            fillLaptopDataGridView();
        }

        public void fillLaptopDataGridView()
        {
            LaptopDataGridView.Rows.Clear();
            myConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\xyndr\\source\\repos\\CST4708_Project\\CST4708_Database.mdf;Integrated Security=True;Connect Timeout=30");
            myConn.Open();

            myCmd = new SqlCommand("Select * from Laptop", myConn);
            myDataReader = myCmd.ExecuteReader();

            while (myDataReader.Read())
            {
                LaptopDataGridView.Rows.Add(myDataReader["LaptopName"].ToString(), myDataReader["LaptopManufacturer"].ToString(),
                                             myDataReader["LaptopPrice"].ToString(), myDataReader["LaptopImage"]);
            }

            myDataReader.Close();
            myConn.Close();

            //stretches dataGridView for spacing between one item to the next
            for (int i = 0; i < LaptopDataGridView.Rows.Count; i++)
            {
                DataGridViewRow dgvr = LaptopDataGridView.Rows[i];
                dgvr.Height = 50;
            }
        }

        private void LaptopForm_Paint(object sender, PaintEventArgs e)
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
