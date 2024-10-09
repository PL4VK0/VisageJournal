using DAL.Abstract;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Beton
{
    public class UserDAL : IUserDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public UserDAL(IMongoCollection<BsonDocument> collection)
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
            var filter = Builders<BsonDocument>.Filter.Eq("email",user.Email);
            var document = _collection.Find(filter).FirstOrDefault();
            if (document != null)
                throw new Exception("There is already someone with this E-mail!");

            filter = Builders<BsonDocument>.Filter.Empty;
            var sort = Builders<BsonDocument>.Sort.Descending("_id");
            var newID = _collection.Find(filter).Sort(sort).FirstOrDefault()["_id"].AsInt32 + 1;

            BsonDocument newUser = new BsonDocument
            {
                { "_id",newID },
                {"firstName",user.FirstName },
                {"lastName",user.LastName },
                {"userName",user.UserName },
                {"address",user.Address },
                {"interests",user.Interests },
                {"followerIDs",user.FollowerIDs },
                {"followingIDs",user.FollowingIDs },
                {"email",user.Email },
                {"password",user.Password },
                {"postIDs",user.PostIDs },
                {"commentIDs",user.CommentIDs }
            };
            _collection.InsertOne(newUser);
            return;
        }

        public bool DeleteByID(int ID)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ID);
            var doc = _collection.Find(filter).FirstOrDefault();

            if (doc == null)
                return false;
            _collection.DeleteOne(filter); 
            return true;
        }

        public User GetByID(int ID)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ID);
            var doc = _collection.Find(filter).FirstOrDefault();

            if (doc == null)
                return null;

            User user = new User();

            user.UserID = doc["_id"].AsInt32;
            user.UserName = doc["userName"].AsString;
            user.FirstName = doc["firstName"].AsString;
            user.LastName = doc["lastName"].AsString;
            user.Email = doc["email"].AsString;
            user.Password = doc["password"].AsString;
            user.Interests = doc["interests"].AsBsonArray;
            user.Address = doc["address"].AsBsonDocument;
            user.FollowerIDs = doc["followerIDs"].AsBsonArray;
            user.FollowingIDs = doc["followingIDs"].AsBsonArray;
            user.PostIDs = doc["postIDs"].AsBsonArray;
            user.CommentIDs = doc["commentIDs"].AsBsonArray;

            return user;
        }
        public List<User> GetAll()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = _collection.Find(filter).ToList();

            var users = new List<User>();

            foreach (var doc in documents)
            {
                User user = new User();

                user.UserID = doc["_id"].AsInt32;
                user.UserName = doc["userName"].AsString;
                user.FirstName = doc["firstName"].AsString;
                user.LastName = doc["lastName"].AsString;
                user.Email = doc["email"].AsString;
                user.Password = doc["password"].AsString;
                user.Interests = doc["interests"].AsBsonArray;
                user.Address = doc["address"].AsBsonDocument;
                user.FollowerIDs = doc["followerIDs"].AsBsonArray;
                user.FollowingIDs = doc["followingIDs"].AsBsonArray;
                user.PostIDs = doc["postIDs"].AsBsonArray;
                user.CommentIDs = doc["commentIDs"].AsBsonArray;

                users.Add(user);
            }
            return users;
        }


        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
