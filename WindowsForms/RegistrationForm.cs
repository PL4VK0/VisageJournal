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
    public partial class RegistrationForm : Form
    {
        UserDAL uDAL;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json")
                .Build();
            IMongoClient client = new MongoClient(config.GetConnectionString("VisageJournal"));
            IMongoDatabase db = client.GetDatabase("test");
            IMongoCollection<BsonDocument> userCollecion = db.GetCollection<BsonDocument>("Users");
            uDAL = new UserDAL(userCollecion);
        }

        private void btnEndSignUp_Click(object sender, EventArgs e)
        {
            User userToRegister = new User();
            userToRegister.FirstName = txtBoxFirstName.Text;
            userToRegister.LastName = txtBoxLastName.Text;
            userToRegister.UserName = txtBoxUserName.Text;
            userToRegister.Email = txtBoxEmail.Text;
            userToRegister.Password = txtBoxPassword.Text;
            
            BsonArray interestArray = new BsonArray();
            List<string> interestList = txtBoxInterests.Text.Split(' ').ToList();
            for(int i = 0; i < interestList.Count; i++)
            {
                if (string.IsNullOrEmpty(interestList[i]))
                {
                    interestList.RemoveAt(i);
                    continue;
                }
                interestArray.Add(interestList[i].Trim());
            }
            userToRegister.Interests = interestArray;

            try { uDAL.Add(userToRegister); }
            catch(Exception ex) { MessageBox.Show(ex.Message, "REGISTRATION FAILED!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand); }

            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxUserName.Clear();
            txtBoxEmail.Clear();
            txtBoxPassword.Clear();
            txtBoxInterests.Clear();

            txtBoxCity.Clear();
            txtBoxCountry.Clear();
            txtBoxPlanet.Clear();
        }
    }
}
