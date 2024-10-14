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
            if(textBoxPassword.Text!=VJ.userOptions.GetUser().Password)
            {
                MessageBox.Show("WRONG PASSWORD!","you're staying with us",MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                return;
            }
            VJ.userOptions.SignDown();
            MessageBox.Show("goodbye(","i'm not crying...");
            MessageBox.Show("the application will self-destruct after your choice");
            Application.Exit();
        }
    }
}
