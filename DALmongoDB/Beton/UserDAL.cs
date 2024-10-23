using DALmongoDB.Abstract;
using DTO;
using MongoDB.Driver;

namespace DALmongoDB.Beton
{
    public class UserDAL : IUserDAL
    {
        private readonly IMongoCollection<User> collection;

        public UserDAL(IMongoCollection<User> collection)
        { this.collection = collection; }
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
            if (collection.Find(u => u.UserName == user.UserName).FirstOrDefault() != null)
                throw new Exception("There is already someone with this UserName!");
            if (collection.Find( u=>u.Email==user.Email).FirstOrDefault()!=null)
                throw new Exception("There is already someone with this E-mail!");

            user.UserName = user.UserName.ToUpper();

            collection.InsertOne(user);
        }

        public void DeleteByID(string ID)
        {
            User userToDelete = collection.Find<User>(u => u.UserID == ID).FirstOrDefault();
            collection.DeleteOne(ID);
        }

        public User GetByID(string ID)
        {
            return collection.Find<User>(u => u.UserID == ID).FirstOrDefault();
        }
        public List<User> GetAll()
        {
            var filter = Builders<User>.Filter.Empty;
            return collection.Find(filter).ToList();
        }


        public void Update(User user)
        {
            var filter = Builders<User>.Filter.Eq(u=>u.UserID,user.UserID);
            var update = Builders<User>.Update.
                Set(u => u.UserID, user.UserID).
                Set(u => u.FirstName, user.FirstName).
                Set(u => u.LastName, user.LastName).
                Set(u => u.UserName, user.UserName).
                Set(u => u.Email, user.Email).
                Set(u => u.Password, user.Password).
                Set(u => u.Address, user.Address).
                Set(u => u.Interests, user.Interests).
                Set(u => u.FollowerIDs, user.FollowerIDs).
                Set(u => u.FollowingIDs, user.FollowingIDs);
            collection.UpdateOne(filter, update);
        }
    }
}
