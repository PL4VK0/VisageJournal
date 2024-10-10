using DAL.Abstract;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Beton
{
    public class CommentDAL : ICommentDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public CommentDAL(IMongoCollection<BsonDocument> collection)
        { _collection = collection; }
        public void Add(Comment comment)
        {
            if (string.IsNullOrEmpty(comment.CommentText))
                throw new Exception("Comment text cant be mt!");
            var sort = Builders<BsonDocument>.Sort.Descending("_id");
            var filter = Builders<BsonDocument>.Filter.Empty;
            var document = _collection
                .Find(filter)
                .Sort(sort)
                .FirstOrDefault();


            int newID = 1;
            if (document != null)
                newID = document["_id"].AsInt32 + 1;
            BsonDocument newComment = new BsonDocument
            {
                {"_id",newID },
                {"commentatorID",comment.CommentatorID},
                {"postID",comment.PostID },
                {"commentText",comment.CommentText},
                {"upVotes",comment.Upvotes },
                {"downVotes",comment.DownVotes }
            };
            _collection.InsertOne(newComment);
        }

        public bool DeleteByID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
