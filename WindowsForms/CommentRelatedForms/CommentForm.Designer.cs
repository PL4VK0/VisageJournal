namespace WindowsForms
{
    partial class CommentForm
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
            lblUsersPost = new Label();
            lblUsersComment = new Label();
            richTextBoxCommentText = new RichTextBox();
            btnUpVoteComment = new Button();
            btnDownVoteComment = new Button();
            lblRating = new Label();
            lblRatingCount = new Label();
            SuspendLayout();
            // 
            // lblUsersPost
            // 
            lblUsersPost.AutoSize = true;
            lblUsersPost.Font = new Font("Arial", 14F);
            lblUsersPost.Location = new Point(13, 9);
            lblUsersPost.Margin = new Padding(4, 0, 4, 0);
            lblUsersPost.Name = "lblUsersPost";
            lblUsersPost.Size = new Size(134, 27);
            lblUsersPost.TabIndex = 0;
            lblUsersPost.Text = "User's Post";
            // 
            // lblUsersComment
            // 
            lblUsersComment.AutoSize = true;
            lblUsersComment.Location = new Point(13, 89);
            lblUsersComment.Name = "lblUsersComment";
            lblUsersComment.Size = new Size(155, 23);
            lblUsersComment.TabIndex = 1;
            lblUsersComment.Text = "User's Comment";
            // 
            // richTextBoxCommentText
            // 
            richTextBoxCommentText.Font = new Font("Arial", 10F);
            richTextBoxCommentText.Location = new Point(13, 115);
            richTextBoxCommentText.Name = "richTextBoxCommentText";
            richTextBoxCommentText.ReadOnly = true;
            richTextBoxCommentText.Size = new Size(333, 241);
            richTextBoxCommentText.TabIndex = 2;
            richTextBoxCommentText.Text = "CommentText";
            // 
            // btnUpVoteComment
            // 
            btnUpVoteComment.Location = new Point(13, 362);
            btnUpVoteComment.Name = "btnUpVoteComment";
            btnUpVoteComment.Size = new Size(111, 29);
            btnUpVoteComment.TabIndex = 3;
            btnUpVoteComment.Text = "UpVote";
            btnUpVoteComment.UseVisualStyleBackColor = true;
            btnUpVoteComment.Click += btnUpVoteComment_Click;
            // 
            // btnDownVoteComment
            // 
            btnDownVoteComment.Location = new Point(235, 362);
            btnDownVoteComment.Name = "btnDownVoteComment";
            btnDownVoteComment.Size = new Size(111, 29);
            btnDownVoteComment.TabIndex = 4;
            btnDownVoteComment.Text = "DownVote";
            btnDownVoteComment.UseVisualStyleBackColor = true;
            btnDownVoteComment.Click += btnDownVoteComment_Click;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(13, 411);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(66, 23);
            lblRating.TabIndex = 5;
            lblRating.Text = "Rating";
            // 
            // lblRatingCount
            // 
            lblRatingCount.AutoSize = true;
            lblRatingCount.Location = new Point(85, 411);
            lblRatingCount.Name = "lblRatingCount";
            lblRatingCount.Size = new Size(21, 23);
            lblRatingCount.TabIndex = 6;
            lblRatingCount.Text = "0";
            // 
            // CommentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(394, 442);
            Controls.Add(lblRatingCount);
            Controls.Add(lblRating);
            Controls.Add(btnDownVoteComment);
            Controls.Add(btnUpVoteComment);
            Controls.Add(richTextBoxCommentText);
            Controls.Add(lblUsersComment);
            Controls.Add(lblUsersPost);
            Font = new Font("Arial", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CommentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CommentForm";
            Load += CommentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsersPost;
        private Label lblUsersComment;
        private RichTextBox richTextBoxCommentText;
        private Button btnUpVoteComment;
        private Button btnDownVoteComment;
        private Label lblRating;
        private Label lblRatingCount;
    }
}