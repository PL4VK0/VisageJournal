using MongoDB.Bson;

namespace DTO
{
    public class Post
    {
        public int PostID {  get; set; }
        public int PosterID { get; set; }
        public string PostTitle { get; set; }
        public string PostText { get; set; }
        public BsonArray CommentIDs { get; set; } = new BsonArray();
        public BsonArray Upvotes { get; set; } = new BsonArray();
        public BsonArray DownVotes { get; set; } = new BsonArray();
    }
}
