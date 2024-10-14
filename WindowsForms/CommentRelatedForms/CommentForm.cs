using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
