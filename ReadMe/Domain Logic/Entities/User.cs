using System.Collections.Generic;

namespace Domain_Logic.Entities
{
    class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Genre { get; set; }
        public List<Post> Posts { get; set; }     
    }
}
