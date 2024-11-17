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
        Task Update(Comment comment);
        Task Delete(Comment comment);
        Task Add(Comment comment);
    }
}
