using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public static class DynamoConverter
    {
        public static CommentDynamo ConvertCommentToCommentDynamo(Comment comment)
        {
            CommentDynamo commentDynamo = new CommentDynamo
            {
                CommentID = comment.CommentID,
                CommentText = comment.CommentText,
                CommentatorUserName = comment.CommentatorUserName,
                PosterUserName = comment.PosterUserName,
                PostID = comment.PostID,
                Date = comment.Date
            };
            foreach (var upVote in comment.UpVotes)
                commentDynamo.UpVotes.Add(upVote.AsString);
            foreach (var downVote in comment.DownVotes)
                commentDynamo.DownVotes.Add(downVote.AsString);
            return commentDynamo;
        }
        public static Comment ConvertCommentDynamoToComment(CommentDynamo commentDynamo)
        {
            Comment newComment = new Comment
            {
                CommentID = commentDynamo.CommentID,
                PostID = commentDynamo.PostID,
                CommentatorUserName = commentDynamo.CommentatorUserName,
                CommentText = commentDynamo.CommentText,
                Date = commentDynamo.Date,
                PosterUserName = commentDynamo.PosterUserName
            };
            foreach (var upVote in commentDynamo.UpVotes)
                newComment.UpVotes.Add(upVote);
            foreach (var downVote in commentDynamo.DownVotes)
                newComment.DownVotes.Add(downVote);
            return newComment;
        }
        public static PostDynamo ConvertPostToPostDynamo(Post post)
        {
            PostDynamo postDynamo = new PostDynamo
            {
                PosterUserName = post.PosterUserName,
                PostID = post.PostID,
                Date = post.Date,
                PostText = post.PostText,
                PostTitle = post.PostTitle
            };
            foreach (var upVote in post.UpVotes)
                postDynamo.UpVotes.Add(upVote.AsString);
            foreach (var downVote in post.DownVotes)
                postDynamo.DownVotes.Add(downVote.AsString);
            return postDynamo;
        }
        public static Post ConvertPostDynamoToPost(PostDynamo postDynamo)
        {
            return null;
        }
    }
}
