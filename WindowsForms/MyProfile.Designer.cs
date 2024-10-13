namespace WindowsForms
{
    partial class MyProfile
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
            lblUserName = new Label();
            dgvMyPosts = new DataGridView();
            lblMyProfile = new Label();
            btnDeleteAccount = new Button();
            lblYourPosts = new Label();
            btnBeginPost = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMyPosts).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.Location = new Point(0, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(100, 23);
            lblUserName.TabIndex = 2;
            // 
            // dgvMyPosts
            // 
            dgvMyPosts.BackgroundColor = SystemColors.Control;
            dgvMyPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyPosts.Location = new Point(12, 130);
            dgvMyPosts.Name = "dgvMyPosts";
            dgvMyPosts.RowHeadersWidth = 51;
            dgvMyPosts.Size = new Size(664, 188);
            dgvMyPosts.TabIndex = 1;
            // 
            // lblMyProfile
            // 
            lblMyProfile.AutoSize = true;
            lblMyProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblMyProfile.Location = new Point(12, 23);
            lblMyProfile.Name = "lblMyProfile";
            lblMyProfile.Size = new Size(113, 25);
            lblMyProfile.TabIndex = 3;
            lblMyProfile.Text = "UserName";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(571, 458);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(105, 29);
            btnDeleteAccount.TabIndex = 4;
            btnDeleteAccount.Text = "unregister?";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // lblYourPosts
            // 
            lblYourPosts.AutoSize = true;
            lblYourPosts.Location = new Point(12, 109);
            lblYourPosts.Name = "lblYourPosts";
            lblYourPosts.Size = new Size(92, 18);
            lblYourPosts.TabIndex = 5;
            lblYourPosts.Text = "Your Posts";
            // 
            // btnBeginPost
            // 
            btnBeginPost.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBeginPost.Location = new Point(12, 324);
            btnBeginPost.Name = "btnBeginPost";
            btnBeginPost.Size = new Size(148, 34);
            btnBeginPost.TabIndex = 7;
            btnBeginPost.Text = "Post Something!";
            btnBeginPost.UseVisualStyleBackColor = true;
            btnBeginPost.Click += btnBeginPost_Click;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(688, 499);
            Controls.Add(btnBeginPost);
            Controls.Add(lblYourPosts);
            Controls.Add(btnDeleteAccount);
            Controls.Add(lblMyProfile);
            Controls.Add(dgvMyPosts);
            Controls.Add(lblUserName);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            Name = "MyProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfile";
            Load += MyProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyPosts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private DataGridView dgvMyPosts;
        private Label lblMyProfile;
        private Button btnDeleteAccount;
        private Label lblYourPosts;
        private Button btnBeginPost;
    }
}