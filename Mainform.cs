using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LAPINIG_MYPROJECT
{
    public partial class Mainform : Form
    {

        public Mainform()
        {
            InitializeComponent();
        }

        string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "APCDB.accdb")}";


        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                string rateInput = tbxRate.Text;
                double rate = double.Parse(rateInput);

                string hoursInput = tbxHours.Text;
                double hours = double.Parse(hoursInput);

                // Calculate daily pay
                double dailyPay = rate * hours;
                tbxGross.Text = "₱" + dailyPay.ToString("0.00"); // Ensure at least two decimal places

                // Calculate gross pay (daily pay * 10)
                double grossPay = dailyPay * 10;

                // Calculate tax (15% of tbxDaily)
                double taxRate = 0.15;
                double tax = grossPay * taxRate;
                tbxTax.Text = "₱" + tax.ToString("0.00"); // Ensure at least two decimal places

                // Calculate net pay (gross pay - tax)
                double netPay = grossPay - tax;
                tbxNet.Text = "₱" + netPay.ToString("0.00"); // Ensure at least two decimal places

                // Set tbxDaily to grossPay (already calculated)
                tbxDaily.Text = "₱" + grossPay.ToString("0.00"); // Ensure at least two decimal places
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values for hourly rate and hours worked.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Update the textboxes with the data of the selected employee
                    tbxID.Text = row.Cells["EmployeeID"].Value.ToString();
                    tbxName.Text = row.Cells["EmployeeName"].Value.ToString();
                    tbxAge.Text = row.Cells["Age"].Value.ToString();
                    tbxAddress.Text = row.Cells["Address"].Value.ToString();
                    tbxGender.Text = row.Cells["Gender"].Value.ToString();
                    cmbDepartment.Text = row.Cells["Department"].Value.ToString();
                    cmbPosition.Text = row.Cells["EmpPosition"].Value.ToString();
                    tbxRate.Text = Convert.ToDouble(row.Cells["HourlyRate"].Value).ToString("0.00");
                    tbxHours.Text = row.Cells["HoursWorked"].Value.ToString();
                    tbxGross.Text = Convert.ToDouble(row.Cells["DailyRate"].Value).ToString("0.00");
                    tbxDaily.Text = Convert.ToDouble(row.Cells["GrossPay"].Value).ToString("0.00");
                    tbxTax.Text = Convert.ToDouble(row.Cells["IncomeTax"].Value).ToString("0.00");
                    tbxNet.Text = Convert.ToDouble(row.Cells["NetPay"].Value).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConnectionTest_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection(connectionString);
            ds = new DataSet();
            myConn.Open();
            MessageBox.Show("Connection Successfully!");
            myConn.Close();
        }
        
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection(connectionString);
            da = new OleDbDataAdapter("SELECT * FROM EmployeeQuery ORDER BY EmployeeID ASC", myConn); // Adding ORDER BY EmployeeID ASC
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "EmployeeQuery");
            dataGridView1.DataSource = ds.Tables["EmployeeQuery"];

            // Set the formatting for the HourlyRate, Daily Rate, IncomeTax, and NetPay columns to display two decimal places
            dataGridView1.Columns["HourlyRate"].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns["DailyRate"].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns["GrossPay"].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns["IncomeTax"].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns["NetPay"].DefaultCellStyle.Format = "0.00";

            myConn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete from EmployeeInfo table
                string infoQuery = "DELETE FROM EmployeeInfo WHERE EmployeeID = @EmployeeID";

                // Delete from EmployeeCalc table
                string calcQuery = "DELETE FROM EmployeeCalc WHERE EmployeeID = @EmployeeID";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Execute delete query for EmployeeInfo table
                    using (OleDbCommand infoCommand = new OleDbCommand(infoQuery, connection))
                    {
                        infoCommand.Parameters.AddWithValue("@EmployeeID", dataGridView1.CurrentRow.Cells["EmployeeID"].Value);
                        infoCommand.ExecuteNonQuery();
                    }

                    // Execute delete query for EmployeeCalc table
                    using (OleDbCommand calcCommand = new OleDbCommand(calcQuery, connection))
                    {
                        calcCommand.Parameters.AddWithValue("@EmployeeID", dataGridView1.CurrentRow.Cells["EmployeeID"].Value);
                        calcCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Deleted Successfully!");
                    btnLoadData_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO EmployeeQuery (EmployeeName, Age, Address, Gender, Department, EmpPosition, HourlyRate, HoursWorked)" +
                   "VALUES (@EmployeeName, @Age, @Address, @Gender, @Department, @EmpPosition, @HourlyRate, @HoursWorked)";

            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeName", tbxName.Text);
                        cmd.Parameters.AddWithValue("@Age", tbxAge.Text);
                        cmd.Parameters.AddWithValue("@Address", tbxAddress.Text);
                        cmd.Parameters.AddWithValue("@Gender", tbxGender.Text);
                        cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text);
                        cmd.Parameters.AddWithValue("@EmpPosition", cmbPosition.Text);
                        cmd.Parameters.AddWithValue("@HourlyRate", tbxRate.Text);
                        cmd.Parameters.AddWithValue("@HoursWorked", tbxHours.Text);

                        // Open connection, execute query, and close connection
                        myConn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted Successfully");
                        btnLoadData_Click(sender, e); // Reload data into DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxID.Text))
            {
                string query = "UPDATE EmployeeQuery SET EmployeeName=?, Age=?, Address=?, Gender=?, Department=?, EmpPosition=?, HourlyRate=?, HoursWorked=? WHERE EmployeeID=?";
                cmd = new OleDbCommand(query, myConn);

                cmd.Parameters.AddWithValue("?", tbxName.Text);
                cmd.Parameters.AddWithValue("?", tbxAge.Text);
                cmd.Parameters.AddWithValue("?", tbxAddress.Text);
                cmd.Parameters.AddWithValue("?", tbxGender.Text);
                cmd.Parameters.AddWithValue("?", cmbDepartment.Text);
                cmd.Parameters.AddWithValue("?", cmbPosition.Text);
                cmd.Parameters.AddWithValue("?", tbxRate.Text);
                cmd.Parameters.AddWithValue("?", tbxHours.Text);
                cmd.Parameters.AddWithValue("?", Convert.ToInt32(tbxID.Text));

                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    // Update the corresponding row in the DataGridView
                    DataGridViewRow row = dataGridView1.Rows[indexRow];
                    row.Cells["EmployeeName"].Value = tbxName.Text;
                    row.Cells["Age"].Value = tbxAge.Text;
                    row.Cells["Address"].Value = tbxAddress.Text;
                    row.Cells["Gender"].Value = tbxGender.Text;
                    row.Cells["Department"].Value = cmbDepartment.Text;
                    row.Cells["EmpPosition"].Value = cmbPosition.Text;
                    row.Cells["HourlyRate"].Value = tbxRate.Text;
                    row.Cells["HoursWorked"].Value = tbxHours.Text;

                    MessageBox.Show("Data Updated Successfully");
                    btnLoadData_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (myConn.State == ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            // Ensure that there's something to search for
            if (!string.IsNullOrWhiteSpace(tbxSearch.Text))
            {
                // Get the column name you want to search in
                string columnName = "EmployeeName"; // You can change this to the appropriate column name

                // Construct the filter expression
                string filterExpression = string.Format("{0} LIKE '%{1}%'", columnName, tbxSearch.Text);

                // Apply the filter to the DataGridView
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = filterExpression;
            }
            else
            {
                // If the search box is empty, clear the filter
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text of all textboxes
            tbxID.Text = "";
            tbxName.Text = "";
            tbxAge.Text = "";
            tbxAddress.Text = "";
            tbxGender.Text = "";
            cmbDepartment.SelectedIndex = -1; // Clear selected department
            cmbPosition.SelectedIndex = -1; // Clear selected position
            tbxRate.Text = "";
            tbxHours.Text = "";
            tbxGross.Text = "";//for DailyRate
            tbxDaily.Text = "";//for GrossPay
            tbxTax.Text = "";
            tbxNet.Text = "";
        }

        private void Mainform_Load(object sender, EventArgs e)
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