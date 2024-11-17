using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALdynamoDB.Abstract
{
    public interface IPostDALdynamo
    {
        Task Delete(Post post);
        Task Add(Post post);
    }
}
