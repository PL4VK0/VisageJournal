namespace WindowsForms
{
    partial class SignInForm
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
            lblEmailOrUserName = new Label();
            lblPassword = new Label();
            txtBoxEmailOrUserName = new TextBox();
            txtBoxPassword = new TextBox();
            btnEndSignIn = new Button();
            lblSignIn = new Label();
            SuspendLayout();
            // 
            // lblEmailOrUserName
            // 
            lblEmailOrUserName.AutoSize = true;
            lblEmailOrUserName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEmailOrUserName.Location = new Point(12, 84);
            lblEmailOrUserName.Name = "lblEmailOrUserName";
            lblEmailOrUserName.Size = new Size(142, 18);
            lblEmailOrUserName.TabIndex = 0;
            lblEmailOrUserName.Text = "E-Mail || UserName";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPassword.Location = new Point(12, 122);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 18);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtBoxEmailOrUserName
            // 
            txtBoxEmailOrUserName.Location = new Point(160, 75);
            txtBoxEmailOrUserName.Name = "txtBoxEmailOrUserName";
            txtBoxEmailOrUserName.Size = new Size(148, 27);
            txtBoxEmailOrUserName.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(159, 113);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '?';
            txtBoxPassword.Size = new Size(148, 27);
            txtBoxPassword.TabIndex = 3;
            // 
            // btnEndSignIn
            // 
            btnEndSignIn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEndSignIn.Location = new Point(105, 163);
            btnEndSignIn.Name = "btnEndSignIn";
            btnEndSignIn.Size = new Size(164, 29);
            btnEndSignIn.TabIndex = 4;
            btnEndSignIn.Text = "SIGN ME IN NOW!";
            btnEndSignIn.UseVisualStyleBackColor = true;
            btnEndSignIn.Click += btnEndSignIn_Click;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Old London", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignIn.Location = new Point(135, 23);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(96, 30);
            lblSignIn.TabIndex = 5;
            lblSignIn.Text = "Sign In";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(380, 213);
            Controls.Add(lblSignIn);
            Controls.Add(btnEndSignIn);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxEmailOrUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblEmailOrUserName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignIn";
            Load += SignInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmailOrUserName;
        private Label lblPassword;
        private TextBox txtBoxEmailOrUserName;
        private TextBox txtBoxPassword;
        private Button btnEndSignIn;
        private Label lblSignIn;
    }
}