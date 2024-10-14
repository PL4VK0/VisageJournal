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
            lblRegistration = new Label();
            SuspendLayout();
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(111, 48);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(125, 27);
            txtBoxFirstName.TabIndex = 0;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(111, 81);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(125, 27);
            txtBoxLastName.TabIndex = 1;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Location = new Point(111, 114);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(125, 27);
            txtBoxUserName.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(111, 147);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(125, 27);
            txtBoxEmail.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(111, 180);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(125, 27);
            txtBoxPassword.TabIndex = 4;
            // 
            // txtBoxInterests
            // 
            txtBoxInterests.Location = new Point(111, 213);
            txtBoxInterests.Name = "txtBoxInterests";
            txtBoxInterests.Size = new Size(125, 27);
            txtBoxInterests.TabIndex = 5;
            // 
            // txtBoxCity
            // 
            txtBoxCity.Location = new Point(111, 270);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(125, 27);
            txtBoxCity.TabIndex = 6;
            // 
            // txtBoxCountry
            // 
            txtBoxCountry.Location = new Point(111, 303);
            txtBoxCountry.Name = "txtBoxCountry";
            txtBoxCountry.Size = new Size(125, 27);
            txtBoxCountry.TabIndex = 7;
            // 
            // txtBoxPlanet
            // 
            txtBoxPlanet.Location = new Point(111, 336);
            txtBoxPlanet.Name = "txtBoxPlanet";
            txtBoxPlanet.Size = new Size(125, 27);
            txtBoxPlanet.TabIndex = 8;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(14, 48);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(86, 18);
            lblFirstName.TabIndex = 9;
            lblFirstName.Text = "FirstName*";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblLastName.Location = new Point(14, 88);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 18);
            lblLastName.TabIndex = 10;
            lblLastName.Text = "LastName*";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblUserName.Location = new Point(12, 121);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(88, 18);
            lblUserName.TabIndex = 11;
            lblUserName.Text = "UserName*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(14, 154);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 18);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-mail*";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(12, 187);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 18);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password*";
            // 
            // lblInterests
            // 
            lblInterests.AutoSize = true;
            lblInterests.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblInterests.Location = new Point(14, 220);
            lblInterests.Name = "lblInterests";
            lblInterests.Size = new Size(77, 18);
            lblInterests.TabIndex = 14;
            lblInterests.Text = "Interests*";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Arial", 9F);
            lblCity.Location = new Point(14, 277);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(33, 17);
            lblCity.TabIndex = 15;
            lblCity.Text = "City";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Arial", 9F);
            lblCountry.Location = new Point(14, 310);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(59, 17);
            lblCountry.TabIndex = 16;
            lblCountry.Text = "Country";
            // 
            // lblPlanet
            // 
            lblPlanet.AutoSize = true;
            lblPlanet.Font = new Font("Arial", 9F);
            lblPlanet.Location = new Point(14, 343);
            lblPlanet.Name = "lblPlanet";
            lblPlanet.Size = new Size(49, 17);
            lblPlanet.TabIndex = 17;
            lblPlanet.Text = "Planet";
            // 
            // btnEndSignUp
            // 
            btnEndSignUp.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnEndSignUp.Location = new Point(96, 369);
            btnEndSignUp.Name = "btnEndSignUp";
            btnEndSignUp.Size = new Size(156, 29);
            btnEndSignUp.TabIndex = 18;
            btnEndSignUp.Text = "SIGN ME UP NOW!";
            btnEndSignUp.UseVisualStyleBackColor = true;
            btnEndSignUp.Click += btnEndSignUp_Click;
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Old London", 16F);
            lblRegistration.Location = new Point(104, 9);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(132, 30);
            lblRegistration.TabIndex = 19;
            lblRegistration.Text = "Registration";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(327, 410);
            Controls.Add(lblRegistration);
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
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "RegistrationForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
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
        private Label lblRegistration;
    }
}