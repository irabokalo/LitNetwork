using System.Web.Mvc;
using Domain_Logic.Concrete;
using Domain_Logic.Interfaces;


namespace ReadMe.Controllers
{
    public class UserController : Controller
    {
        private UserRepository userRepository;

        public UserController()
        {
            this.userRepository = new UserRepository(new UsersPostContext());
        }

        public UserController(IUserRepository studentRepository)
        {
            this.userRepository = userRepository;
        }

    }
}