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
            btnSignIn = new Button();
            btnBeginSignUp = new Button();
            lblNoAccount = new Label();
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
            // btnSignIn
            // 
            btnSignIn.Location = new Point(311, 189);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(159, 29);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            // 
            // btnBeginSignUp
            // 
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
            lblNoAccount.Location = new Point(296, 270);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(187, 20);
            lblNoAccount.TabIndex = 4;
            lblNoAccount.Text = "Don't have an account yet?";
            // 
            // VJ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNoAccount);
            Controls.Add(btnBeginSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(lblVisageJournal);
            Name = "VJ";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisageJournal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVisageJournal;
        private Button btnSignIn;
        private Button btnBeginSignUp;
        private Label lblNoAccount;
    }
}
