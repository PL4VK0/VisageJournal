using MongoDB.Bson;

namespace DTO
{
    public class User
    {
        public int UserID {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public BsonArray Interests { get; set; } = new BsonArray();
        public BsonDocument Address { get; set; } = new BsonDocument();
        public BsonArray FollowerIDs { get; set; } = new BsonArray();
        public BsonArray FollowingIDs { get; set; } = new BsonArray();
        public BsonArray PostIDs { get;set; } = new BsonArray();
        public BsonArray CommentIDs { get; set; } = new BsonArray();
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}\naka\t\t{UserName}\nEmail - {Email}\nFrom {Address}\nEnjoys {Interests}";
        }
    }
}
