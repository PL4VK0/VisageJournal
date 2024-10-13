namespace WindowsForms
{
    partial class VJ
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblVisageJournal = new Label();
            btnBeginSignIn = new Button();
            btnBeginSignUp = new Button();
            lblNoAccount = new Label();
            dgvPosts = new DataGridView();
            btnMyProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPosts).BeginInit();
            SuspendLayout();
            // 
            // lblVisageJournal
            // 
            lblVisageJournal.AutoSize = true;
            lblVisageJournal.Font = new Font("Old London", 32F, FontStyle.Italic);
            lblVisageJournal.Location = new Point(242, 24);
            lblVisageJournal.Name = "lblVisageJournal";
            lblVisageJournal.Size = new Size(305, 62);
            lblVisageJournal.TabIndex = 0;
            lblVisageJournal.Text = "VisageJournal";
            lblVisageJournal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBeginSignIn
            // 
            btnBeginSignIn.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnBeginSignIn.Location = new Point(311, 189);
            btnBeginSignIn.Name = "btnBeginSignIn";
            btnBeginSignIn.Size = new Size(159, 29);
            btnBeginSignIn.TabIndex = 2;
            btnBeginSignIn.Text = "Sign In";
            btnBeginSignIn.UseVisualStyleBackColor = true;
            btnBeginSignIn.Click += btnSignIn_Click;
            // 
            // btnBeginSignUp
            // 
            btnBeginSignUp.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnBeginSignUp.Location = new Point(311, 293);
            btnBeginSignUp.Name = "btnBeginSignUp";
            btnBeginSignUp.Size = new Size(159, 29);
            btnBeginSignUp.TabIndex = 3;
            btnBeginSignUp.Text = "Sign Up";
            btnBeginSignUp.UseVisualStyleBackColor = true;
            btnBeginSignUp.Click += btnSignUp_Click;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Old English Text MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoAccount.Location = new Point(280, 266);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(236, 24);
            lblNoAccount.TabIndex = 4;
            lblNoAccount.Text = "Don't have an account yet?";
            // 
            // dgvPosts
            // 
            dgvPosts.BackgroundColor = SystemColors.ButtonFace;
            dgvPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPosts.Location = new Point(12, 134);
            dgvPosts.Name = "dgvPosts";
            dgvPosts.RowHeadersWidth = 51;
            dgvPosts.Size = new Size(458, 247);
            dgvPosts.TabIndex = 5;
            // 
            // btnMyProfile
            // 
            btnMyProfile.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMyProfile.Location = new Point(12, 94);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(148, 34);
            btnMyProfile.TabIndex = 7;
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // VJ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMyProfile);
            Controls.Add(dgvPosts);
            Controls.Add(lblNoAccount);
            Controls.Add(btnBeginSignUp);
            Controls.Add(btnBeginSignIn);
            Controls.Add(lblVisageJournal);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "VJ";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisageJournal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPosts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVisageJournal;
        private Button btnBeginSignIn;
        private Button btnBeginSignUp;
        private Label lblNoAccount;
        private DataGridView dgvPosts;
        private Button btnMyProfile;
    }
}
