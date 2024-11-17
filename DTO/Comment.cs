using Amazon.DynamoDBv2.DataModel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DTO
{
    [BsonIgnoreExtraElements]
    [DynamoDBTable("PostsAndComments")]
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [DynamoDBRangeKey("SK")]
        public string CommentID { get; set; }
        [BsonElement("postID")]
        [DynamoDBHashKey("PK")]
        public string PostID { get; set; }
        [BsonElement("posterUserName")]
        [DynamoDBProperty("PosterUserName")]
        public string PosterUserName { get; set; }
        [BsonElement("commentatorUserName")]
        [DynamoDBProperty("CommentatorUserName")]
        public string CommentatorUserName { get; set; }
        [BsonElement("commentText")]
        [DynamoDBProperty("CommentText")]
        public string CommentText { get; set; }
        [BsonElement("upVotes")]
        [DynamoDBIgnore]
        public BsonArray UpVotes { get; set; } = new BsonArray();
        [BsonElement("downVotes")]
        [DynamoDBIgnore]
        public BsonArray DownVotes { get; set; } = new BsonArray();
        [BsonElement("date")]
        [DynamoDBProperty("CommentDate")]
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
