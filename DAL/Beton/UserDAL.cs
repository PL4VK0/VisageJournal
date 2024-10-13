using DAL.Abstract;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Beton
{
    public class UserDAL : IUserDAL
    {
        private readonly IMongoCollection<User> _collection;

        public UserDAL(IMongoCollection<User> collection)
        { _collection = collection; }
        public void Add(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName))
                throw new Exception("FirstName is mandatory!");

            if (string.IsNullOrWhiteSpace(user.LastName))
                throw new Exception("LastName is mandatory!");

            if (string.IsNullOrWhiteSpace(user.UserName))
                throw new Exception("UserName is mandatory!");

            if (string.IsNullOrWhiteSpace(user.Email))
                throw new Exception("Email is mandatory!");

            if (string.IsNullOrWhiteSpace(user.Password))
                throw new Exception("Password is mandatory!");
            if (user.Interests.Count==0||user.Interests==null)
                throw new Exception("Interests are mandatory!");



            //var filter = Builders<BsonDocument>.Filter.Eq("email",user.Email);
            //var document = _collection.Find(filter).FirstOrDefault();
            if(_collection.Find<User>( u=>u.Email==user.Email).FirstOrDefault()!=null)
                throw new Exception("There is already someone with this E-mail!");
            _collection.InsertOne(user);
            return;
            //filter = Builders<BsonDocument>.Filter.Empty;
            //var sort = Builders<BsonDocument>.Sort.Descending("_id");
            //var lastUser = _collection.Find<BsonDocument>(filter).Sort(sort).FirstOrDefault();
            //var newID = 1;
            //if (lastUser != null)
            //    newID = lastUser["_id"].AsInt32 + 1;
            //BsonDocument newUser = new BsonDocument
            //{
            //    { "_id",newID },
            //    {"firstName",user.FirstName },
            //    {"lastName",user.LastName },
            //    {"userName",user.UserName },
            //    {"address",user.Address },
            //    {"interests",user.Interests },
            //    {"followerIDs",user.FollowerIDs },
            //    {"followingIDs",user.FollowingIDs },
            //    {"email",user.Email },
            //    {"password",user.Password },
            //    {"postIDs",user.PostIDs },
            //    {"commentIDs",user.CommentIDs }
            //};
            //_collection.InsertOne(newUser);
        }

        public void DeleteByID(string ID)
        {
            //var filter = Builders<BsonDocument>.Filter.Eq("_id", ID);
            //var doc = _collection.Find(filter).FirstOrDefault();

            //if (doc == null)
            //    return false;
            //_collection.DeleteOne(filter); 
            //return true;
            User userToDelete = _collection.Find<User>(u => u.UserID == ID).FirstOrDefault();
            _collection.DeleteOne(ID);
        }

        public User GetByID(string ID)
        {
            return _collection.Find<User>(u => u.UserID == ID).FirstOrDefault();
            //var filter = Builders<BsonDocument>.Filter.Eq("_id", ID);
            //var doc = _collection.Find(filter).FirstOrDefault();

            //if (doc == null)
            //    return null;

            //User user = new User();

            //user.UserID = doc["_id"].AsInt32;
            //user.UserName = doc["userName"].AsString;
            //user.FirstName = doc["firstName"].AsString;
            //user.LastName = doc["lastName"].AsString;
            //user.Email = doc["email"].AsString;
            //user.Password = doc["password"].AsString;
            //user.Interests = doc["interests"].AsBsonArray;
            //user.Address = doc["address"].AsBsonDocument;
            //user.FollowerIDs = doc["followerIDs"].AsBsonArray;
            //user.FollowingIDs = doc["followingIDs"].AsBsonArray;
            //user.PostIDs = doc["postIDs"].AsBsonArray;
            //user.CommentIDs = doc["commentIDs"].AsBsonArray;

            //return user;
        }
        public List<User> GetAll()
        {
            var filter = Builders<User>.Filter.Empty;
            return _collection.Find(filter).ToList();



            //var filter = Builders<BsonDocument>.Filter.Empty;
            //var documents = _collection.Find(filter).ToList();

            //var users = new List<User>();

            //foreach (var doc in documents)
            //{
            //    User user = new User();

            //    user.UserID = doc["_id"].AsInt32;
            //    user.UserName = doc["userName"].AsString;
            //    user.FirstName = doc["firstName"].AsString;
            //    user.LastName = doc["lastName"].AsString;
            //    user.Email = doc["email"].AsString;
            //    user.Password = doc["password"].AsString;
            //    user.Interests = doc["interests"].AsBsonArray;
            //    user.Address = doc["address"].AsBsonDocument;
            //    user.FollowerIDs = doc["followerIDs"].AsBsonArray;
            //    user.FollowingIDs = doc["followingIDs"].AsBsonArray;
            //    user.PostIDs = doc["postIDs"].AsBsonArray;
            //    user.CommentIDs = doc["commentIDs"].AsBsonArray;

            //    users.Add(user);
            //}
            //return users;
        }


        public void Update(User user)
        {
            //_collection.UpdateOne(user.UserID,user);

            var update = Builders<User>.Update.
                Set(u => u.UserID, user.UserID).
                Set(u => u.FirstName, user.FirstName).
                Set(u => u.LastName, user.LastName).
                Set(u => u.UserName, user.UserName).
                Set(u => u.Email, user.Email).
                Set(u => u.Password, user.Password).
                Set(u => u.Address, user.Address).
                Set(u => u.CommentIDs, user.CommentIDs).
                Set(u => u.PostIDs, user.PostIDs).
                Set(u => u.Interests, user.Interests).
                Set(u => u.FollowerIDs, user.FollowerIDs).
                Set(u => u.FollowingIDs, user.FollowingIDs);
        }

        public User SignIn(string emailOrUserName, string password)
        {
            //checking email
            //var filter = Builders<BsonDocument>.Filter.Eq("email", emailOrUserName);
            //var document = _collection.Find<BsonDocument>(filter).FirstOrDefault();
            User userToSignIn = _collection.Find(u => u.Email == emailOrUserName).FirstOrDefault();
            if (userToSignIn == null)
            {
                //checking uN
                //filter = Builders<BsonDocument>.Filter.Eq("userName", emailOrUserName);
                //document = _collection.Find<BsonDocument>(filter).FirstOrDefault();
                userToSignIn = _collection.Find(u => u.UserName == emailOrUserName).FirstOrDefault();
                if (userToSignIn == null)
                    throw new Exception("There is no one with this Email or UserName!");
            }

            if (userToSignIn.Password!=password)//(document["password"].AsString != password)
                throw new Exception("WRONG PASSWORD!!!");
            return userToSignIn;
        }

        public void Follow(string idThatFollows, string idToFollow)
        {
            //var filterThatFollows = Builders<BsonDocument>.Filter.Eq("_id", idThatFollows);
            //var docThatFollows = _collection.Find(filterThatFollows).FirstOrDefault();
            User userThatFollows = _collection.Find(u => u.UserID==idThatFollows).FirstOrDefault();
            if (userThatFollows == null)
                throw new Exception("The unexisting user is trying to follow someone");

            if (idThatFollows == idToFollow)
                throw new Exception("You can't follow yourself! (but you can follow your dreams...)");

            if (userThatFollows.FollowingIDs.Contains(idToFollow))
                throw new Exception("This user is already followed by you!");



            //var filterToFollow = Builders<BsonDocument>.Filter.Eq("_id", idToFollow);
            //var docToFollow = _collection.Find(filterToFollow).FirstOrDefault();

            User userToFollow = _collection.Find(u => u.UserID== idToFollow).FirstOrDefault();
            if (userToFollow == null)
                throw new Exception("You can't follow an unexisting user!");

            userThatFollows.FollowingIDs.Add(idToFollow);
            userToFollow.FollowerIDs.Add(idThatFollows);

            var updateThatFollows = Builders<User>.Update
                .Set(u => u.FollowingIDs, userThatFollows.FollowingIDs);
            var updateToFollow = Builders<User>.Update
                .Set(u => u.FollowerIDs, userToFollow.FollowerIDs);
            //var update = Builders<User>.Filter<User>(u=>
            //BsonArray followingIDs = docThatFollows["followingIDs"].AsBsonArray;
            //BsonArray followerIDs = docToFollow["followerIDs"].AsBsonArray;

            //followingIDs.Add(idToFollow);
            //followerIDs.Add(idThatFollows);
            //var updateThatFollows = Builders<BsonDocument>.Update.Set("followingIDs", followingIDs);
            //var updateToFollow = Builders<BsonDocument>.Update.Set("followerIDs", followerIDs);

            _collection.UpdateOne(userThatFollows.UserID,updateThatFollows);
            _collection.UpdateOne(userToFollow.UserID, updateToFollow);
        }
    }
}
