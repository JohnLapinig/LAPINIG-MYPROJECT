namespace LAPINIG_MYPROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "1" && tbxPassword.Text == "1")
            {
                timer1.Start();
                lblPls.Visible = true;
                progressBar1.Show();
            }
            else if (tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(25);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                Dashboard a = new Dashboard();
                this.Hide();
                a.Show();
            }
        }

        private void cbxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShow.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblPls_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblPls.Visible = true;
        }
    }
}