using System;
using System.Collections.Generic;
using Domain_Logic.Entities;

namespace Domain_Logic.Interfaces
{
    public interface IUserRepository:IDisposable
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int userId);
        void InsertUser(User user);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        void Save();
    }
}
