namespace WindowsForms
{
    partial class PostForm
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
            richTextBoxPostText = new RichTextBox();
            lblPostTitle = new Label();
            btnUpVote = new Button();
            btnDownVote = new Button();
            lblUsersPost = new Label();
            lblRating = new Label();
            lblCountRating = new Label();
            dgvPostComments = new DataGridView();
            lblPostComments = new Label();
            btnBeginAddComment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPostComments).BeginInit();
            SuspendLayout();
            // 
            // richTextBoxPostText
            // 
            richTextBoxPostText.Location = new Point(40, 150);
            richTextBoxPostText.Margin = new Padding(4, 3, 4, 3);
            richTextBoxPostText.Name = "richTextBoxPostText";
            richTextBoxPostText.Size = new Size(367, 284);
            richTextBoxPostText.TabIndex = 0;
            richTextBoxPostText.Text = "";
            // 
            // lblPostTitle
            // 
            lblPostTitle.AutoSize = true;
            lblPostTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblPostTitle.Location = new Point(40, 103);
            lblPostTitle.Margin = new Padding(4, 0, 4, 0);
            lblPostTitle.Name = "lblPostTitle";
            lblPostTitle.Size = new Size(63, 29);
            lblPostTitle.TabIndex = 1;
            lblPostTitle.Text = "Title";
            // 
            // btnUpVote
            // 
            btnUpVote.Location = new Point(40, 440);
            btnUpVote.Name = "btnUpVote";
            btnUpVote.Size = new Size(109, 29);
            btnUpVote.TabIndex = 2;
            btnUpVote.Text = "UpVote";
            btnUpVote.UseVisualStyleBackColor = true;
            btnUpVote.Click += btnUpVote_Click;
            // 
            // btnDownVote
            // 
            btnDownVote.Location = new Point(298, 440);
            btnDownVote.Name = "btnDownVote";
            btnDownVote.Size = new Size(109, 29);
            btnDownVote.TabIndex = 3;
            btnDownVote.Text = "DownVote";
            btnDownVote.UseVisualStyleBackColor = true;
            btnDownVote.Click += btnDownVote_Click;
            // 
            // lblUsersPost
            // 
            lblUsersPost.AutoSize = true;
            lblUsersPost.Location = new Point(41, 9);
            lblUsersPost.Name = "lblUsersPost";
            lblUsersPost.Size = new Size(111, 23);
            lblUsersPost.TabIndex = 4;
            lblUsersPost.Text = "User's Post";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(41, 486);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(66, 23);
            lblRating.TabIndex = 5;
            lblRating.Text = "Rating";
            // 
            // lblCountRating
            // 
            lblCountRating.AutoSize = true;
            lblCountRating.Location = new Point(128, 486);
            lblCountRating.Name = "lblCountRating";
            lblCountRating.Size = new Size(21, 23);
            lblCountRating.TabIndex = 6;
            lblCountRating.Text = "0";
            // 
            // dgvPostComments
            // 
            dgvPostComments.AllowUserToAddRows = false;
            dgvPostComments.AllowUserToDeleteRows = false;
            dgvPostComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPostComments.BackgroundColor = SystemColors.Control;
            dgvPostComments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPostComments.Location = new Point(414, 150);
            dgvPostComments.Name = "dgvPostComments";
            dgvPostComments.RowHeadersWidth = 51;
            dgvPostComments.Size = new Size(492, 284);
            dgvPostComments.TabIndex = 7;
            dgvPostComments.CellContentDoubleClick += dgvPostComments_CellContentDoubleClick;
            // 
            // lblPostComments
            // 
            lblPostComments.AutoSize = true;
            lblPostComments.Location = new Point(414, 109);
            lblPostComments.Name = "lblPostComments";
            lblPostComments.Size = new Size(314, 23);
            lblPostComments.TabIndex = 8;
            lblPostComments.Text = "there are no comments (write one)";
            // 
            // btnBeginAddComment
            // 
            btnBeginAddComment.Location = new Point(734, 440);
            btnBeginAddComment.Name = "btnBeginAddComment";
            btnBeginAddComment.Size = new Size(172, 29);
            btnBeginAddComment.TabIndex = 9;
            btnBeginAddComment.Text = "Write a comment";
            btnBeginAddComment.UseVisualStyleBackColor = true;
            btnBeginAddComment.Click += btnBeginAddComment_Click;
            // 
            // PostForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(962, 526);
            Controls.Add(btnBeginAddComment);
            Controls.Add(lblPostComments);
            Controls.Add(dgvPostComments);
            Controls.Add(lblCountRating);
            Controls.Add(lblRating);
            Controls.Add(lblUsersPost);
            Controls.Add(btnDownVote);
            Controls.Add(btnUpVote);
            Controls.Add(lblPostTitle);
            Controls.Add(richTextBoxPostText);
            Font = new Font("Arial", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PostForm";
            Load += PostForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPostComments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxPostText;
        private Label lblPostTitle;
        private Button btnUpVote;
        private Button btnDownVote;
        private Label lblUsersPost;
        private Label lblRating;
        private Label lblCountRating;
        private DataGridView dgvPostComments;
        private Label lblPostComments;
        private Button btnBeginAddComment;
    }
}