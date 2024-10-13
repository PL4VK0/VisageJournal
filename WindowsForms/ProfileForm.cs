using DTO;

namespace WindowsForms
{
    public partial class ProfileForm : Form
    {
        public User user { get; set; } = VJ.userOptions.GetUser();
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (VJ.userOptions.GetUser().UserID != user.UserID)
            {
                btnBeginPost.Hide();
                btnDeleteAccount.Hide();
            }
            lblProfileName.Text = VJ.userOptions.GetUser().UserName;
            lblUserPosts.Text = VJ.userOptions.GetUser().UserName + "'s Posts ";
            RefreshGrid();
        }

        private void btnBeginPost_Click(object sender, EventArgs e)
        {
            WritePostForm beginPost = new WritePostForm();
            beginPost.ShowDialog();
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dgvUserPosts.DataSource = null;
            dgvUserPosts.DataSource = VJ.userOptions.GetAllPostsFromThisUser(user.UserID).OrderByDescending(p => p.Date).ToList();


            if (dgvUserPosts.Rows.Count == 0 && user.UserID == VJ.userOptions.GetUser().UserID)
                lblUserPosts.Text = "you have NO POSTS... FIX THIS NOW!";
            else if (dgvUserPosts.Rows.Count == 0)
                lblUserPosts.Text = "This user has no posts...";


            dgvUserPosts.Columns["PostID"].Visible = false;
            dgvUserPosts.Columns["PosterID"].Visible = false;
            dgvUserPosts.Columns["PostText"].Visible = false;
            dgvUserPosts.Columns["CommentIDs"].Visible = false;
            dgvUserPosts.Columns["UpVotes"].Visible = false;
            dgvUserPosts.Columns["DownVotes"].Visible = false;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            UnRegisterForm unRegisterForm = new UnRegisterForm();
            unRegisterForm.ShowDialog();
        }
    }
}
