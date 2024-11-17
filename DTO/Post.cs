using Amazon.DynamoDBv2.DataModel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DTO
{
    [BsonIgnoreExtraElements]
    [DynamoDBTable("PostsAndComments")]
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [DynamoDBRangeKey("SK")]
        public string PostID {  get; set; }
        [BsonElement("posterUserName")]
        [DynamoDBHashKey("PK")]
        public string PosterUserName { get; set; }
        [BsonElement("postTitle")]
        [DynamoDBProperty("PostTitle")]
        public string PostTitle { get; set; }
        [BsonElement("postText")]
        [DynamoDBProperty("PostText")]
        public string PostText { get; set; }
        //[BsonElement("commentIDs")]
        //public BsonArray CommentIDs { get; set; } = new BsonArray();
        [BsonElement("upVotes")]
        [DynamoDBIgnore]
        public BsonArray UpVotes { get; set; } = new BsonArray();
        [BsonElement("downVotes")]
        [DynamoDBIgnore]
        public BsonArray DownVotes { get; set; } = new BsonArray();
        [BsonElement("date")]
        [DynamoDBProperty("PostDate")]
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
