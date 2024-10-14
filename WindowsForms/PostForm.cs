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
            if (post.UpVotes.Contains(VJ.userOptions.GetUser().UserID))
                btnUpVote.BackColor = Color.Green;
            else
                btnUpVote.BackColor = Color.White;


            if (post.DownVotes.Contains(VJ.userOptions.GetUser().UserID))
                btnDownVote.BackColor = Color.Red;
            else
                btnDownVote.BackColor = Color.White;
            lblCountRating.Text = Convert.ToString(post.UpVotes.Count - post.DownVotes.Count);
        }

        private void dgvPostComments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
