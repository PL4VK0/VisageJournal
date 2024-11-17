using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using DALdynamoDB.Abstract;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALdynamoDB.Beton
{
    public class CommentDALdynamo : ICommentDALdynamo
    {
        AmazonDynamoDBClient _client;
        DynamoDBContext _context;
        public CommentDALdynamo(AmazonDynamoDBClient client)
        {
            _client = client;
            _context = new DynamoDBContext(_client);
        }
        public async Task Add(CommentDynamo commentDynamo)
        {
            await _context.SaveAsync<CommentDynamo>(commentDynamo);
        }

        public async Task Delete(string postID, string commentID)
        {
            await _context.DeleteAsync<CommentDynamo>(postID,commentID);
        }

        public async Task<IEnumerable<CommentDynamo>> GetAllFromPost(string postID)
        {
            var result = await _context.QueryAsync<CommentDynamo>(postID).GetRemainingAsync();
            return result;
        }

        public async Task Update(CommentDynamo commentDynamo)
        {
            await _context.SaveAsync<CommentDynamo>(commentDynamo);
        }
    }
}
