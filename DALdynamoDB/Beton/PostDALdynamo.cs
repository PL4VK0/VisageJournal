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
    public class PostDALdynamo : IPostDALdynamo
    {
        AmazonDynamoDBClient _client;
        DynamoDBContext _context;
        public PostDALdynamo(AmazonDynamoDBClient client)
        {
            _client = client;
            _context = new DynamoDBContext(_client);
        }
        public async Task Add(Post post)
        {
            await _context.SaveAsync<Post>(post);
        }

        public async Task Delete(Post post)
        {
            await _context.DeleteAsync(post);
        }
    }
}
