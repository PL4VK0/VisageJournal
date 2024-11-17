using DTO;

namespace WindowsForms
{
    public partial class CommentForm : Form
    {
        Comment comment = null;
        public CommentForm(Comment comment)
        {
            this.comment = comment;
            InitializeComponent();
        }

        private void CommentForm_Load(object sender, EventArgs e)
        {
            lblUsersPost.Text = comment.PosterUserName + "'s Post";
            lblUsersComment.Text = comment.CommentatorUserName + "'s Comment";
            richTextBoxCommentText.Text = comment.CommentText;
            richTextBoxCommentText.ReadOnly = true;
            if (comment.CommentatorUserName == VJ.userOptions.GetUser().UserName)
            {
                richTextBoxCommentText.ReadOnly = false;
                btnUpdateComment.Visible = true;
            }

            Refresh();
        }
        void Refresh()
        {
            if (comment.UpVotes.Contains(VJ.userOptions.GetUser().UserID))
                btnUpVoteComment.BackColor = Color.LightGreen;
            else
                btnUpVoteComment.BackColor = Color.White;


            if (comment.DownVotes.Contains(VJ.userOptions.GetUser().UserID))
                btnDownVoteComment.BackColor = Color.OrangeRed;
            else
                btnDownVoteComment.BackColor = Color.White;
            lblRatingCount.Text = Convert.ToString(comment.UpVotes.Count - comment.DownVotes.Count);
        }

        private void btnUpVoteComment_Click(object sender, EventArgs e)
        {
            if (comment.UpVotes.Contains(VJ.userOptions.GetUser().UserID))
            {
                VJ.userOptions.RemoveCommentUpVote(comment);
                Refresh();
                return;
            }
            if (comment.DownVotes.Contains(VJ.userOptions.GetUser().UserID))
                VJ.userOptions.RemoveCommentDownVote(comment);
            VJ.userOptions.UpVoteComment(comment);
            Refresh();
        }

        private void btnDownVoteComment_Click(object sender, EventArgs e)
        {
            if (comment.DownVotes.Contains(VJ.userOptions.GetUser().UserID))
            {
                VJ.userOptions.RemoveCommentDownVote(comment);
                Refresh();
                return;
            }
            if (comment.UpVotes.Contains(VJ.userOptions.GetUser().UserID))
                VJ.userOptions.RemoveCommentUpVote(comment);
            VJ.userOptions.DownVoteComment(comment);
            Refresh();
        }

        private void richTextBoxCommentText_TextChanged(object sender, EventArgs e)
        {
            if (comment.CommentText != richTextBoxCommentText.Text&&!string.IsNullOrEmpty(richTextBoxCommentText.Text))
                btnUpdateComment.Enabled = true;
            else
                btnUpdateComment.Enabled = false;
        }

        private async void btnUpdateComment_Click(object sender, EventArgs e)
        {
            comment.CommentText = richTextBoxCommentText.Text+" [UPDATED]";
            comment.Date = DateTime.Now;
            await VJ.userOptions.UpdateComment(comment);
            MessageBox.Show("UPDATED SUCCESSFULLY!","NO ERER",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refresh();
        }
    }
}
