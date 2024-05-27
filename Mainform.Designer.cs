namespace LAPINIG_MYPROJECT
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            tbxHours = new TextBox();
            tbxRate = new TextBox();
            tbxAddress = new TextBox();
            tbxAge = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label10 = new Label();
            tbxName = new TextBox();
            tbxGender = new TextBox();
            label6 = new Label();
            tbxID = new TextBox();
            label9 = new Label();
            tbxNet = new TextBox();
            label11 = new Label();
            btnCompute = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoadData = new Button();
            tbxGross = new TextBox();
            label12 = new Label();
            tbxTax = new TextBox();
            label13 = new Label();
            btnConnectionTest = new Button();
            cmbDepartment = new ComboBox();
            cmbPosition = new ComboBox();
            label14 = new Label();
            tbxSearch = new TextBox();
            btnClear = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            tbxDaily = new TextBox();
            lblEmployeeCount = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1876, 113);
            panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.paytaw;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1563, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(145, 101);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.payroll;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(167, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(145, 101);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(353, 28);
            label3.Name = "label3";
            label3.Size = new Size(1165, 62);
            label3.TabIndex = 3;
            label3.Text = "Automated Payroll Calculator Data Base Integration";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1530, 632);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tbxHours
            // 
            tbxHours.Location = new Point(158, 438);
            tbxHours.Name = "tbxHours";
            tbxHours.Size = new Size(173, 27);
            tbxHours.TabIndex = 47;
            // 
            // tbxRate
            // 
            tbxRate.Location = new Point(158, 401);
            tbxRate.Name = "tbxRate";
            tbxRate.Size = new Size(173, 27);
            tbxRate.TabIndex = 46;
            // 
            // tbxAddress
            // 
            tbxAddress.Location = new Point(158, 247);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(173, 27);
            tbxAddress.TabIndex = 42;
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(158, 210);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(173, 27);
            tbxAge.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(9, 437);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 39;
            label8.Text = "Hours Worked\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(11, 399);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 38;
            label7.Text = "Hourly Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 362);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 36;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 326);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 35;
            label4.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 249);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 34;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 210);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 33;
            label2.Text = "Age";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(11, 170);
            label10.Name = "label10";
            label10.Size = new Size(123, 20);
            label10.TabIndex = 48;
            label10.Text = "Employee Name";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(159, 168);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(173, 27);
            tbxName.TabIndex = 49;
            // 
            // tbxGender
            // 
            tbxGender.Location = new Point(158, 285);
            tbxGender.Name = "tbxGender";
            tbxGender.Size = new Size(173, 27);
            tbxGender.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 287);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 52;
            label6.Text = "Gender";
            // 
            // tbxID
            // 
            tbxID.Location = new Point(158, 131);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(173, 27);
            tbxID.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 131);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 54;
            label9.Text = "Employee ID";
            // 
            // tbxNet
            // 
            tbxNet.Location = new Point(158, 591);
            tbxNet.Name = "tbxNet";
            tbxNet.Size = new Size(173, 27);
            tbxNet.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(11, 593);
            label11.Name = "label11";
            label11.Size = new Size(64, 20);
            label11.TabIndex = 56;
            label11.Text = "Net Pay";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.Red;
            btnCompute.FlatStyle = FlatStyle.Popup;
            btnCompute.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(11, 633);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(94, 29);
            btnCompute.TabIndex = 58;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Blue;
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnInsert.Location = new Point(11, 685);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 59;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnUpdate.Location = new Point(137, 632);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 60;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Orange;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(137, 686);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 61;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.Violet;
            btnLoadData.FlatStyle = FlatStyle.Popup;
            btnLoadData.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnLoadData.Location = new Point(13, 732);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(94, 29);
            btnLoadData.TabIndex = 62;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // tbxGross
            // 
            tbxGross.Location = new Point(158, 473);
            tbxGross.Name = "tbxGross";
            tbxGross.Size = new Size(173, 27);
            tbxGross.TabIndex = 64;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(9, 473);
            label12.Name = "label12";
            label12.Size = new Size(80, 20);
            label12.TabIndex = 63;
            label12.Text = "Daily Rate";
            // 
            // tbxTax
            // 
            tbxTax.Location = new Point(158, 553);
            tbxTax.Name = "tbxTax";
            tbxTax.Size = new Size(173, 27);
            tbxTax.TabIndex = 66;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(11, 557);
            label13.Name = "label13";
            label13.Size = new Size(136, 20);
            label13.TabIndex = 65;
            label13.Text = "Income Tax (15%)";
            // 
            // btnConnectionTest
            // 
            btnConnectionTest.BackColor = Color.Yellow;
            btnConnectionTest.FlatStyle = FlatStyle.Popup;
            btnConnectionTest.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnConnectionTest.Location = new Point(137, 732);
            btnConnectionTest.Name = "btnConnectionTest";
            btnConnectionTest.Size = new Size(130, 29);
            btnConnectionTest.TabIndex = 67;
            btnConnectionTest.Text = "Connection Test";
            btnConnectionTest.UseVisualStyleBackColor = false;
            btnConnectionTest.Click += btnConnectionTest_Click;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "HR", "IT", "FINANCE" });
            cmbDepartment.Location = new Point(158, 323);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(172, 28);
            cmbDepartment.TabIndex = 70;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "HRDirector", "HRManager", "HRAssistant", "ITDeveloper", "ITManager", "ITSupport", "Accountant", "FinanceManager", "FinancialAnalyst" });
            cmbPosition.Location = new Point(159, 362);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(172, 28);
            cmbPosition.TabIndex = 71;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.LightCoral;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(134, 870);
            label14.Name = "label14";
            label14.Size = new Size(173, 28);
            label14.TabIndex = 72;
            label14.Text = "Search Employee";
            // 
            // tbxSearch
            // 
            tbxSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.Location = new Point(330, 871);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(883, 31);
            tbxSearch.TabIndex = 73;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightBlue;
            btnClear.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(13, 769);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(255, 41);
            btnClear.TabIndex = 74;
            btnClear.Text = "Clear Info";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.Image = Properties.Resources._10758957_user_search_icon1;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(17, 847);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._105108;
            pictureBox1.Location = new Point(1, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1876, 714);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(9, 507);
            label15.Name = "label15";
            label15.Size = new Size(87, 40);
            label15.TabIndex = 76;
            label15.Text = "GrossPay\r\nx (10 days)";
            // 
            // tbxDaily
            // 
            tbxDaily.Location = new Point(158, 512);
            tbxDaily.Name = "tbxDaily";
            tbxDaily.Size = new Size(173, 27);
            tbxDaily.TabIndex = 77;
            // 
            // lblEmployeeCount
            // 
            lblEmployeeCount.AutoSize = true;
            lblEmployeeCount.BackColor = Color.FromArgb(192, 255, 255);
            lblEmployeeCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeCount.Location = new Point(344, 769);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(280, 41);
            lblEmployeeCount.TabIndex = 78;
            lblEmployeeCount.Text = "No. of Employees: ";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1870, 920);
            Controls.Add(lblEmployeeCount);
            Controls.Add(tbxDaily);
            Controls.Add(label15);
            Controls.Add(pictureBox2);
            Controls.Add(btnClear);
            Controls.Add(tbxSearch);
            Controls.Add(label14);
            Controls.Add(cmbPosition);
            Controls.Add(cmbDepartment);
            Controls.Add(btnConnectionTest);
            Controls.Add(tbxTax);
            Controls.Add(label13);
            Controls.Add(tbxGross);
            Controls.Add(label12);
            Controls.Add(btnLoadData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnCompute);
            Controls.Add(tbxNet);
            Controls.Add(label11);
            Controls.Add(tbxID);
            Controls.Add(label9);
            Controls.Add(tbxGender);
            Controls.Add(label6);
            Controls.Add(tbxName);
            Controls.Add(label10);
            Controls.Add(tbxHours);
            Controls.Add(tbxRate);
            Controls.Add(tbxAddress);
            Controls.Add(tbxAge);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainform";
            Load += Mainform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Button btnEmployee;
        private DataGridView dataGridView1;
        private TextBox tbxHours;
        private TextBox tbxRate;
        private TextBox tbxAddress;
        private TextBox tbxAge;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label10;
        private TextBox tbxName;
        private TextBox tbxGender;
        private Label label6;
        private TextBox tbxID;
        private Label label9;
        private TextBox tbxNet;
        private Label label11;
        private Button btnCompute;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoadData;
        private TextBox tbxGross;
        private Label label12;
        private TextBox tbxTax;
        private Label label13;
        private Button btnConnectionTest;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ComboBox cmbDepartment;
        private ComboBox cmbPosition;
        private Label label14;
        private TextBox tbxSearch;
        private Button btnClear;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label15;
        private TextBox tbxDaily;
        private Label lblEmployeeCount;
    }
}