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

namespace WindowsForms.CommentRelatedForms
{
    public partial class WriteCommentForm : Form
    {
        Post post = null;
        public WriteCommentForm(Post post)
        {
            this.post = post;
            InitializeComponent();
        }

        private void WriteCommentForm_Load(object sender, EventArgs e)
        {
            lblUsersPost.Text = post.PosterUserName + "'s Post (" + post.PostTitle + ")";
        }

        private void btnEndAddComment_Click(object sender, EventArgs e)
        {
            string commentText = richTextBoxCommentText.Text;
            Comment comment = new Comment();
            comment.PostID = post.PostID;
            comment.CommentText = commentText;
            comment.CommentatorUserName = VJ.userOptions.GetUser().UserName;
            comment.PosterUserName = post.PosterUserName;
            VJ.userOptions.NewCommentFromThisUser(comment);
            MessageBox.Show("Commented Successfully!");
            Close();
        }
    }
}
