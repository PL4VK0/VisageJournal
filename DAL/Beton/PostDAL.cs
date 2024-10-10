using DAL.Abstract;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Beton
{
    public class PostDAL : IPostDAL
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public PostDAL(IMongoCollection<BsonDocument> collection)
        { _collection = collection; }
        public void Add(Post post)
        {
            if (string.IsNullOrEmpty(post.PostTitle))
                throw new Exception("Post title cant be mt!");
            if(string.IsNullOrEmpty(post.PostText))
                throw new Exception("Post text cant be mt!");
            var sort = Builders<BsonDocument>.Sort.Descending("_id");
            var filter = Builders<BsonDocument>.Filter.Empty;
            var document = _collection
                .Find(filter)
                .Sort(sort)
                .FirstOrDefault();
            var newID = document["_id"].AsInt32 + 1;
            BsonDocument newPost = new BsonDocument
            {
                {"postID",newID },
                {"posterID",post.PosterID },
                {"postTitle",post.PostTitle },
                {"postText",post.PostText },
                {"commentIDs",post.CommentIDs },
                {"upVotes",post.UpVotes },
                {"downVotes",post.DownVotes}
            };
            _collection.InsertOne(newPost);
        }

        public bool DeleteByID(int ID)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ID);
            var document = _collection.Find<BsonDocument>(filter).FirstOrDefault();
            if (document == null)
                return false;
            _collection.DeleteOne(document);
            return true;
        }

        public List<Post> GetAll()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = _collection.Find<BsonDocument>(filter).ToList();
            var posts = new List<Post>();

            foreach(var doc in documents)
            {
                Post post = new Post();

                post.PostID = doc["_id"].AsInt32;
                post.PosterID = doc["posterID"].AsInt32;
                post.PostTitle = doc["postTitle"].AsString;
                post.PostText = doc["postText"].AsString;
                post.CommentIDs = doc["commentIDs"].AsBsonArray;
                post.UpVotes = doc["upVotes"].AsBsonArray;
                post.DownVotes = doc["downVotes"].AsBsonArray;

                posts.Add(post);
            }
            return posts;
        }

        public Post GetByID(int ID)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id",ID);
            var doc = _collection.Find<BsonDocument>(filter).FirstOrDefault();
            if (doc == null)
                return null;


            Post post = new Post();

            post.PostID = doc["_id"].AsInt32;
            post.PosterID = doc["posterID"].AsInt32;
            post.PostTitle = doc["postTitle"].AsString;
            post.PostText = doc["postText"].AsString;
            post.CommentIDs = doc["commentIDs"].AsBsonArray;
            post.UpVotes = doc["upVotes"].AsBsonArray;
            post.DownVotes = doc["downVotes"].AsBsonArray;
            return post;
        }

        public bool Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
