using BusinessLogic;
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
            dgvUserSearch.Hide();
            lblRecentPosts.Hide();
            btnFindByUserName.Hide();
            textBoxUserName.Hide();
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
            dgvUserSearch.Show();
            lblRecentPosts.Show();
            btnFindByUserName.Show();
            textBoxUserName.Show();
            Refresh();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(userOptions.GetUser());
            profile.ShowDialog();
            Refresh();
        }

        private void dgvPosts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            Post post = (Post)dgvPosts.Rows[e.RowIndex].DataBoundItem;
            PostForm postForm = new PostForm(post);
            postForm.ShowDialog();
            Refresh();
        }
        private void Refresh()
        {
            dgvPosts.DataSource = null;
            List<Post> posts = userOptions.GetAllFriendAndMinePosts().OrderByDescending(p => p.Date).ToList();
            dgvPosts.DataSource = new BindingSource { DataSource = posts };
            dgvPosts.Columns["PostID"].Visible = false;
            dgvPosts.Columns["PosterUserName"].Visible = true;
            dgvPosts.Columns["PosterUserName"].HeaderText = "User";
            dgvPosts.Columns["PostText"].Visible = false;
            dgvPosts.Columns["UpVotes"].Visible = false;
            dgvPosts.Columns["DownVotes"].Visible = false;
        }

        private void dgvUserSearch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            User foundUser = (User)dgvUserSearch.Rows[e.RowIndex].DataBoundItem;
            ProfileForm profileForm = new ProfileForm(foundUser);
            profileForm.ShowDialog();
            Refresh();
        }

        private void btnFindByUserName_Click(object sender, EventArgs e)
        {
            string potentialUserName = textBoxUserName.Text.ToUpper();
            User foundUser = userOptions.FindByUserName(potentialUserName);
            dgvUserSearch.DataSource = null;
            if (foundUser == null)
            {
                MessageBox.Show("There is no user with this UserName!","OH NO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            dgvUserSearch.DataSource = new BindingSource { DataSource =  foundUser };
            dgvUserSearch.Columns["UserID"].Visible = false;
            dgvUserSearch.Columns["FirstName"].Visible = false;
            dgvUserSearch.Columns["LastName"].Visible = true;
            dgvUserSearch.Columns["UserName"].Visible = true;
            dgvUserSearch.Columns["Interests"].Visible = false;
            dgvUserSearch.Columns["Address"].Visible = false;
            dgvUserSearch.Columns["FollowerIDs"].Visible = false;
            dgvUserSearch.Columns["FollowingIDs"].Visible = false;
            dgvUserSearch.Columns["Email"].Visible = false;
            dgvUserSearch.Columns["Password"].Visible = false;
        }
    }
}
