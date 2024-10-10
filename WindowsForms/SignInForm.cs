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
        UserDAL uDAL;
        public BsonDocument signedIn;
        public SignInForm()
        {
            InitializeComponent();
            IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("config.json")
        .Build();
            IMongoClient client = new MongoClient(config.GetConnectionString("VisageJournal"));
            IMongoDatabase db = client.GetDatabase("test");
            IMongoCollection<BsonDocument> userCollecion = db.GetCollection<BsonDocument>("Users");
            uDAL = new UserDAL(userCollecion);
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
                signedIn = uDAL.SignIn(emailOrUserName, password);
                MessageBox.Show("SIGN IN SUCCESSFUL!", "NO ERROR", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "SIGN IN FAILED!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand); }
        }
    }
}
