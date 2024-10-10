using DTO;

namespace DAL.Abstract
{
    public interface ICommentDAL
    {
        bool DeleteByID(int ID);
        List<Comment> GetAll();
        Comment GetByID(int ID);
        bool Update(Comment comment);
        void Add(Comment comment);
    }
}
