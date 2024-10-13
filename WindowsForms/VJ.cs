using BusinessLogic;
using DAL.Beton;
using DTO;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace WindowsForms
{
    public partial class VJ : Form
    {
        public static UserOptions userOptions;
        public VJ()
        {
            InitializeComponent();
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json")
                .Build();
            IMongoClient client = new MongoClient(config.GetConnectionString("VisageJournal"));
            IMongoDatabase db = client.GetDatabase("test");
            IMongoCollection<User> userCollecion = db.GetCollection<User>("Users");
            IMongoCollection<Post> postCollection = db.GetCollection<Post>("Posts");
            IMongoCollection<Comment> commentCollection = db.GetCollection<Comment>("Comments");

            //UserDAL uDAL = new UserDAL(userCollecion);
            //PostDAL pDAL= new PostDAL(postCollection);
            //CommentDAL cDAL  = new CommentDAL(commentCollection
            userOptions = new UserOptions(userCollecion, postCollection, commentCollection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMyProfile.Hide();
            dgvPosts.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //btnSignIn.Hide();
            //lblNoAccount.Hide();
            //btnBeginSignUp.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
            //user = signInForm.signedIn;
            if (userOptions.GetUser() == null)
                return;
            MessageBox.Show($"SIGNED IN AS {userOptions.GetUser().UserName}!!!", "SING A SONG");
            ShowMyPage();
        }
        private void ShowMyPage()
        {
            lblNoAccount.Hide();
            btnBeginSignIn.Hide();
            btnBeginSignUp.Hide();
            dgvPosts.Show();
            btnMyProfile.Show();
            btnMyProfile.Text = userOptions.GetUser().UserName;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.ShowDialog();
        }
    }
}
