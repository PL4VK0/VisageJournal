using DAL.Abstract;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Beton
{
    public class PostDAL : IPostDAL
    {
        private readonly IMongoCollection<Post> _collection;

        public PostDAL(IMongoCollection<Post> collection)
        { _collection = collection; }
        public void Add(Post post)
        {
            if (string.IsNullOrEmpty(post.PostTitle))
                throw new Exception("Post title cant be mt!");
            if(string.IsNullOrEmpty(post.PostText))
                throw new Exception("Post text cant be mt!");


            _collection.InsertOne(post);
            //var sort = Builders<BsonDocument>.Sort.Descending("_id");
            //var filter = Builders<BsonDocument>.Filter.Empty;
            //var document = _collection
            //    .Find(filter)
            //    .Sort(sort)
            //    .FirstOrDefault();


            //int newID = 1;
            //if (document != null)
            //    newID = document["_id"].AsInt32 + 1;
            //BsonDocument newPost = new BsonDocument
            //{
            //    {"_id",newID },
            //    {"posterID",post.PosterID },
            //    {"postTitle",post.PostTitle },
            //    {"postText",post.PostText },
            //    {"commentIDs",post.CommentIDs },
            //    {"upVotes",post.UpVotes },
            //    {"downVotes",post.DownVotes}
            //};
            //_collection.InsertOne(newPost);
        }

        public void DeleteByID(string ID)
        {
            Post postToDelete = _collection.Find(p => p.PostID == ID).FirstOrDefault();
            _collection.DeleteOne(ID); 
            //var filter = Builders<BsonDocument>.Filter.Eq("_id", ID);
            //var document = _collection.Find<BsonDocument>(filter).FirstOrDefault();
            //if (document == null)
            //    return false;
            //_collection.DeleteOne(document);
            //return true;
        }

        public List<Post> GetAll()
        {
            var filter = Builders<Post>.Filter.Empty;
            return _collection.Find(filter).ToList();
            //var posts = documents.;

            //foreach(var doc in documents)
            //{
            //    Post post = new Post();

            //    post.PostID = doc["_id"].AsInt32;
            //    post.PosterID = doc["posterID"].AsInt32;
            //    post.PostTitle = doc["postTitle"].AsString;
            //    post.PostText = doc["postText"].AsString;
            //    post.CommentIDs = doc["commentIDs"].AsBsonArray;
            //    post.UpVotes = doc["upVotes"].AsBsonArray;
            //    post.DownVotes = doc["downVotes"].AsBsonArray;

            //    posts.Add(post);
            //}
            //return posts;
        }

        public Post GetByID(string ID)
        {
            return _collection.Find<Post>(p => p.PostID== ID).FirstOrDefault();
            //var filter = Builders<BsonDocument>.Filter.Eq("_id",ID);
            //var doc = _collection.Find<BsonDocument>(filter).FirstOrDefault();
            //if (doc == null)
            //    return null;


            //Post post = new Post();

            //post.PostID = doc["_id"].AsInt32;
            //post.PosterID = doc["posterID"].AsInt32;
            //post.PostTitle = doc["postTitle"].AsString;
            //post.PostText = doc["postText"].AsString;
            //post.CommentIDs = doc["commentIDs"].AsBsonArray;
            //post.UpVotes = doc["upVotes"].AsBsonArray;
            //post.DownVotes = doc["downVotes"].AsBsonArray;
            //return post;
        }

        public void Update(Post post)
        {
            var update = Builders<Post>.Update
                .Set(p => p.PostID, post.PostID)
                .Set(p => p.PosterID, post.PosterID)
                .Set(p => p.PostTitle, post.PostTitle)
                .Set(p => p.PostText, post.PostText)
                .Set(p => p.CommentIDs, post.CommentIDs)
                .Set(p => p.UpVotes, post.UpVotes)
                .Set(p => p.DownVotes, post.DownVotes);

            _collection.UpdateOne(post.PostID, update);
        }
    }
}
