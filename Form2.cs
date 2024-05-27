using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAPINIG_MYPROJECT
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "APCDB.accdb")}";


        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard a = new Dashboard();
            this.Hide();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddEmployee a = new AddEmployee();
            this.Hide();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report a = new Report();
            this.Hide();
            a.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // Establish connection
                myConn = new OleDbConnection(connectionString);

                // Create a data adapter to count the number of rows in the EmployeeQuery table
                da = new OleDbDataAdapter("SELECT COUNT(*) FROM EmployeeQuery", myConn);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "EmployeeCount");
                myConn.Close();

                // Retrieve the count from the DataSet
                int employeeCount = Convert.ToInt32(ds.Tables["EmployeeCount"].Rows[0][0]);

                // Display the count in the label
                lblEmployeeCount.Text = "Total Employees: " + employeeCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
