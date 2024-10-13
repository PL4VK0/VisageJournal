using DAL.Abstract;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Beton
{
    public class CommentDAL : ICommentDAL
    {
        private readonly IMongoCollection<Comment> _collection;

        public CommentDAL(IMongoCollection<Comment> collection)
        { _collection = collection; }
        public void Add(Comment comment)
        {
            if (string.IsNullOrEmpty(comment.CommentText))
                throw new Exception("Comment text cant be mt!");

            _collection.InsertOne(comment);
            //var sort = Builders<BsonDocument>.Sort.Descending("_id");
            //var filter = Builders<BsonDocument>.Filter.Empty;
            //var document = _collection
            //    .Find(filter)
            //    .Sort(sort)
            //    .FirstOrDefault();


            //int newID = 1;
            //if (document != null)
            //    newID = document["_id"].AsInt32 + 1;
            //BsonDocument newComment = new BsonDocument
            //{
            //    {"_id",newID },
            //    {"commentatorID",comment.CommentatorID},
            //    {"postID",comment.PostID },
            //    {"commentText",comment.CommentText},
            //    {"upVotes",comment.UpVotes },
            //    {"downVotes",comment.DownVotes }
            //};
            //_collection.InsertOne(newComment);
        }

        public void DeleteByID(string ID)
        {
            Comment commentToDelete = _collection.Find(c=>c.CommentID == ID).FirstOrDefault();
            _collection.DeleteOne(ID);
        }

        public List<Comment> GetAll()
        {
            var filter = Builders<Comment>.Filter.Empty;
            return _collection.Find(filter).ToList();
        }

        public Comment GetByID(string ID)
        {
            return _collection.Find<Comment>(c => c.CommentID == ID).FirstOrDefault();
        }

        public void Update(Comment comment)
        {
            var update = Builders<Comment>.Update
                .Set(c=>c.CommentID,comment.CommentID)
                .Set(c => c.PostID, comment.PostID)
                .Set(c => c.CommentatorID, comment.CommentatorID)
                .Set(c => c.CommentText, comment.CommentText)
                .Set(c => c.UpVotes, comment.UpVotes)
                .Set(c => c.DownVotes, comment.DownVotes);

            _collection.UpdateOne(comment.CommentID, update);
        }
    }
}
