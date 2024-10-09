namespace WindowsForms
{
    partial class RegistrationForm
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
            txtBoxFirstName = new TextBox();
            txtBoxLastName = new TextBox();
            txtBoxUserName = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxPassword = new TextBox();
            txtBoxInterests = new TextBox();
            txtBoxCity = new TextBox();
            txtBoxCountry = new TextBox();
            txtBoxPlanet = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblUserName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblInterests = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            lblPlanet = new Label();
            btnEndSignUp = new Button();
            SuspendLayout();
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(140, 102);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(125, 27);
            txtBoxFirstName.TabIndex = 0;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(140, 135);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(125, 27);
            txtBoxLastName.TabIndex = 1;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Location = new Point(140, 168);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(125, 27);
            txtBoxUserName.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(140, 201);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(125, 27);
            txtBoxEmail.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(140, 234);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(125, 27);
            txtBoxPassword.TabIndex = 4;
            // 
            // txtBoxInterests
            // 
            txtBoxInterests.Location = new Point(140, 267);
            txtBoxInterests.Name = "txtBoxInterests";
            txtBoxInterests.Size = new Size(125, 27);
            txtBoxInterests.TabIndex = 5;
            // 
            // txtBoxCity
            // 
            txtBoxCity.Location = new Point(140, 335);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(125, 27);
            txtBoxCity.TabIndex = 6;
            // 
            // txtBoxCountry
            // 
            txtBoxCountry.Location = new Point(140, 368);
            txtBoxCountry.Name = "txtBoxCountry";
            txtBoxCountry.Size = new Size(125, 27);
            txtBoxCountry.TabIndex = 7;
            // 
            // txtBoxPlanet
            // 
            txtBoxPlanet.Location = new Point(140, 401);
            txtBoxPlanet.Name = "txtBoxPlanet";
            txtBoxPlanet.Size = new Size(125, 27);
            txtBoxPlanet.TabIndex = 8;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(58, 105);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 20);
            lblFirstName.TabIndex = 9;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(58, 135);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 10;
            lblLastName.Text = "LastName";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(58, 171);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(78, 20);
            lblUserName.TabIndex = 11;
            lblUserName.Text = "UserName";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(58, 204);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-mail";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(58, 237);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // lblInterests
            // 
            lblInterests.AutoSize = true;
            lblInterests.Location = new Point(58, 270);
            lblInterests.Name = "lblInterests";
            lblInterests.Size = new Size(64, 20);
            lblInterests.TabIndex = 14;
            lblInterests.Text = "Interests";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(58, 338);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 20);
            lblCity.TabIndex = 15;
            lblCity.Text = "City";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(58, 371);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(60, 20);
            lblCountry.TabIndex = 16;
            lblCountry.Text = "Country";
            // 
            // lblPlanet
            // 
            lblPlanet.AutoSize = true;
            lblPlanet.Location = new Point(58, 404);
            lblPlanet.Name = "lblPlanet";
            lblPlanet.Size = new Size(50, 20);
            lblPlanet.TabIndex = 17;
            lblPlanet.Text = "Planet";
            // 
            // btnEndSignUp
            // 
            btnEndSignUp.Location = new Point(441, 399);
            btnEndSignUp.Name = "btnEndSignUp";
            btnEndSignUp.Size = new Size(156, 29);
            btnEndSignUp.TabIndex = 18;
            btnEndSignUp.Text = "SIGN ME UP NOW!";
            btnEndSignUp.UseVisualStyleBackColor = true;
            btnEndSignUp.Click += btnEndSignUp_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEndSignUp);
            Controls.Add(lblPlanet);
            Controls.Add(lblCountry);
            Controls.Add(lblCity);
            Controls.Add(lblInterests);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUserName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtBoxPlanet);
            Controls.Add(txtBoxCountry);
            Controls.Add(txtBoxCity);
            Controls.Add(txtBoxInterests);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxUserName);
            Controls.Add(txtBoxLastName);
            Controls.Add(txtBoxFirstName);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxFirstName;
        private TextBox txtBoxLastName;
        private TextBox txtBoxUserName;
        private TextBox txtBoxEmail;
        private TextBox txtBoxPassword;
        private TextBox txtBoxInterests;
        private TextBox txtBoxCity;
        private TextBox txtBoxCountry;
        private TextBox txtBoxPlanet;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUserName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblInterests;
        private Label lblCity;
        private Label lblCountry;
        private Label lblPlanet;
        private Button btnEndSignUp;
    }
}