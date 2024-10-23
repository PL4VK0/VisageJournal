using DTO;

namespace DALneo4j.Abstract
{
    public interface IUserDALneo
    {
        void DeleteByID(string ID);
        List<User> GetAll();
        User GetByID(string ID);
        void Update(User user);
        void Add(User user);
    }
}
