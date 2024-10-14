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
                btnDeletePosts.Hide();
                if (user.FollowingIDs.Contains(VJ.userOptions.GetUser().UserID))
                    btnFollow.Text = "UnFollow";
            }
            btnFollow.Hide();
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
            dgvUserPosts.DataSource = new BindingSource { DataSource = VJ.userOptions.GetAllPostsFromThisUser(user).OrderByDescending(p => p.Date).ToList() };


            if (dgvUserPosts.Rows.Count == 0 && user.UserID == VJ.userOptions.GetUser().UserID)
                lblUserPosts.Text = "you have NO POSTS... FIX THIS NOW!";
            else if (dgvUserPosts.Rows.Count == 0)
                lblUserPosts.Text = "This user has no posts...";


            dgvUserPosts.Columns["PostID"].Visible = false;
            dgvUserPosts.Columns["PosterUserName"].Visible = false;
            dgvUserPosts.Columns["PostText"].Visible = false;
            //dgvUserPosts.Columns["CommentIDs"].Visible = false;
            dgvUserPosts.Columns["UpVotes"].Visible = false;
            dgvUserPosts.Columns["DownVotes"].Visible = false;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            UnRegisterForm unRegisterForm = new UnRegisterForm();
            unRegisterForm.ShowDialog();
        }

        private void btnDeletePosts_Click(object sender, EventArgs e)
        {
            for (int i = dgvUserPosts.SelectedRows.Count - 1; i >= 0d; i--)
            {
                Post selectedPost = dgvUserPosts.SelectedRows[i].DataBoundItem as Post;
                VJ.userOptions.RemovePost(selectedPost);
            }
            RefreshGrid();
            //Post item = dgvUserPosts.SelectedRows[0].DataBoundItem as Post;
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (!user.FollowingIDs.Contains(VJ.userOptions.GetUser().UserID))
                VJ.userOptions.Follow(VJ.userOptions.GetUser().UserID, user.UserID);
            else
                VJ.userOptions.UnFollow(VJ.userOptions.GetUser().UserID, user.UserID);
        }

        private void dgvUserPosts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0) 
                return;
            Post post = (Post)dgvUserPosts.Rows[e.RowIndex].DataBoundItem;
            PostForm postForm = new PostForm(post);
            postForm.ShowDialog();
        }
    }
}
