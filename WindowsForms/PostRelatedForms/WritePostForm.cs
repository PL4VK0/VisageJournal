namespace WindowsForms
{
    public partial class WritePostForm : Form
    {
        public WritePostForm()
        {
            InitializeComponent();
        }

        private void btnEndPost_Click(object sender, EventArgs e)
        {
            string postTitle = textBoxPostTitle.Text;
            string postText = richTextBoxPostText.Text;
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
