namespace WindowsForms
{
    partial class UnRegisterForm
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
            lblDoYouWantToDeleteYourAcc = new Label();
            btnBeginUnRegister = new Button();
            btnNO = new Button();
            lblPassword = new Label();
            textBoxPassword = new TextBox();
            btnEndUnRegister = new Button();
            SuspendLayout();
            // 
            // lblDoYouWantToDeleteYourAcc
            // 
            lblDoYouWantToDeleteYourAcc.AutoSize = true;
            lblDoYouWantToDeleteYourAcc.Location = new Point(47, 9);
            lblDoYouWantToDeleteYourAcc.Name = "lblDoYouWantToDeleteYourAcc";
            lblDoYouWantToDeleteYourAcc.Size = new Size(154, 25);
            lblDoYouWantToDeleteYourAcc.TabIndex = 0;
            lblDoYouWantToDeleteYourAcc.Text = "UnRegister???";
            // 
            // btnBeginUnRegister
            // 
            btnBeginUnRegister.Location = new Point(41, 37);
            btnBeginUnRegister.Name = "btnBeginUnRegister";
            btnBeginUnRegister.Size = new Size(77, 38);
            btnBeginUnRegister.TabIndex = 1;
            btnBeginUnRegister.Text = "yes?";
            btnBeginUnRegister.UseVisualStyleBackColor = true;
            btnBeginUnRegister.Click += btnBeginUnRegister_Click;
            // 
            // btnNO
            // 
            btnNO.Location = new Point(124, 37);
            btnNO.Name = "btnNO";
            btnNO.Size = new Size(77, 38);
            btnNO.TabIndex = 2;
            btnNO.Text = "NO!";
            btnNO.UseVisualStyleBackColor = true;
            btnNO.Click += btnNO_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(215, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "enter your password(";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 168);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '/';
            textBoxPassword.Size = new Size(215, 30);
            textBoxPassword.TabIndex = 4;
            // 
            // btnEndUnRegister
            // 
            btnEndUnRegister.Location = new Point(49, 204);
            btnEndUnRegister.Name = "btnEndUnRegister";
            btnEndUnRegister.Size = new Size(126, 44);
            btnEndUnRegister.TabIndex = 5;
            btnEndUnRegister.Text = "unregister(";
            btnEndUnRegister.UseVisualStyleBackColor = true;
            btnEndUnRegister.Click += btnEndUnRegister_Click;
            // 
            // UnRegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(242, 275);
            Controls.Add(btnEndUnRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnNO);
            Controls.Add(btnBeginUnRegister);
            Controls.Add(lblDoYouWantToDeleteYourAcc);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "UnRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UnRegisterForm";
            Load += UnRegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDoYouWantToDeleteYourAcc;
        private Button btnBeginUnRegister;
        private Button btnNO;
        private Label lblPassword;
        private TextBox textBoxPassword;
        private Button btnEndUnRegister;
    }
}