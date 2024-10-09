using DAL.Beton;
using DTO;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsForms
{
    public partial class VJ : Form
    {

        BsonDocument user;
        UserDAL uDAL;
        public VJ()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //btnSignIn.Hide();
            //lblNoAccount.Hide();
            //btnBeginSignUp.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
            user = signInForm.signedIn;
        }
    }
}
