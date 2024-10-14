using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DTO
{
    [BsonIgnoreExtraElements]
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CommentID { get; set; }
        [BsonElement("postID")]
        public string PostID { get; set; }
        [BsonElement("posterUserName")]
        public string PosterUserName { get; set; }
        [BsonElement("commentatorUserName")]
        public string CommentatorUserName { get; set; }
        [BsonElement("commentText")]
        public string CommentText { get; set; }
        [BsonElement("upVotes")]
        public BsonArray UpVotes { get; set; } = new BsonArray();
        [BsonElement("downVotes")]
        public BsonArray DownVotes { get; set; } = new BsonArray();
        [BsonElement("date")]
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
