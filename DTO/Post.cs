using Amazon.DynamoDBv2.DataModel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DTO
{
    [BsonIgnoreExtraElements]
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PostID {  get; set; }
        [BsonElement("posterUserName")]
        public string PosterUserName { get; set; }
        [BsonElement("postTitle")]
        public string PostTitle { get; set; }
        [BsonElement("postText")]
        public string PostText { get; set; }
        //[BsonElement("commentIDs")]
        //public BsonArray CommentIDs { get; set; } = new BsonArray();
        [BsonElement("upVotes")]
        public BsonArray UpVotes { get; set; } = new BsonArray();
        [BsonElement("downVotes")]
        public BsonArray DownVotes { get; set; } = new BsonArray();
        [BsonElement("date")]
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
