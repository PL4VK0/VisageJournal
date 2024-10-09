using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IUserDAL
    {
        bool DeleteByID(int ID);
        List<User> GetAll();
        User GetByID(int ID);
        bool Update(User user);
        void Add(User user); 
    }
}
