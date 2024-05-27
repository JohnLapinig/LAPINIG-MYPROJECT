namespace LAPINIG_MYPROJECT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxUsername = new TextBox();
            label4 = new Label();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            cbxShow = new CheckBox();
            lblPls = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 491);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Maroon;
            label5.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(194, 47);
            label5.Name = "label5";
            label5.Size = new Size(141, 46);
            label5.TabIndex = 2;
            label5.Text = "All Hail";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.payroll;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(21, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(145, 93);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(37, 164);
            label1.Name = "label1";
            label1.Size = new Size(205, 246);
            label1.TabIndex = 0;
            label1.Text = "A-utomated\r\nP-ayroll\r\nC-alculator\r\nD-ata \r\nB-ase \r\n+Integration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(363, 48);
            label2.Name = "label2";
            label2.Size = new Size(162, 46);
            label2.TabIndex = 1;
            label2.Text = "APCDB+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(418, 173);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = Color.Gold;
            tbxUsername.Location = new Point(370, 215);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(170, 27);
            tbxUsername.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(419, 266);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.Gold;
            tbxPassword.Location = new Point(369, 309);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(170, 27);
            tbxPassword.TabIndex = 5;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Gold;
            btnLogin.Location = new Point(368, 383);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 45);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log-in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gold;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Maroon;
            btnExit.Location = new Point(503, 383);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 45);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(531, 443);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(147, 31);
            progressBar1.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Maroon;
            flowLayoutPanel1.Location = new Point(370, 239);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(170, 3);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Maroon;
            flowLayoutPanel2.Location = new Point(369, 334);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(170, 3);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._2203549_admin_avatar_human_login_user_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(373, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 36);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._511942_lock_login_protection_secure_icon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(374, 257);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 36);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Maroon;
            label6.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(316, 97);
            label6.Name = "label6";
            label6.Size = new Size(64, 46);
            label6.TabIndex = 3;
            label6.Text = "To";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.paytaw;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(531, 48);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(145, 93);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // cbxShow
            // 
            cbxShow.AutoSize = true;
            cbxShow.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxShow.Location = new Point(503, 342);
            cbxShow.Name = "cbxShow";
            cbxShow.Size = new Size(140, 22);
            cbxShow.TabIndex = 13;
            cbxShow.Text = "Show Password";
            cbxShow.UseVisualStyleBackColor = true;
            cbxShow.CheckedChanged += cbxShow_CheckedChanged;
            // 
            // lblPls
            // 
            lblPls.AutoSize = true;
            lblPls.FlatStyle = FlatStyle.Flat;
            lblPls.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPls.ForeColor = Color.Maroon;
            lblPls.Location = new Point(414, 451);
            lblPls.Name = "lblPls";
            lblPls.Size = new Size(117, 19);
            lblPls.TabIndex = 0;
            lblPls.Text = "Please wait...";
            lblPls.Visible = false;
            lblPls.Click += lblPls_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(693, 488);
            Controls.Add(lblPls);
            Controls.Add(cbxShow);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(progressBar1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(label4);
            Controls.Add(tbxUsername);
            Controls.Add(label3);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log-in";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox tbxUsername;
        private Label label4;
        private TextBox tbxPassword;
        private Label label1;
        private Button btnLogin;
        private Button btnExit;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox4;
        private CheckBox cbxShow;
        private Label lblPls;
    }
}