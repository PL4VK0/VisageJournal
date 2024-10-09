namespace WindowsForms
{
    public partial class VJ : Form
    {
        public VJ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //btnSignIn.Hide();
            //lblNoAccount.Hide();
            //btnBeginSignUp.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
