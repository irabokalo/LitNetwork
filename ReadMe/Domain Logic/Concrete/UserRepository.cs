using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain_Logic.Entities;
using Domain_Logic.Interfaces;

namespace Domain_Logic.Concrete
{
    public class UserRepository : IUserRepository
    {
        private UsersPostContext context;
        private bool disposed = false;

        public UserRepository(UsersPostContext context)
        {
            this.context = context;
        }

        public void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User GetUserById(int userId)
        {
            return context.Users.Find(userId);
        }

        public void InsertUser(User user)
        {
            context.Users.Add(user);
        }

        public void DeleteUser(int userId)
        {
            User user = context.Users.Find(userId);
            context.Users.Remove(user);
        }

        public void UpdateUser(User user)
        {
            context.Entry(user).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
