using BusinessLogic;
using DAL.Beton;
using DTO;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class SignInForm : Form
    {

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEndSignIn_Click(object sender, EventArgs e)
        {
            string emailOrUserName = txtBoxEmailOrUserName.Text;
            string password = txtBoxPassword.Text;
            try
            {
                VJ.userOptions.SignIn(emailOrUserName, password);
                MessageBox.Show("SIGN IN SUCCESSFUL!", "NO ERROR", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "SIGN IN FAILED!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand); }
        }
    }
}
