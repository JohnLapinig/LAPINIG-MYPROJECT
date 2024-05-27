using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAPINIG_MYPROJECT
{
    public partial class Report : Form
    {
        string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "APCDB.accdb")}";



        int paidEmployeeCount = 0; // Counter variable to track paid employees
        HashSet<int> paidEmployees = new HashSet<int>(); // HashSet to store paid employee IDs
        public Report()
        {
            InitializeComponent();
            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(DataGridView_DataError);
        }

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection(connectionString);
            da = new OleDbDataAdapter("SELECT * FROM PayslipInformationQuery ORDER BY EmployeeID ASC", myConn); // Adding ORDER BY EmployeeID ASC
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "PayslipInformationQuery");
            dataGridView1.DataSource = ds.Tables["PayslipInformationQuery"];

            // Set the formatting for the HourlyRate, Daily Rate, IncomeTax, and NetPay columns to display two decimal places
            dataGridView1.Columns["HourlyRate"].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns["DailyRate"].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns["GrossPay"].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns["IncomeTax"].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns["NetPay"].DefaultCellStyle.Format = "0.00";

            myConn.Close();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Update the textboxes with the data of the selected employee
                    tbxID.Text = row.Cells["EmployeeID"].Value.ToString();
                    tbxName.Text = row.Cells["EmployeeName"].Value.ToString();
                    tbxRate.Text = Convert.ToDouble(row.Cells["HourlyRate"].Value).ToString("0.00");
                    tbxHours.Text = row.Cells["HoursWorked"].Value.ToString();
                    tbxGross.Text = Convert.ToDouble(row.Cells["DailyRate"].Value).ToString("0.00");
                    tbxDaily.Text = Convert.ToDouble(row.Cells["GrossPay"].Value).ToString("0.00");
                    tbxTax.Text = Convert.ToDouble(row.Cells["IncomeTax"].Value).ToString("0.00");
                    tbxNet.Text = Convert.ToDouble(row.Cells["NetPay"].Value).ToString("0.00");

                    // Update the DateTimePicker values
                    if (DateTime.TryParse(row.Cells["FirstHalfPay"].Value.ToString(), out DateTime firstHalfPay))
                    {
                        dtp1.Value = firstHalfPay;
                    }
                    else
                    {
                        // Handle invalid date format if necessary
                    }

                    if (DateTime.TryParse(row.Cells["SecondHalfPay"].Value.ToString(), out DateTime secondHalfPay))
                    {
                        dtp2.Value = secondHalfPay;
                    }
                    else
                    {
                        // Handle invalid date format if necessary
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Suppress the default error dialog
            e.ThrowException = false;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowPaidPayslipsForEachEmployee();

            // After displaying the payslip information, export it to Excel
            ExportToExcel(GetPayslipInfo());
        }

        private string GetPayslipInfo()
        {
            // Get the selected employee's information
            string employeeName = tbxName.Text; // Or you can retrieve it from the DataGridView directly
            double grossPay = double.Parse(tbxDaily.Text);
            double tax = double.Parse(tbxTax.Text);
            double netPay = double.Parse(tbxNet.Text);
            double totalnetPay = (grossPay - tax) * 2;
            DateTime firstHalfPay = dtp1.Value.Date;
            DateTime secondHalfPay = dtp2.Value.Date;


            // Construct the payslip information string
            string payslipInfo = $"Employee Name: {employeeName}\n" +
                                 $"Gross Pay: ₱{grossPay.ToString("0.00")}\n" +
                                 $"Income Tax: ₱{tax.ToString("0.00")}\n" +
                                 $"Net Pay: ₱{netPay.ToString("0.00")}\n" +
                                 $"Total Net Pay: ₱{totalnetPay.ToString("0.00")}\n" +
                                 $"Pay Period:\n" +
                                 $"Mid-Month Pay: {firstHalfPay.ToString("dd/MM/yyyy")}\n" +
                                 $"End-Month Pay: {secondHalfPay.ToString("dd/MM/yyyy")}";

            return payslipInfo;
        }

        private void ShowPaidPayslipsForEachEmployee()
        {
            // Ensure a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Get the selected employee's information
                string employeeName = tbxName.Text; // Or you can retrieve it from the DataGridView directly
                double hourlyRate = double.Parse(tbxRate.Text);
                double hoursWorked = double.Parse(tbxHours.Text);
                double dailyPay = double.Parse(tbxGross.Text);

                // Perform calculations (gross pay, tax, net pay)
                double grossPay = dailyPay * 10;
                double taxRate = 0.15; // Assuming a 15% tax rate
                double tax = grossPay * taxRate;
                double netPay = grossPay - tax;
                double totalnetPay = (grossPay - tax) * 2;

                DateTime firstHalfPay = dtp1.Value.Date; // Get the value of dtp1
                DateTime secondHalfPay = dtp2.Value.Date; // Get the value of dtp2

                // Display payslip information
                string payslipInfo = $"Employee Name: {employeeName}\n" +
                                     $"Gross Pay: ₱{grossPay.ToString("0.00")}\n" +
                                     $"Income Tax: ₱{tax.ToString("0.00")}\n" +
                                     $"Net Pay: ₱{netPay.ToString("0.00")}\n" +
                                     $"Total Net Pay: ₱{totalnetPay.ToString("0.00")}\n" +
                                     $"Pay Period:\n" +
                                     $"Mid-Month Pay: {firstHalfPay.ToString("dd/MM/yyyy")}\n" +
                                     $"End-Month Pay: {secondHalfPay.ToString("dd/MM/yyyy")}";

                MessageBox.Show(payslipInfo, "Payslip Information");
            }
            else
            {
                MessageBox.Show("Please select an employee from the list.");
            }
        }

        private void btnUpdateFirstHalfPay_Click(object sender, EventArgs e)
        {
            UpdateFirstHalfPay();
        }

        private void btnUpdateSecondHalfPay_Click(object sender, EventArgs e)
        {
            UpdateSecondHalfPay();
        }

        private void UpdateFirstHalfPay()
        {
            if (!string.IsNullOrEmpty(tbxID.Text))
            {
                string query = "UPDATE PayslipInformationQuery SET FirstHalfPay=? WHERE EmployeeID=?";

                cmd = new OleDbCommand(query, myConn);

                cmd.Parameters.AddWithValue("?", dtp1.Value.Date); // Use Date property to get only the date
                cmd.Parameters.AddWithValue("?", Convert.ToInt32(tbxID.Text));

                ExecuteUpdateCommand(query);
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
        }

        private void UpdateSecondHalfPay()
        {
            if (!string.IsNullOrEmpty(tbxID.Text))
            {
                string query = "UPDATE PayslipInformationQuery SET SecondHalfPay=? WHERE EmployeeID=?";

                cmd = new OleDbCommand(query, myConn);

                cmd.Parameters.AddWithValue("?", dtp2.Value.Date); // Use Date property to get only the date
                cmd.Parameters.AddWithValue("?", Convert.ToInt32(tbxID.Text));

                ExecuteUpdateCommand(query);
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
        }

        private void ExecuteUpdateCommand(string query)
        {
            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();

                // Update the corresponding row in the DataGridView
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                if (query.Contains("FirstHalfPay"))
                {
                    row.Cells["FirstHalfPay"].Value = dtp1.Value.Date.ToString("MM/dd/yyyy"); // Format the date
                }
                else if (query.Contains("SecondHalfPay"))
                {
                    row.Cells["SecondHalfPay"].Value = dtp2.Value.Date.ToString("MM/dd/yyyy"); // Format the date
                }

                MessageBox.Show("Data Updated Successfully");
                btnLoadData_Click(null, null); // Call btnLoadData_Click without passing sender and e
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

        private void btnGenerateFirstHalfPayslip_Click(object sender, EventArgs e)
        {
                GeneratePayslipForPeriod("FirstHalfPay", true);
        }

        private void btnGenerateSecondHalfPayslip_Click(object sender, EventArgs e)
        {
            GeneratePayslipForPeriod("SecondHalfPay", true);
        }


        private void GeneratePayslipForPeriod(string period, bool exportToExcel)
        {
            // Ensure a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int employeeID = Convert.ToInt32(tbxID.Text);

                // Check if the employee has already been paid
                if (paidEmployees.Contains(employeeID))
                {
                    MessageBox.Show("This employee has already been paid.", "Duplicate Payment");
                }
                else
                {
                    // Get the selected employee's information
                    string employeeName = tbxName.Text; // Or you can retrieve it from the DataGridView directly
                    double hourlyRate = double.Parse(tbxRate.Text);
                    double hoursWorked = double.Parse(tbxHours.Text);
                    double dailyPay = double.Parse(tbxGross.Text);

                    // Perform calculations (gross pay, tax, net pay)
                    double grossPay = dailyPay * 10;
                    double taxRate = 0.15; // Assuming a 15% tax rate
                    double tax = grossPay * taxRate;
                    double netPay = grossPay - tax;

                    DateTime payPeriod;

                    if (period == "FirstHalfPay")
                    {
                        payPeriod = dtp1.Value.Date; // Get the value of dtp1 for the first half pay period
                    }
                    else // Assuming it's for the second half pay period
                    {
                        payPeriod = dtp2.Value.Date; // Get the value of dtp2 for the second half pay period
                    }

                    // Display payslip information
                    string payslipInfo = $"Employee Name: {employeeName}\n" +
                                         $"Gross Pay: ₱{grossPay.ToString("0.00")}\n" +
                                         $"Income Tax: ₱{tax.ToString("0.00")}\n" +
                                         $"Net Pay: ₱{netPay.ToString("0.00")}\n" +
                                         $"Pay Period: {period} - {payPeriod.ToString("dd/MM/yyyy")}";

                    MessageBox.Show(payslipInfo, "Payslip Information");

                    // Export to Excel if specified
                    if (exportToExcel)
                    {
                        ExportToExcel(payslipInfo);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee from the list.");
            }
        }


        private void ExportToExcel(string payslipInfo)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Create Excel package
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            // Add a worksheet
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Payslip");

                            // Add title
                            ExcelRange titleRange = worksheet.Cells["A1"];
                            titleRange.Value = "PAYSLIP";
                            titleRange.Style.Font.Bold = true;
                            titleRange.Style.Font.Size = 20;
                            titleRange.Style.Font.Color.SetColor(Color.Blue);
                            titleRange.Style.Font.Name = "Century Gothic";


                            // Split the payslip info by newline
                            string[] lines = payslipInfo.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                            // Write payslip information to Excel
                            int row = 3; // Start from row 3
                            foreach (string line in lines)
                            {
                                worksheet.Cells[row, 1].Value = line;
                                row++;
                            }

                            // Save the Excel file to the user-selected location
                            excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));

                            MessageBox.Show("Payslip exported to Excel successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
        }


        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                // Establish connection
                myConn = new OleDbConnection(connectionString);

                // Create a data adapter to count the number of rows in the PayslipInformationQuery table where both FirstHalfPay and SecondHalfPay are not null
                da = new OleDbDataAdapter("SELECT COUNT(*) FROM PayslipInformationQuery WHERE FirstHalfPay IS NOT NULL AND SecondHalfPay IS NOT NULL", myConn);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "PaidEmployeeCount");
                myConn.Close();

                // Retrieve the count from the DataSet
                int paidEmployeeCount = Convert.ToInt32(ds.Tables["PaidEmployeeCount"].Rows[0][0]);

                // Display the count in the label
                lblPaid.Text = "Paid Employees: " + paidEmployeeCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
