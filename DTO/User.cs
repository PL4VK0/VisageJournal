using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DTO
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserID {  get; set; }
        [BsonElement("firstName")]
        public string FirstName { get; set; }
        [BsonElement("lastName")]
        public string LastName { get; set; }
        [BsonElement("userName")]
        public string UserName { get; set; }
        [BsonElement("interests")]
        public BsonArray Interests { get; set; } = new BsonArray();
        [BsonElement("address")]
        public BsonDocument Address { get; set; } = new BsonDocument();
        [BsonElement("followerIDs")]
        public BsonArray FollowerIDs { get; set; } = new BsonArray();
        [BsonElement("followingIDs")]
        public BsonArray FollowingIDs { get; set; } = new BsonArray();
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}\naka\t\t{UserName}\nEmail - {Email}\nFrom {Address}\nEnjoys {Interests}";
        }
    }
}
