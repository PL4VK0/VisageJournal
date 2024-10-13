using DAL.Beton;
using DTO;
using MongoDB.Driver;

namespace BusinessLogic
{
    public class UserOptions
    {
        private readonly UserDAL userDAL;
        private readonly PostDAL postDAL;
        private readonly CommentDAL commentDAL;
        private readonly IMongoCollection<User> userCollection;
        private readonly IMongoCollection<Post> postCollection;
        private readonly IMongoCollection<Comment> commentCollection;
        private User user = null;
        public UserOptions(IMongoCollection<User> userCollection, 
                           IMongoCollection<Post> postCollection,
                           IMongoCollection<Comment> commentCollection)
        {
            this.userCollection = userCollection;
            this.postCollection = postCollection;
            this.commentCollection = commentCollection;
            userDAL = new UserDAL(userCollection);
            postDAL = new PostDAL(postCollection);
            commentDAL = new CommentDAL(commentCollection);
        }
        public User GetUser() 
        { return user; }
        public void SignUp(User user)
        { userDAL.Add(user); }


        public void SignIn(string emailOrUserName, string password)
        {
            //checking email
            User userToSignIn = userCollection.Find(u => u.Email == emailOrUserName).FirstOrDefault();
            if (userToSignIn == null)
            {
                //checking uN
                userToSignIn = userCollection.Find(u => u.UserName == emailOrUserName).FirstOrDefault();
                if (userToSignIn == null)
                    throw new Exception("There is no one with this Email or UserName!");
            }

            if (userToSignIn.Password != password)
                throw new Exception("WRONG PASSWORD!!!");
            user = userToSignIn;
        }



        public void Follow(string idThatFollows, string idToFollow)
        {
            User userThatFollows = userCollection.Find(u => u.UserID == idThatFollows).FirstOrDefault();
            if (userThatFollows == null)
                throw new Exception("The unexisting user is trying to follow someone");

            if (idThatFollows == idToFollow)
                throw new Exception("You can't follow yourself! (but you can follow your dreams...)");

            if (userThatFollows.FollowingIDs.Contains(idToFollow))
                throw new Exception("This user is already followed by you!");

            User userToFollow = userCollection.Find(u => u.UserID == idToFollow).FirstOrDefault();
            if (userToFollow == null)
                throw new Exception("You can't follow an unexisting user!");

            userThatFollows.FollowingIDs.Add(idToFollow);
            userToFollow.FollowerIDs.Add(idThatFollows);

            var updateThatFollows = Builders<User>.Update
                .Set(u => u.FollowingIDs, userThatFollows.FollowingIDs);
            var updateToFollow = Builders<User>.Update
                .Set(u => u.FollowerIDs, userToFollow.FollowerIDs);
            userCollection.UpdateOne(userThatFollows.UserID, updateThatFollows);
            userCollection.UpdateOne(userToFollow.UserID, updateToFollow);
        }


        public List<Post> GetAllPostsFromThisUser(string userID)
        { return postCollection.Find(p=>p.PosterID == userID).ToList(); }

        public void NewPostFromThisUser(string postTitle, string postText)
        {
            Post newPost = new Post();
            newPost.PosterID = user.UserID;
            newPost.PostTitle = postTitle;
            newPost.PostText = postText;
            postDAL.Add(newPost);
        }
        public void SignDown()
        {
            somme errors for you
        }
    }
}
