namespace WindowsForms
{
    public partial class UnRegisterForm : Form
    {
        public UnRegisterForm()
        {
            InitializeComponent();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phew, let's work together for some more!", "HOORAY!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            Close();
        }

        private void btnBeginUnRegister_Click(object sender, EventArgs e)
        {
            lblPassword.Show();
            textBoxPassword.Show();
            btnEndUnRegister.Show();
            btnBeginUnRegister.Hide();
            btnNO.Location = new Point(80, 80);
        }

        private void UnRegisterForm_Load(object sender, EventArgs e)
        {
            btnEndUnRegister.Hide();
            lblPassword.Hide();
            textBoxPassword.Hide();
        }

        private void btnEndUnRegister_Click(object sender, EventArgs e)
        {
            VJ.userOptions.SignDown();
        }
    }
}
