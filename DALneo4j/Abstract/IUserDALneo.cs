using DTO;

namespace DALneo4j.Abstract
{
    public interface IUserDALneo
    {
        Task DeleteByID(string ID);
        Task Update(User user);
        Task Add(User user);
    }
}
