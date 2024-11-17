using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALdynamoDB.Abstract
{
    public interface ICommentDALdynamo
    {
        Task Update(CommentDynamo commentDynamo);
        Task Delete(string postID, string commentID);
        Task Add(CommentDynamo commentDynamo);
        Task<IEnumerable<CommentDynamo>> GetAllFromPost(string postID);
    }
}
