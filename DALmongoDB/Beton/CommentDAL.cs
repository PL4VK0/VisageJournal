using DALmongoDB.Abstract;
using DTO;
using MongoDB.Driver;

namespace DALmongoDB.Beton
{
    public class CommentDAL : ICommentDAL
    {
        private readonly IMongoCollection<Comment> collection;

        public CommentDAL(IMongoCollection<Comment> collection)
        { this.collection = collection; }
        public void Add(Comment comment)
        {
            if (string.IsNullOrEmpty(comment.CommentText))
                throw new Exception("Comment text cant be mt!");

            collection.InsertOne(comment);
        }

        public void DeleteByID(string ID)
        {
            Comment commentToDelete = collection.Find(c=>c.CommentID == ID).FirstOrDefault();
            collection.DeleteOne(ID);
        }

        public List<Comment> GetAll()
        {
            var filter = Builders<Comment>.Filter.Empty;
            return collection.Find(filter).ToList();
        }

        public Comment GetByID(string ID)
        {
            return collection.Find<Comment>(c => c.CommentID == ID).FirstOrDefault();
        }

        public void Update(Comment comment)
        {
            var filter = Builders<Comment>.Filter.Eq(c => c.CommentID, comment.CommentID);
            var update = Builders<Comment>.Update
                .Set(c=>c.CommentID,comment.CommentID)
                .Set(c=>c.PostID, comment.PostID)
                .Set(c => c.PosterUserName, comment.PosterUserName)
                .Set(c => c.CommentatorUserName, comment.CommentatorUserName)
                .Set(c => c.CommentText, comment.CommentText)
                .Set(c => c.UpVotes, comment.UpVotes)
                .Set(c => c.DownVotes, comment.DownVotes);

            collection.UpdateOne(filter, update);
        }
    }
}
