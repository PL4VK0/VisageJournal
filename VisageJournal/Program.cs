using DALmongoDB.Beton;
using DALneo4j;
using DTO;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using Neo4j.Driver;
using VisageJournal;
IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("config.json").Build();
string connectionString = config.GetConnectionString("VisageJournal");

IMongoClient client = new MongoClient(connectionString);

IMongoDatabase db = client.GetDatabase("test");
var userCollection = db.GetCollection<User>("Users");
var postCollection = db.GetCollection<Post>("Posts");
var commentCollection = db.GetCollection<Comment>("Comments");

UserDAL uDal = new UserDAL(userCollection);

PostDAL postDAL = new PostDAL(postCollection);

CommentDAL commentDAL = new CommentDAL(commentCollection);


/*Dictionary<string, object> data1 = new Dictionary<string, object>
{
    {
        "id",0
    }
};
Dictionary<string, object> data2 = new Dictionary<string, object>
{
    {
        "id",1
    }
};
*/

/*
var filter = Builders<User>.Filter.Empty;
var userList = uDal.GetAll();
foreach (var user in userList)
{
    user.UserName = user.UserName.ToUpper();
    uDal.Update(user);
}
IDriver driver = GraphDatabase.Driver("neo4j+s://81ba7aa4.databases.neo4j.io", AuthTokens.Basic("neo4j", "vLTbyIDajDgR9zpPMa4pxD3bYlivHkJC5OZOTyYfG9s"));
await using (var session = driver.AsyncSession())
    session.RunAsync("create (u:User {name: 'yaroslav', hobby: 'swimming'})");
*/

//just added all of the users and relations
///*    tout est facile!
Neo4JCommands neoCMD = new Neo4JCommands("neo4j+s://81ba7aa4.databases.neo4j.io", "neo4j", "vLTbyIDajDgR9zpPMa4pxD3bYlivHkJC5OZOTyYfG9s");
List<User> users = uDal.GetAll();
await TransferUsersFromMongoToNeo.DoTheThing(users);
//*/

/*
List<string> interests = new List<string>();
foreach (var interest in users[0].Interests)
{
    interests.Add(interest.AsString);
}
*/

/*
var dictUser = new Dictionary<string, object>
{
    { "userName", users[0].UserName },
    { "firstName", users[0].FirstName },
    { "lastName", users[0].LastName},
    {"email", users[0].Email },
    {"interests", interests}
};
await neoCMD.CreateNode("User", dictUser);
dictUser.Add("userName", users[0].UserName);
dictUser.Add("firstName", users[0].FirstName);
dictUser.Add("lastName", users[0].LastName);
dictUser.Add("email", users[0].Email);
dictUser.Add("interests", users[0].Interests);
await neoCMD.CreateNode("User", new Dictionary<string, object>
{
    {
        "name", "sophie"
    },
    {
        "hobby","maths"
    }
});
*/
return 42;

/*
Comment comment = new Comment
{
    PostID = 1,
    CommentText = "testComment",
    CommentatorID = 1,
    UpVotes = new BsonArray(1),
    DownVotes = new BsonArray(2)
};

commentDAL.Add(comment);
*/

/*Post post = new Post
{
    PosterID = 1,
    PostText = "testText",
    PostTitle = "testTitle"
};
postDAL.Add(post);
*/



/*try
{
    dal.Follow(1, 1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/


/*User user = new User
{
    FirstName = "Pasha",
    LastName = "Ahsap",
    Email = "email@gmail.com",
    Password = "password",
    UserName = "Mitsu",
    Interests = new BsonArray
    {
        {"Hacking"},
        {"Jogging" },
        {"Joking" },
        {"Running" }
    }
};
dal.Add(user)
Console.WriteLine(uDal.GetByID(2));
*/

/*
var somethign = new BsonDocument
{
    {
        "_id","2"
    },
    {
        "nothign","nothing"
    }
};

collection.InsertOne(somethign);
Console.WriteLine("Connected successfully!");
*/