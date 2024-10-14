using DTO;

namespace WindowsForms
{
    public partial class ProfileForm : Form
    {
        public User user { get; set; } = VJ.userOptions.GetUser();
        public ProfileForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (VJ.userOptions.GetUser().UserID != user.UserID)
            {
                btnBeginPost.Hide();
                btnDeleteAccount.Hide();
                btnDeletePosts.Hide();
            }
            else
                btnFollow.Hide();
            lblProfileName.Text = user.UserName;
            lblUserPosts.Text = user.UserName + "'s Posts ";
            foreach (var interest in user.Interests)
                richTextBoxInterests.Text += interest + "\n";



            string planet = null;
            string country = null;
            string city = null;

            if (user.Address.Contains("planet"))
                planet = user.Address["planet"].ToString();

            if (user.Address.Contains("country"))
                country = user.Address["country"].ToString();

            if (user.Address.Contains("city"))
                city = user.Address["city"].ToString();

            if(string.IsNullOrEmpty(city))
                richTextBoxAddress.Text += "City: UNKNOWN\n";
            else
                richTextBoxAddress.Text += $"City: {city}\n";
            if (string.IsNullOrEmpty(country))
                richTextBoxAddress.Text += "Country: UNKNOWN\n";
            else
                richTextBoxAddress.Text += $"Country: {country}\n";
            if (string.IsNullOrEmpty(planet))
                richTextBoxAddress.Text += "Planet: UNKNOWN\n";
            else
                richTextBoxAddress.Text += $"Planet: {planet}\n";
            Refresh();
        }

        private void btnBeginPost_Click(object sender, EventArgs e)
        {
            WritePostForm beginPost = new WritePostForm();
            beginPost.ShowDialog();
            Refresh();
        }
        private void Refresh()
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
            dgvUserPosts.Columns["UpVotes"].Visible = false;
            dgvUserPosts.Columns["DownVotes"].Visible = false;
            if (VJ.userOptions.GetUser().FollowingIDs.Contains(user.UserID))
                btnFollow.Text = "UnFollow";
            else
                btnFollow.Text = "Follow";
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
            Refresh();
            //Post item = dgvUserPosts.SelectedRows[0].DataBoundItem as Post;
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (!VJ.userOptions.GetUser().FollowingIDs.Contains(user.UserID))
                VJ.userOptions.Follow(VJ.userOptions.GetUser().UserID, user.UserID);
            else
                VJ.userOptions.UnFollow(VJ.userOptions.GetUser().UserID, user.UserID);
            Refresh();
        }

        private void dgvUserPosts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            Post post = (Post)dgvUserPosts.Rows[e.RowIndex].DataBoundItem;
            PostForm postForm = new PostForm(post);
            postForm.ShowDialog();
            Refresh();
        }
    }
}
