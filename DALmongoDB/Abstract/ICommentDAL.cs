using DTO;

namespace DALmongoDB.Abstract
{
    public interface ICommentDAL
    {
        void DeleteByID(string ID);
        List<Comment> GetAll();
        Comment GetByID(string ID);
        void Update(Comment comment);
        void Add(Comment comment);
    }
}
