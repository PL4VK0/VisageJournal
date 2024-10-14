namespace WindowsForms.CommentRelatedForms
{
    partial class WriteCommentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCommentText = new Label();
            richTextBoxCommentText = new RichTextBox();
            btnEndAddComment = new Button();
            lblUsersPost = new Label();
            SuspendLayout();
            // 
            // lblCommentText
            // 
            lblCommentText.AutoSize = true;
            lblCommentText.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblCommentText.Location = new Point(43, 96);
            lblCommentText.Margin = new Padding(4, 0, 4, 0);
            lblCommentText.Name = "lblCommentText";
            lblCommentText.Size = new Size(151, 24);
            lblCommentText.TabIndex = 0;
            lblCommentText.Text = "YourComment:";
            // 
            // richTextBoxCommentText
            // 
            richTextBoxCommentText.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxCommentText.Location = new Point(43, 137);
            richTextBoxCommentText.Name = "richTextBoxCommentText";
            richTextBoxCommentText.Size = new Size(548, 318);
            richTextBoxCommentText.TabIndex = 1;
            richTextBoxCommentText.Text = "SomeCommentText";
            // 
            // btnEndAddComment
            // 
            btnEndAddComment.Location = new Point(43, 461);
            btnEndAddComment.Name = "btnEndAddComment";
            btnEndAddComment.Size = new Size(113, 29);
            btnEndAddComment.TabIndex = 2;
            btnEndAddComment.Text = "Comment!";
            btnEndAddComment.UseVisualStyleBackColor = true;
            btnEndAddComment.Click += btnEndAddComment_Click;
            // 
            // lblUsersPost
            // 
            lblUsersPost.AutoSize = true;
            lblUsersPost.Location = new Point(43, 9);
            lblUsersPost.Name = "lblUsersPost";
            lblUsersPost.Size = new Size(167, 23);
            lblUsersPost.TabIndex = 3;
            lblUsersPost.Text = "User's Post (Title)";
            // 
            // WriteCommentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(627, 545);
            Controls.Add(lblUsersPost);
            Controls.Add(btnEndAddComment);
            Controls.Add(richTextBoxCommentText);
            Controls.Add(lblCommentText);
            Font = new Font("Arial", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "WriteCommentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WriteCommentForm";
            Load += WriteCommentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCommentText;
        private RichTextBox richTextBoxCommentText;
        private Button btnEndAddComment;
        private Label lblUsersPost;
    }
}