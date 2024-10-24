using DTO;

namespace DALneo4j.Abstract
{
    public interface IUserDALneo
    {
        Task DeleteByID(string ID);
        //List<User> GetAll();
        //User GetByID(string ID);
        Task Update(User user);
        Task Add(User user);
    }
}
