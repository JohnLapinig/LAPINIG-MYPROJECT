namespace LAPINIG_MYPROJECT
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            panel1 = new Panel();
            lblPaid = new Label();
            tbxDaily = new TextBox();
            label21 = new Label();
            btnGenerateSecondHalfPayslip = new Button();
            btnGenerateFirstHalfPayslip = new Button();
            btnUpdateSecondHalfPay = new Button();
            btnUpdateFirstHalfPay = new Button();
            btnShow = new Button();
            dataGridView1 = new DataGridView();
            tbxID = new TextBox();
            label20 = new Label();
            tbxHours = new TextBox();
            tbxRate = new TextBox();
            label18 = new Label();
            label19 = new Label();
            dtp2 = new DateTimePicker();
            dtp1 = new DateTimePicker();
            label17 = new Label();
            label16 = new Label();
            pictureBox2 = new PictureBox();
            tbxSearch = new TextBox();
            label14 = new Label();
            tbxTax = new TextBox();
            label9 = new Label();
            tbxGross = new TextBox();
            label12 = new Label();
            tbxNet = new TextBox();
            label11 = new Label();
            tbxName = new TextBox();
            label10 = new Label();
            btnLoadData = new Button();
            panel4 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(lblPaid);
            panel1.Controls.Add(tbxDaily);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(btnGenerateSecondHalfPayslip);
            panel1.Controls.Add(btnGenerateFirstHalfPayslip);
            panel1.Controls.Add(btnUpdateSecondHalfPay);
            panel1.Controls.Add(btnUpdateFirstHalfPay);
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(tbxID);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(tbxHours);
            panel1.Controls.Add(tbxRate);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(dtp2);
            panel1.Controls.Add(dtp1);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(tbxSearch);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(tbxTax);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbxGross);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(tbxNet);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(tbxName);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnLoadData);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(67, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 743);
            panel1.TabIndex = 2;
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.BackColor = Color.FromArgb(192, 255, 255);
            lblPaid.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaid.Location = new Point(824, 544);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(349, 41);
            lblPaid.TabIndex = 118;
            lblPaid.Text = "No. of Employees Paid: ";
            // 
            // tbxDaily
            // 
            tbxDaily.Location = new Point(401, 539);
            tbxDaily.Name = "tbxDaily";
            tbxDaily.Size = new Size(173, 27);
            tbxDaily.TabIndex = 117;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label21.Location = new Point(261, 530);
            label21.Name = "label21";
            label21.Size = new Size(87, 40);
            label21.TabIndex = 116;
            label21.Text = "GrossPay\r\nx (10 days)";
            // 
            // btnGenerateSecondHalfPayslip
            // 
            btnGenerateSecondHalfPayslip.BackColor = Color.FromArgb(255, 128, 128);
            btnGenerateSecondHalfPayslip.FlatStyle = FlatStyle.Popup;
            btnGenerateSecondHalfPayslip.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnGenerateSecondHalfPayslip.Location = new Point(1162, 492);
            btnGenerateSecondHalfPayslip.Name = "btnGenerateSecondHalfPayslip";
            btnGenerateSecondHalfPayslip.Size = new Size(119, 29);
            btnGenerateSecondHalfPayslip.TabIndex = 115;
            btnGenerateSecondHalfPayslip.Text = "Show Payslips";
            btnGenerateSecondHalfPayslip.UseVisualStyleBackColor = false;
            btnGenerateSecondHalfPayslip.Click += btnGenerateSecondHalfPayslip_Click;
            // 
            // btnGenerateFirstHalfPayslip
            // 
            btnGenerateFirstHalfPayslip.BackColor = Color.FromArgb(255, 128, 128);
            btnGenerateFirstHalfPayslip.FlatStyle = FlatStyle.Popup;
            btnGenerateFirstHalfPayslip.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnGenerateFirstHalfPayslip.Location = new Point(874, 494);
            btnGenerateFirstHalfPayslip.Name = "btnGenerateFirstHalfPayslip";
            btnGenerateFirstHalfPayslip.Size = new Size(119, 29);
            btnGenerateFirstHalfPayslip.TabIndex = 114;
            btnGenerateFirstHalfPayslip.Text = "Show Payslips";
            btnGenerateFirstHalfPayslip.UseVisualStyleBackColor = false;
            btnGenerateFirstHalfPayslip.Click += btnGenerateFirstHalfPayslip_Click;
            // 
            // btnUpdateSecondHalfPay
            // 
            btnUpdateSecondHalfPay.BackColor = Color.Green;
            btnUpdateSecondHalfPay.FlatStyle = FlatStyle.Popup;
            btnUpdateSecondHalfPay.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnUpdateSecondHalfPay.Location = new Point(1031, 492);
            btnUpdateSecondHalfPay.Name = "btnUpdateSecondHalfPay";
            btnUpdateSecondHalfPay.Size = new Size(119, 29);
            btnUpdateSecondHalfPay.TabIndex = 113;
            btnUpdateSecondHalfPay.Text = "SecondPay";
            btnUpdateSecondHalfPay.UseVisualStyleBackColor = false;
            btnUpdateSecondHalfPay.Click += btnUpdateSecondHalfPay_Click;
            // 
            // btnUpdateFirstHalfPay
            // 
            btnUpdateFirstHalfPay.BackColor = Color.Green;
            btnUpdateFirstHalfPay.FlatStyle = FlatStyle.Popup;
            btnUpdateFirstHalfPay.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnUpdateFirstHalfPay.Location = new Point(743, 494);
            btnUpdateFirstHalfPay.Name = "btnUpdateFirstHalfPay";
            btnUpdateFirstHalfPay.Size = new Size(119, 29);
            btnUpdateFirstHalfPay.TabIndex = 112;
            btnUpdateFirstHalfPay.Text = "FirstPay";
            btnUpdateFirstHalfPay.UseVisualStyleBackColor = false;
            btnUpdateFirstHalfPay.Click += btnUpdateFirstHalfPay_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.FromArgb(255, 128, 128);
            btnShow.FlatStyle = FlatStyle.Popup;
            btnShow.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnShow.Location = new Point(1145, 388);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(254, 53);
            btnShow.TabIndex = 111;
            btnShow.Text = "Show Payslips";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(249, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1217, 285);
            dataGridView1.TabIndex = 109;
            dataGridView1.CellClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // tbxID
            // 
            tbxID.Location = new Point(401, 345);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(173, 27);
            tbxID.TabIndex = 108;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(258, 345);
            label20.Name = "label20";
            label20.Size = new Size(97, 20);
            label20.TabIndex = 107;
            label20.Text = "Employee ID";
            // 
            // tbxHours
            // 
            tbxHours.Location = new Point(401, 458);
            tbxHours.Name = "tbxHours";
            tbxHours.Size = new Size(173, 27);
            tbxHours.TabIndex = 106;
            // 
            // tbxRate
            // 
            tbxRate.Location = new Point(401, 420);
            tbxRate.Name = "tbxRate";
            tbxRate.Size = new Size(173, 27);
            tbxRate.TabIndex = 105;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.Location = new Point(258, 459);
            label18.Name = "label18";
            label18.Size = new Size(110, 20);
            label18.TabIndex = 104;
            label18.Text = "Hours Worked";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label19.Location = new Point(258, 423);
            label19.Name = "label19";
            label19.Size = new Size(92, 20);
            label19.TabIndex = 103;
            label19.Text = "Hourly Rate";
            // 
            // dtp2
            // 
            dtp2.Location = new Point(1031, 459);
            dtp2.Name = "dtp2";
            dtp2.Size = new Size(250, 27);
            dtp2.TabIndex = 102;
            // 
            // dtp1
            // 
            dtp1.Checked = false;
            dtp1.Location = new Point(743, 459);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(250, 27);
            dtp1.TabIndex = 101;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(999, 464);
            label17.Name = "label17";
            label17.Size = new Size(26, 20);
            label17.TabIndex = 100;
            label17.Text = "To";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(643, 464);
            label16.Name = "label16";
            label16.Size = new Size(83, 20);
            label16.TabIndex = 99;
            label16.Text = "Pay Period";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.Image = Properties.Resources._10758957_user_search_icon1;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(265, 647);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 95;
            pictureBox2.TabStop = false;
            // 
            // tbxSearch
            // 
            tbxSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.Location = new Point(571, 655);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(883, 31);
            tbxSearch.TabIndex = 93;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.LightCoral;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(370, 658);
            label14.Name = "label14";
            label14.Size = new Size(173, 28);
            label14.TabIndex = 92;
            label14.Text = "Search Employee";
            // 
            // tbxTax
            // 
            tbxTax.Location = new Point(401, 580);
            tbxTax.Name = "tbxTax";
            tbxTax.Size = new Size(173, 27);
            tbxTax.TabIndex = 91;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(261, 580);
            label9.Name = "label9";
            label9.Size = new Size(136, 20);
            label9.TabIndex = 90;
            label9.Text = "Income Tax (15%)";
            // 
            // tbxGross
            // 
            tbxGross.Location = new Point(401, 500);
            tbxGross.Name = "tbxGross";
            tbxGross.Size = new Size(173, 27);
            tbxGross.TabIndex = 89;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(261, 500);
            label12.Name = "label12";
            label12.Size = new Size(80, 20);
            label12.TabIndex = 88;
            label12.Text = "Daily Rate";
            // 
            // tbxNet
            // 
            tbxNet.Location = new Point(401, 616);
            tbxNet.Name = "tbxNet";
            tbxNet.Size = new Size(173, 27);
            tbxNet.TabIndex = 87;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(265, 614);
            label11.Name = "label11";
            label11.Size = new Size(64, 20);
            label11.TabIndex = 86;
            label11.Text = "Net Pay";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(401, 380);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(173, 27);
            tbxName.TabIndex = 85;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(256, 383);
            label10.Name = "label10";
            label10.Size = new Size(123, 20);
            label10.TabIndex = 84;
            label10.Text = "Employee Name";
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.Violet;
            btnLoadData.FlatStyle = FlatStyle.Popup;
            btnLoadData.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnLoadData.Location = new Point(608, 388);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(254, 53);
            btnLoadData.TabIndex = 63;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Controls.Add(flowLayoutPanel2);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(0, 692);
            panel4.Name = "panel4";
            panel4.Size = new Size(1466, 52);
            panel4.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Blue;
            flowLayoutPanel2.Location = new Point(614, 45);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(81, 4);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(787, 15);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 10;
            label2.Text = "Log-out";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(611, 15);
            label6.Name = "label6";
            label6.Size = new Size(84, 27);
            label6.TabIndex = 8;
            label6.Text = "Report";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(432, 15);
            label7.Name = "label7";
            label7.Size = new Size(87, 27);
            label7.TabIndex = 6;
            label7.Text = "Payroll";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(249, 15);
            label8.Name = "label8";
            label8.Size = new Size(80, 27);
            label8.TabIndex = 2;
            label8.Text = "Home";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 691);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Image = Properties.Resources._1564506_close_exit_logout_power_icon;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(34, 492);
            button5.Name = "button5";
            button5.Size = new Size(163, 78);
            button5.TabIndex = 4;
            button5.Text = "Log-out";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Image = Properties.Resources.payroll2;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(34, 342);
            button4.Name = "button4";
            button4.Size = new Size(163, 82);
            button4.TabIndex = 3;
            button4.Text = "Report";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = Properties.Resources._4308184_client_costs_employee_finance_money_icon;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(34, 197);
            button3.Name = "button3";
            button3.Size = new Size(163, 75);
            button3.TabIndex = 2;
            button3.Text = "Payroll";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources._3669170_home_ic_icon2;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(34, 49);
            button1.Name = "button1";
            button1.Size = new Size(163, 86);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1466, 52);
            panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Blue;
            flowLayoutPanel1.Location = new Point(614, 45);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(81, 4);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(787, 15);
            label5.Name = "label5";
            label5.Size = new Size(98, 27);
            label5.TabIndex = 10;
            label5.Text = "Log-out";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(611, 15);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 8;
            label4.Text = "Report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(432, 15);
            label3.Name = "label3";
            label3.Size = new Size(87, 27);
            label3.TabIndex = 6;
            label3.Text = "Payroll";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 27);
            label1.TabIndex = 2;
            label1.Text = "Home";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic);
            label13.ForeColor = Color.Gold;
            label13.Location = new Point(2, 179);
            label13.Name = "label13";
            label13.Size = new Size(59, 360);
            label13.TabIndex = 3;
            label13.Text = "A\r\nP\r\nC\r\nD\r\nB\r\n+\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.paytaw;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 601);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 93);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.payroll;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(0, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 93);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1533, 743);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            Load += Report_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label13;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button btnLoadData;
        private DateTimePicker dtp2;
        private DateTimePicker dtp1;
        private Label label17;
        private Label label16;
        private PictureBox pictureBox2;
        private TextBox tbxSearch;
        private Label label14;
        private TextBox tbxTax;
        private Label label9;
        private TextBox tbxGross;
        private Label label12;
        private TextBox tbxNet;
        private Label label11;
        private TextBox tbxName;
        private Label label10;
        private TextBox tbxHours;
        private TextBox tbxRate;
        private Label label18;
        private Label label19;
        private TextBox tbxID;
        private Label label20;
        private DataGridView dataGridView1;
        private Button btnShow;
        private Button btnUpdateSecondHalfPay;
        private Button btnUpdateFirstHalfPay;
        private Button btnGenerateSecondHalfPayslip;
        private Button btnGenerateFirstHalfPayslip;
        private TextBox tbxDaily;
        private Label label21;
        private Label lblPaid;
    }
}