using DTO;
using MongoDB.Bson;

namespace DAL.Abstract
{
    public interface IPostDAL
    {
        void DeleteByID(string ID);
        List<Post> GetAll();
        Post GetByID(string ID);
        void Update(Post post);
        void Add(Post post);
    }
}
