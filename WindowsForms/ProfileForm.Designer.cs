﻿namespace WindowsForms
{
    partial class ProfileForm
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
            dgvUserPosts = new DataGridView();
            lblProfileName = new Label();
            btnDeleteAccount = new Button();
            lblUserPosts = new Label();
            btnBeginPost = new Button();
            btnDeletePosts = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserPosts).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.Location = new Point(0, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(100, 23);
            lblUserName.TabIndex = 2;
            // 
            // dgvUserPosts
            // 
            dgvUserPosts.AllowUserToAddRows = false;
            dgvUserPosts.AllowUserToDeleteRows = false;
            dgvUserPosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUserPosts.BackgroundColor = SystemColors.Control;
            dgvUserPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserPosts.Location = new Point(12, 130);
            dgvUserPosts.Name = "dgvUserPosts";
            dgvUserPosts.ReadOnly = true;
            dgvUserPosts.RowHeadersWidth = 51;
            dgvUserPosts.Size = new Size(664, 188);
            dgvUserPosts.TabIndex = 1;
            // 
            // lblProfileName
            // 
            lblProfileName.AutoSize = true;
            lblProfileName.Font = new Font("Old London", 13F, FontStyle.Bold);
            lblProfileName.Location = new Point(12, 23);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(106, 25);
            lblProfileName.TabIndex = 3;
            lblProfileName.Text = "UserName";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(13, 458);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(105, 29);
            btnDeleteAccount.TabIndex = 4;
            btnDeleteAccount.Text = "unregister?";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // lblUserPosts
            // 
            lblUserPosts.AutoSize = true;
            lblUserPosts.Location = new Point(12, 109);
            lblUserPosts.Name = "lblUserPosts";
            lblUserPosts.Size = new Size(88, 18);
            lblUserPosts.TabIndex = 5;
            lblUserPosts.Text = "UserPosts";
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
            // btnDeletePosts
            // 
            btnDeletePosts.Location = new Point(490, 98);
            btnDeletePosts.Name = "btnDeletePosts";
            btnDeletePosts.Size = new Size(186, 29);
            btnDeletePosts.TabIndex = 8;
            btnDeletePosts.Text = "DeleteSelectedPosts";
            btnDeletePosts.UseVisualStyleBackColor = true;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(688, 499);
            Controls.Add(btnDeletePosts);
            Controls.Add(btnBeginPost);
            Controls.Add(lblUserPosts);
            Controls.Add(btnDeleteAccount);
            Controls.Add(lblProfileName);
            Controls.Add(dgvUserPosts);
            Controls.Add(lblUserName);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VJ Profile";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserPosts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private DataGridView dgvUserPosts;
        private Label lblProfileName;
        private Button btnDeleteAccount;
        private Label lblUserPosts;
        private Button btnBeginPost;
        private Button btnDeletePosts;
    }
}