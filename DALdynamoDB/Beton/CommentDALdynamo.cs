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
        public async Task Add(Comment comment)
        {
            await _context.SaveAsync<Comment>(comment);
        }

        public async Task Delete(Comment comment)
        {
            await _context.DeleteAsync<Comment>(comment);
        }

        public async Task Update(Comment comment)
        {
            await _context.SaveAsync<Comment>(comment);
        }
    }
}
