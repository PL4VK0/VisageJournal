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
        public PostForm()
        {
            InitializeComponent();
        }

        private void btnEndPost_Click(object sender, EventArgs e)
        {
            string postTitle = textBoxPostTitle.Text;
            string postText = textBoxPostText.Text;
            try
            {
                VJ.userOptions.NewPostFromThisUser(postTitle,postText);
                MessageBox.Show("Successfully added new post!", "HELL YEAH!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"OH NO!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
            }
        }
    }
}
