using DAL.Beton;
using DTO;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("config.json").Build();
string connectionString = config.GetConnectionString("VisageJournal");

IMongoClient client = new MongoClient(connectionString);

IMongoDatabase db = client.GetDatabase("test");
//db.CreateCollection("Comments");
var userCollection = db.GetCollection<User>("Users");
var postCollection = db.GetCollection<Post>("Posts");
var commentCollection = db.GetCollection<Comment>("Comments");
UserDAL uDal = new UserDAL(userCollection);

PostDAL postDAL = new PostDAL(postCollection);

CommentDAL commentDAL = new CommentDAL(commentCollection);

//Comment comment = new Comment
//{
//    PostID = 1,
//    CommentText = "testComment",
//    CommentatorID = 1,
//    UpVotes = new BsonArray(1),
//    DownVotes = new BsonArray(2)
//};

//commentDAL.Add(comment);
//Post post = new Post
//{
//    PosterID = 1,
//    PostText = "testText",
//    PostTitle = "testTitle"
//};
//postDAL.Add(post);
//try
//{
//    dal.Follow(1, 1);
//}catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//User user = new User
//{
//    FirstName = "Pasha",
//    LastName = "Ahsap",
//    Email = "email@gmail.com",
//    Password = "password",
//    UserName = "Mitsu",
//    Interests = new BsonArray
//    {
//        {"Hacking"},
//        {"Jogging" },
//        {"Joking" },
//        {"Running" }
//    }
//};
//dal.Add(user);
return;
    //Console.WriteLine(uDal.GetByID(2));

//var somethign = new BsonDocument
//{
//    {
//        "_id","2"
//    },
//    {
//        "nothign","nothing"
//    }
//};

//collection.InsertOne(somethign);
//Console.WriteLine("Connected successfully!");