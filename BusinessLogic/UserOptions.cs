using DAL.Beton;
using DTO;
using MongoDB.Driver;
using System.Xml.Linq;

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
        {
            return user;
        }
        public void SignUp(User user)
        {
            userDAL.Add(user);
        }


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
        public void UnFollow(string idThatUnFollows, string idToUnFollow)
        {
            User userThatUnFollows = userCollection.Find(u => u.UserID == idThatUnFollows).FirstOrDefault();
            User userToUnFollow = userCollection.Find(u => u.UserID == idToUnFollow).FirstOrDefault();

            userThatUnFollows.FollowingIDs.Remove(idToUnFollow);
            userToUnFollow.FollowerIDs.Remove(idThatUnFollows);

            var updateThatUnFollows = Builders<User>.Update
                .Set(u => u.FollowingIDs, userThatUnFollows.FollowingIDs);
            var updateToUnFollow = Builders<User>.Update
                .Set(u => u.FollowerIDs, userToUnFollow.FollowerIDs);

            userCollection.UpdateOne(userThatUnFollows.UserID, updateThatUnFollows);
            userCollection.UpdateOne(userToUnFollow.UserID, updateToUnFollow);
        }


        public List<Post> GetAllPostsFromThisUser(string userID)
        {
            return postCollection.Find(p => p.PosterID == userID).ToList();
        }

        public void NewPostFromThisUser(string postTitle, string postText)
        {
            Post newPost = new Post();
            newPost.PosterID = user.UserID;
            newPost.PostTitle = postTitle;
            newPost.PostText = postText;
            postDAL.Add(newPost);
        }
        public void RemoveCommentUpVote(Comment comment)
        {
            comment.UpVotes.Remove(user.UserID);


            var updateComment = Builders<Comment>.Update
                .Set(c => c.UpVotes, comment.UpVotes);
            commentCollection.UpdateOne(comment.CommentID, updateComment);
        }
        public void RemoveCommentDownVote(Comment comment)
        {
            comment.DownVotes.Remove(user.UserID);

            var updateComment = Builders<Comment>.Update.Set(c => c.DownVotes, comment.DownVotes);

            commentCollection.UpdateOne(comment.CommentID, updateComment);
        }
        public void RemoveCommentInCurrentUser(Comment comment)
        {
            commentCollection.DeleteOne(comment.CommentID);
        }
        public void RemoveCommentInPost(Post post, Comment comment)
        {
            post.CommentIDs.Remove(comment.CommentID);

            var updatePost = Builders<Post>.Update.Set(p => p.CommentIDs, post.CommentIDs);

            postCollection.UpdateOne(post.PostID, updatePost);
        }
        public void RemovePostUpVote(Post post)
        {
            post.UpVotes.Remove(user.UserID);
            var updatePost = Builders<Post>.Update
                .Set(p => p.UpVotes, post.UpVotes);
            postCollection.UpdateOne(post.PostID, updatePost);
        }
        public void RemovePostDownVote(Post post)
        {
            post.DownVotes.Remove(user.UserID);
            var updatePost = Builders<Post>.Update
                .Set(p => p.DownVotes, post.DownVotes);
            postCollection.UpdateOne(post.PostID, updatePost);
        }
        public void RemovePost(Post post)
        {
            postCollection.DeleteOne(post.PostID);
        }
        public void SignDown()
        {
            //somme errors for you


            //deleting from friends (let all your followers unfollow you)
            List<User> usersThatFollowYou = userCollection.Find(u => u.FollowingIDs.Contains(user.UserID)).ToList();
            foreach (var userThatFollowsYou in usersThatFollowYou)
                UnFollow(userThatFollowsYou.UserID, user.UserID);

            // unfollow all friends
            List<User> usersThatYouFollow = userCollection.Find(u=>u.FollowerIDs.Contains(user.UserID)).ToList();
            foreach (var userToUnFollow in usersThatYouFollow)
                UnFollow(user.UserID, userToUnFollow.UserID);


            //deleting all upvotes and downvotes
            List<Comment> commentsToDeleteUpVotesIn = commentCollection.Find(u=>u.UpVotes.Contains(user.UserID)).ToList();
            List<Comment> commentsToDeleteDownVotesIn = commentCollection.Find(u => u.DownVotes.Contains(user.UserID)).ToList();



            foreach (var comment in commentsToDeleteUpVotesIn)
                RemoveCommentUpVote(comment);


            foreach (var comment in commentsToDeleteDownVotesIn)
                RemoveCommentDownVote(comment);


            //deleting all comments 

            List<Comment> commentsToDelete = commentCollection.Find(c=>c.CommentatorID==user.UserID).ToList();
            foreach (var comment in commentsToDelete)
                RemoveCommentInCurrentUser(comment);

            //deleteing all other users comments from this user's posts...
            List<Post> userPosts = postCollection.Find(p=>p.PosterID==user.UserID).ToList();
            foreach(var post in userPosts)
            {
                List<Comment> otherUserComments = commentCollection.Find(c=>c.PostID==post.PostID).ToList();
                foreach (var comment in otherUserComments)
                    RemoveCommentInPost(post,comment);
            }

            //deleting all post upvotes/downvotes from this user
            List<Post> postsToDeleteUpVotesIn = postCollection.Find(p=>p.UpVotes.Contains(user.UserID)).ToList();
            List<Post> postsToDeleteDownVotesIn = postCollection.Find(p=>p.DownVotes.Contains(user.UserID)).ToList();

            foreach (var post in postsToDeleteUpVotesIn)
                RemovePostUpVote(post);
            foreach (var post in postsToDeleteDownVotesIn)
                RemovePostDownVote(post);
            //phew, i got very tired here (maybe should take a break or not?)



            
            
            foreach (var userPost in userPosts)
                RemovePost(userPost);

            //unalive account
            userCollection.DeleteOne(user.UserID);
        }
    }
}
