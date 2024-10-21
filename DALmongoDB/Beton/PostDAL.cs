using DALmongoDB.Abstract;
using DTO;
using MongoDB.Driver;

namespace DALmongoDB.Beton
{
    public class PostDAL : IPostDAL
    {
        private readonly IMongoCollection<Post> collection;

        public PostDAL(IMongoCollection<Post> collection)
        { this.collection = collection; }
        public void Add(Post post)
        {
            if (string.IsNullOrEmpty(post.PostTitle))
                throw new Exception("Post title cant be mt!");
            if(string.IsNullOrEmpty(post.PostText))
                throw new Exception("Post text cant be mt!");


            collection.InsertOne(post);
        }

        public void DeleteByID(string ID)
        {
            Post postToDelete = collection.Find(p => p.PostID == ID).FirstOrDefault();
            collection.DeleteOne(ID); 
        }

        public List<Post> GetAll()
        {
            var filter = Builders<Post>.Filter.Empty;
            return collection.Find(filter).ToList();
        }

        public Post GetByID(string ID)
        {
            return collection.Find<Post>(p => p.PostID== ID).FirstOrDefault();
        }

        public void Update(Post post)
        {
            var update = Builders<Post>.Update
                .Set(p => p.PostID, post.PostID)
                .Set(p => p.PosterUserName, post.PosterUserName)
                .Set(p => p.PostTitle, post.PostTitle)
                .Set(p => p.PostText, post.PostText)
                //.Set(p => p.CommentIDs, post.CommentIDs)
                .Set(p => p.UpVotes, post.UpVotes)
                .Set(p => p.DownVotes, post.DownVotes);

            collection.UpdateOne(post.PostID, update);
        }
    }
}
