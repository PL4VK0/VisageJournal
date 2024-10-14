namespace WindowsForms
{
    partial class WritePostForm
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
            lblPostTitle = new Label();
            lblPostText = new Label();
            btnEndPost = new Button();
            textBoxPostTitle = new TextBox();
            richTextBoxPostText = new RichTextBox();
            SuspendLayout();
            // 
            // lblPostTitle
            // 
            lblPostTitle.AutoSize = true;
            lblPostTitle.Location = new Point(28, 57);
            lblPostTitle.Name = "lblPostTitle";
            lblPostTitle.Size = new Size(112, 25);
            lblPostTitle.TabIndex = 0;
            lblPostTitle.Text = "Post Title*";
            // 
            // lblPostText
            // 
            lblPostText.AutoSize = true;
            lblPostText.Location = new Point(28, 111);
            lblPostText.Name = "lblPostText";
            lblPostText.Size = new Size(113, 25);
            lblPostText.TabIndex = 1;
            lblPostText.Text = "Post Text*";
            // 
            // btnEndPost
            // 
            btnEndPost.Location = new Point(28, 433);
            btnEndPost.Name = "btnEndPost";
            btnEndPost.Size = new Size(172, 32);
            btnEndPost.TabIndex = 2;
            btnEndPost.Text = "postThisNOW!";
            btnEndPost.UseVisualStyleBackColor = true;
            btnEndPost.Click += btnEndPost_Click;
            // 
            // textBoxPostTitle
            // 
            textBoxPostTitle.Location = new Point(147, 54);
            textBoxPostTitle.Name = "textBoxPostTitle";
            textBoxPostTitle.Size = new Size(592, 30);
            textBoxPostTitle.TabIndex = 3;
            textBoxPostTitle.Text = "SomeTitle";
            // 
            // richTextBoxPostText
            // 
            richTextBoxPostText.Font = new Font("Microsoft Sans Serif", 10F);
            richTextBoxPostText.Location = new Point(147, 108);
            richTextBoxPostText.Name = "richTextBoxPostText";
            richTextBoxPostText.Size = new Size(592, 286);
            richTextBoxPostText.TabIndex = 4;
            richTextBoxPostText.Text = "";
            // 
            // WritePostForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(751, 491);
            Controls.Add(richTextBoxPostText);
            Controls.Add(textBoxPostTitle);
            Controls.Add(btnEndPost);
            Controls.Add(lblPostText);
            Controls.Add(lblPostTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "WritePostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Post Creation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPostTitle;
        private Label lblPostText;
        private Button btnEndPost;
        private TextBox textBoxPostTitle;
        private RichTextBox richTextBoxPostText;
    }
}