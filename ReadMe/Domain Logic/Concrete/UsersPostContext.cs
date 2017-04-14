using System.Data.Entity;
using Domain_Logic.Entities;

namespace Domain_Logic.Concrete
{
    class UsersPostContext: DbContext
    {
        public UsersPostContext(): base("UsersPostDb") 
        {
            Database.SetInitializer<UsersPostContext>(new CreateDatabaseIfNotExists<UsersPostContext>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
