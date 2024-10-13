namespace WindowsForms
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            lblMyProfile.Text = VJ.userOptions.GetUser().UserName;
            dgvMyPosts.DataSource = VJ.userOptions.GetAllPostsFromThisUser(VJ.userOptions.GetUser().UserID).ToList();
            if (dgvMyPosts.Rows.Count == 0)
                lblYourPosts.Text = "you have NO POSTS... FIX THIS NOW!";
            dgvMyPosts.Columns["PostID"].Visible = false;
            dgvMyPosts.Columns["PosterID"].Visible = false;
            dgvMyPosts.Columns["PostText"].Visible = false;
            dgvMyPosts.Columns["CommentIDs"].Visible = false;
            dgvMyPosts.Columns["UpVotes"].Visible = false;
            dgvMyPosts.Columns["DownVotes"].Visible = false;
        }

        private void btnBeginPost_Click(object sender, EventArgs e)
        {
            PostForm beginPost = new PostForm();
            beginPost.ShowDialog();
        }
    }
}
