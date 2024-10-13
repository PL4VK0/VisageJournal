using DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsForms
{
    public partial class RegistrationForm : Form
    {
        

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEndSignUp_Click(object sender, EventArgs e)
        {
            User userToRegister = new User();
            userToRegister.FirstName = txtBoxFirstName.Text;
            userToRegister.LastName = txtBoxLastName.Text;
            userToRegister.UserName = txtBoxUserName.Text;
            userToRegister.Email = txtBoxEmail.Text;
            userToRegister.Password = txtBoxPassword.Text;
            
            BsonArray interestArray = new BsonArray();
            List<string> interestList = txtBoxInterests.Text.Split(' ').ToList();
            for(int i = 0; i < interestList.Count; i++)
            {
                if (string.IsNullOrEmpty(interestList[i]))
                    continue;
                interestArray.Add(interestList[i].Trim());
            }
            userToRegister.Interests = interestArray;

            try 
            {
                VJ.userOptions.SignUp(userToRegister);
                MessageBox.Show("REGISTRATION SUCCESSFUL!","ERROR",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Question);
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "REGISTRATION FAILED!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand); }
        }
    }
}
