using MongoDB.Bson;

namespace DTO
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public int CommentatorID { get; set; }
        public string CommentText { get; set; }
        public BsonArray Upvotes { get; set; } = new BsonArray();
        public BsonArray DownVotes { get; set; } = new BsonArray();
    }
}
