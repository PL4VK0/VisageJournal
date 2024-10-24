﻿using DTO;

namespace DALmongoDB.Abstract
{
    public interface IUserDAL
    {
        void DeleteByID(string ID);
        List<User> GetAll();
        User GetByID(string ID);
        void Update(User user);
        void Add(User user);
    }
}
