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
            lblRecentPosts = new Label();
            dgvUserSearch = new DataGridView();
            btnFindByUserName = new Button();
            textBoxUserName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPosts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserSearch).BeginInit();
            SuspendLayout();
            // 
            // lblVisageJournal
            // 
            lblVisageJournal.AutoSize = true;
            lblVisageJournal.Font = new Font("Old London", 32F, FontStyle.Italic);
            lblVisageJournal.Location = new Point(272, 23);
            lblVisageJournal.Name = "lblVisageJournal";
            lblVisageJournal.Size = new Size(305, 62);
            lblVisageJournal.TabIndex = 0;
            lblVisageJournal.Text = "VisageJournal";
            lblVisageJournal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBeginSignIn
            // 
            btnBeginSignIn.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnBeginSignIn.Location = new Point(350, 179);
            btnBeginSignIn.Margin = new Padding(3, 2, 3, 2);
            btnBeginSignIn.Name = "btnBeginSignIn";
            btnBeginSignIn.Size = new Size(179, 27);
            btnBeginSignIn.TabIndex = 2;
            btnBeginSignIn.Text = "Sign In";
            btnBeginSignIn.UseVisualStyleBackColor = true;
            btnBeginSignIn.Click += btnSignIn_Click;
            // 
            // btnBeginSignUp
            // 
            btnBeginSignUp.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnBeginSignUp.Location = new Point(350, 278);
            btnBeginSignUp.Margin = new Padding(3, 2, 3, 2);
            btnBeginSignUp.Name = "btnBeginSignUp";
            btnBeginSignUp.Size = new Size(179, 27);
            btnBeginSignUp.TabIndex = 3;
            btnBeginSignUp.Text = "Sign Up";
            btnBeginSignUp.UseVisualStyleBackColor = true;
            btnBeginSignUp.Click += btnSignUp_Click;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Old English Text MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoAccount.Location = new Point(315, 253);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(236, 24);
            lblNoAccount.TabIndex = 4;
            lblNoAccount.Text = "Don't have an account yet?";
            // 
            // dgvPosts
            // 
            dgvPosts.AllowUserToAddRows = false;
            dgvPosts.AllowUserToDeleteRows = false;
            dgvPosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPosts.BackgroundColor = SystemColors.ButtonFace;
            dgvPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPosts.Location = new Point(14, 179);
            dgvPosts.Margin = new Padding(3, 2, 3, 2);
            dgvPosts.Name = "dgvPosts";
            dgvPosts.RowHeadersWidth = 51;
            dgvPosts.Size = new Size(515, 235);
            dgvPosts.TabIndex = 5;
            dgvPosts.CellContentDoubleClick += dgvPosts_CellContentDoubleClick;
            // 
            // btnMyProfile
            // 
            btnMyProfile.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMyProfile.Location = new Point(14, 89);
            btnMyProfile.Margin = new Padding(3, 2, 3, 2);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(166, 32);
            btnMyProfile.TabIndex = 7;
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // lblRecentPosts
            // 
            lblRecentPosts.AutoSize = true;
            lblRecentPosts.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblRecentPosts.Location = new Point(14, 149);
            lblRecentPosts.Name = "lblRecentPosts";
            lblRecentPosts.Size = new Size(109, 19);
            lblRecentPosts.TabIndex = 9;
            lblRecentPosts.Text = "RecentPosts";
            // 
            // dgvUserSearch
            // 
            dgvUserSearch.AllowUserToAddRows = false;
            dgvUserSearch.AllowUserToDeleteRows = false;
            dgvUserSearch.AllowUserToResizeColumns = false;
            dgvUserSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUserSearch.BackgroundColor = SystemColors.Control;
            dgvUserSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserSearch.Location = new Point(577, 179);
            dgvUserSearch.Name = "dgvUserSearch";
            dgvUserSearch.RowHeadersWidth = 51;
            dgvUserSearch.Size = new Size(300, 188);
            dgvUserSearch.TabIndex = 10;
            dgvUserSearch.CellContentDoubleClick += dgvUserSearch_CellContentDoubleClick;
            // 
            // btnFindByUserName
            // 
            btnFindByUserName.Location = new Point(577, 144);
            btnFindByUserName.Name = "btnFindByUserName";
            btnFindByUserName.Size = new Size(300, 29);
            btnFindByUserName.TabIndex = 11;
            btnFindByUserName.Text = "Search by UserName";
            btnFindByUserName.UseVisualStyleBackColor = true;
            btnFindByUserName.Click += btnFindByUserName_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(577, 111);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(300, 27);
            textBoxUserName.TabIndex = 12;
            // 
            // VJ
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(900, 428);
            Controls.Add(textBoxUserName);
            Controls.Add(btnFindByUserName);
            Controls.Add(dgvUserSearch);
            Controls.Add(lblRecentPosts);
            Controls.Add(btnMyProfile);
            Controls.Add(dgvPosts);
            Controls.Add(lblNoAccount);
            Controls.Add(btnBeginSignUp);
            Controls.Add(btnBeginSignIn);
            Controls.Add(lblVisageJournal);
            Font = new Font("Arial", 10F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "VJ";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisageJournal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPosts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserSearch).EndInit();
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
        private Label lblRecentPosts;
        private DataGridView dgvUserSearch;
        private Button btnFindByUserName;
        private TextBox textBoxUserName;
    }
}
