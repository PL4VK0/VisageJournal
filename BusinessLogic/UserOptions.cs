﻿using DAL.Beton;
using DTO;
using MongoDB.Bson;
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

        public User FindUser(string userID)
        {
            return userDAL.GetByID(userID);
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
            var filterThatFollows = Builders<User>.Filter.Eq(u=>u.UserID, idThatFollows);
            var filterToFollow = Builders<User>.Filter.Eq(u => u.UserID, idToFollow);
            User userThatFollows = userCollection.Find(filterThatFollows).FirstOrDefault();
            User userToFollow = userCollection.Find(filterToFollow).FirstOrDefault();

            userThatFollows.FollowingIDs.Add(idToFollow);
            userToFollow.FollowerIDs.Add(idThatFollows);


            user = userThatFollows;


            var updateThatFollows = Builders<User>.Update
                .Set(u => u.FollowingIDs, userThatFollows.FollowingIDs);
            var updateToFollow = Builders<User>.Update
                .Set(u => u.FollowerIDs, userToFollow.FollowerIDs);
            userCollection.UpdateOne(filterThatFollows, updateThatFollows);
            userCollection.UpdateOne(filterToFollow, updateToFollow);
        }
        public void UnFollow(string idThatUnFollows, string idToUnFollow)
        {
            var filterThatUnFollows = Builders<User>.Filter.Eq(u => u.UserID, idThatUnFollows);
            var filterToUnFollow = Builders<User>.Filter.Eq(u => u.UserID, idToUnFollow);
            User userThatUnFollows = userCollection.Find(filterThatUnFollows).FirstOrDefault();
            User userToUnFollow = userCollection.Find(filterToUnFollow).FirstOrDefault();

            userThatUnFollows.FollowingIDs.Remove(idToUnFollow);
            userToUnFollow.FollowerIDs.Remove(idThatUnFollows);


            user = userThatUnFollows;


            var updateThatUnFollows = Builders<User>.Update
                .Set(u => u.FollowingIDs, userThatUnFollows.FollowingIDs);
            var updateToUnFollow = Builders<User>.Update
                .Set(u => u.FollowerIDs, userToUnFollow.FollowerIDs);

            userCollection.UpdateOne(filterThatUnFollows, updateThatUnFollows);
            userCollection.UpdateOne(filterToUnFollow, updateToUnFollow);
        }


        public List<Post> GetAllPostsFromThisUser(User user)
        {
            return postCollection.Find(p => p.PosterUserName == user.UserName).ToList();
        }

        public void NewPostFromThisUser(string postTitle, string postText)
        {
            Post newPost = new Post();
            newPost.PosterUserName = user.UserName;
            newPost.PostTitle = postTitle;
            newPost.PostText = postText;
            postDAL.Add(newPost);

            //var filter = Builders<Post>.Filter.Empty;
            //var sort = Builders<Post>.Sort.Descending("date");
            //var lastPost = postCollection.Find(filter).Sort(sort).FirstOrDefault();

            //string lastPostId = lastPost.PostID;

            //user.PostIDs.Add(lastPostId);

            //var update = Builders<Post>.Update.Set("postIDs", user.PostIDs);
            //postCollection.UpdateOne(user.UserID,update);
        }
        public void RemoveCommentUpVote(Comment comment)
        {
            comment.UpVotes.Remove(user.UserID);


            var filter = Builders<Comment>.Filter.Eq(c=>c.CommentID, comment.CommentID);
            var updateComment = Builders<Comment>.Update
                .Set(c => c.UpVotes, comment.UpVotes);
            commentCollection.UpdateOne(filter, updateComment);
        }
        public void RemoveCommentDownVote(Comment comment)
        {
            comment.DownVotes.Remove(user.UserID);
            var filter = Builders<Comment>.Filter.Eq(c => c.CommentID, comment.CommentID);
            var updateComment = Builders<Comment>.Update.Set(c => c.DownVotes, comment.DownVotes);

            commentCollection.UpdateOne(filter, updateComment);
        }
        public void RemoveComment(Comment comment)
        {
            var filter = Builders<Comment>.Filter.Eq(c=>c.CommentID, comment.CommentID);
            commentCollection.DeleteOne(filter);
        }
        public void UpVotePost(Post post)
        {
            var filter = Builders<Post>.Filter.Eq(p => p.PostID, post.PostID);
            post.UpVotes.Add(user.UserID);
            var updatePost = Builders<Post>.Update
                .Set(p => p.UpVotes, post.UpVotes);
            postCollection.UpdateOne(filter, updatePost);
        }
        public void DownVotePost(Post post)
        {
            var filter = Builders<Post>.Filter.Eq(p => p.PostID, post.PostID);
            post.DownVotes.Add(user.UserID);
            var updatePost = Builders<Post>.Update
                .Set(p => p.DownVotes, post.DownVotes);
            postCollection.UpdateOne(filter, updatePost);
        }
        public void RemovePostUpVote(Post post)
        {
            var filter = Builders<Post>.Filter.Eq(p=>p.PostID, post.PostID);
            post.UpVotes.Remove(user.UserID);
            var updatePost = Builders<Post>.Update
                .Set(p => p.UpVotes, post.UpVotes);
            postCollection.UpdateOne(filter, updatePost);
        }
        public void RemovePostDownVote(Post post)
        {
            var filter = Builders<Post>.Filter.Eq(p => p.PostID, post.PostID);
            post.DownVotes.Remove(user.UserID);
            var updatePost = Builders<Post>.Update
                .Set(p => p.DownVotes, post.DownVotes);
            postCollection.UpdateOne(filter, updatePost);
        }
        public void RemovePost(Post post)
        {
            var commentFilter = Builders<Comment>.Filter.Eq(c=>c.PosterUserName, post.PosterUserName);
            commentCollection.DeleteMany(commentFilter);


            var filter = Builders<Post>.Filter.Eq(post => post.PostID,post.PostID);
            postCollection.DeleteOne(filter);
            //postCollection.DeleteOne(post.PostID);
            //postDAL.DeleteByID(post.PostID);
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
            List<Comment> commentsToDeleteUpVotesIn = commentCollection.Find(u => u.UpVotes.Contains(user.UserID)).ToList();
            List<Comment> commentsToDeleteDownVotesIn = commentCollection.Find(u => u.DownVotes.Contains(user.UserID)).ToList();

            foreach (var comment in commentsToDeleteUpVotesIn)
                RemoveCommentUpVote(comment);


            foreach (var comment in commentsToDeleteDownVotesIn)
                RemoveCommentDownVote(comment);


            //deleting all comments 

            var commentFilter = Builders<Comment>.Filter.Eq(c=>c.CommentatorUserName,user.UserName);
            commentCollection.DeleteMany(commentFilter);
            //List<Comment> commentsToDelete = commentCollection.Find(c=>c.CommentatorID==user.UserID).ToList();
            //foreach (var comment in commentsToDelete)
            //    RemoveComment(comment);



            //deleteing all other users comments from this user's posts...
            List<Post> userPosts = postCollection.Find(p => p.PosterUserName == user.UserName).ToList();
            foreach (var post in userPosts)
            {
                var otherUsersCommentFilter = Builders<Comment>.Filter.Eq(c => c.PosterUserName, post.PosterUserName);
                commentCollection.DeleteMany(otherUsersCommentFilter);
                //List<Comment> otherUserComments = commentCollection.Find(c => c.PostID == post.PostID).ToList();
                //foreach (var comment in otherUserComments)
                //    RemoveComment(comment);
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
            var filter = Builders<User>.Filter.Eq(u => u.UserID, user.UserID);
            userCollection.DeleteOne(filter);
        }
        public List<Comment> GetAllCommentsFromThisPost(Post post)
        {
            var filter = Builders<Comment>.Filter.Eq(c=>c.PostID,post.PostID);
            return commentCollection.Find(filter).ToList();
        }
        public void NewCommentFromThisUser(Comment comment)
        {
            commentDAL.Add(comment);
            //commentCollection.InsertOne(comment);
        }
        public void UpVoteComment(Comment comment)
        {
            var filter = Builders<Comment>.Filter.Eq(c => c.CommentID, comment.CommentID);
            comment.UpVotes.Add(user.UserID);
            var updateComment = Builders<Comment>.Update
                .Set(c => c.UpVotes, comment.UpVotes);
            commentCollection.UpdateOne(filter, updateComment);
        }
        public void DownVoteComment(Comment comment)
        {
            var filter = Builders<Comment>.Filter.Eq(c => c.CommentID, comment.CommentID);
            comment.DownVotes.Add(user.UserID);
            var updateComment = Builders<Comment>.Update
                .Set(c => c.DownVotes, comment.DownVotes);
            commentCollection.UpdateOne(filter, updateComment);
        }
        public List<Post> GetAllFriendAndMinePosts()
        {
            List<Post> posts = new List<Post>();
            var filter = Builders<User>.Filter.Where(u=>u.FollowerIDs.Contains(user.UserID));
            var followedUsers = userCollection.Find(filter).ToList();
            foreach (var followedUser in followedUsers)
            {
                var postFilter = Builders<Post>.Filter.Eq(p => p.PosterUserName, followedUser.UserName);
                var thisUserPosts = postCollection.Find(postFilter).ToList();
                if(thisUserPosts != null)
                    posts.AddRange(thisUserPosts);
            }
            List<Post> myPosts = GetAllPostsFromThisUser(user);
            if(myPosts!=null) 
                posts.AddRange(myPosts);
            return posts;
        }
        public User FindByUserName(string userName)
        {
            var userFilter = Builders<User>.Filter.Eq(u => u.UserName, userName);
            var foundUser = userCollection.Find(userFilter).FirstOrDefault();
            return foundUser;
        }
    }
}
