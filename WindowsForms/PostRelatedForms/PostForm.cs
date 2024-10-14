using DTO;
using WindowsForms.CommentRelatedForms;

namespace WindowsForms
{
    public partial class PostForm : Form
    {
        public Post post = null;
        public PostForm(Post post)
        {
            this.post = post;
            InitializeComponent();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            lblPostTitle.Text = post.PostTitle;
            richTextBoxPostText.Text = post.PostText;
            lblUsersPost.Text = post.PosterUserName + "'s Post";
            Refresh();
        }

        private void btnUpVote_Click(object sender, EventArgs e)
        {
            if (post.UpVotes.Contains(VJ.userOptions.GetUser().UserID))
            {
                VJ.userOptions.RemovePostUpVote(post);
                Refresh();
                return;
            }
            if (post.DownVotes.Contains(VJ.userOptions.GetUser().UserID))
                VJ.userOptions.RemovePostDownVote(post);
            VJ.userOptions.UpVotePost(post);
            Refresh();
        }
        private void Refresh()
        {
            dgvPostComments.DataSource = null;
            if (post.UpVotes.Contains(VJ.userOptions.GetUser().UserID))
                btnUpVote.BackColor = Color.LightGreen;
            else
                btnUpVote.BackColor = Color.White;


            if (post.DownVotes.Contains(VJ.userOptions.GetUser().UserID))
                btnDownVote.BackColor = Color.OrangeRed;
            else
                btnDownVote.BackColor = Color.White;
            lblCountRating.Text = Convert.ToString(post.UpVotes.Count - post.DownVotes.Count);


            List<Comment> postComments = VJ.userOptions.GetAllCommentsFromThisPost(post).OrderByDescending(c=>c.Date).ToList();
            dgvPostComments.DataSource = new BindingSource { DataSource = postComments };
            dgvPostComments.Columns["CommentID"].Visible = false;
            dgvPostComments.Columns["Date"].Visible = false;
            dgvPostComments.Columns["PostID"].Visible = false;
            dgvPostComments.Columns["PosterUserName"].Visible = false;
            dgvPostComments.Columns["CommentatorUserName"].Visible = true;
            dgvPostComments.Columns["CommentatorUserName"].HeaderText = "User";
            dgvPostComments.Columns["CommentText"].HeaderText = "Text";
            dgvPostComments.Columns["UpVotes"].Visible = false;
            dgvPostComments.Columns["DownVotes"].Visible = false;
            dgvPostComments.Columns["CommentatorUserName"].Name = "User";
            if (dgvPostComments.Rows.Count > 0)
                lblPostComments.Text = "Comments";
        }

        private void dgvPostComments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            Comment comment = (Comment)dgvPostComments.Rows[e.RowIndex].DataBoundItem;
            CommentForm commentForm = new CommentForm(comment);
            commentForm.ShowDialog();
        }

        private void btnDownVote_Click(object sender, EventArgs e)
        {
            if (post.DownVotes.Contains(VJ.userOptions.GetUser().UserID))
            {
                VJ.userOptions.RemovePostDownVote(post);
                Refresh();
                return;
            }
            if (post.UpVotes.Contains(VJ.userOptions.GetUser().UserID))
                VJ.userOptions.RemovePostUpVote(post);
            VJ.userOptions.DownVotePost(post);
            Refresh();
        }

        private void btnBeginAddComment_Click(object sender, EventArgs e)
        {
            WriteCommentForm addCommentForm = new WriteCommentForm(post);
            addCommentForm.ShowDialog();
            Refresh();
        }
    }
}
