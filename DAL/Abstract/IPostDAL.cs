using DTO;
using MongoDB.Bson;

namespace DAL.Abstract
{
    public interface IPostDAL
    {
        bool DeleteByID(int ID);
        List<Post> GetAll();
        Post GetByID(int ID);
        bool Update(Post post);
        void Add(Post post);
    }
}
