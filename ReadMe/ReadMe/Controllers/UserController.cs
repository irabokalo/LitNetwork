using System.Web.Mvc;
using Domain_Logic.Concrete;
using Domain_Logic.Entities;
using Domain_Logic.Interfaces;
using UserD = Domain_Logic.Entities.User;
using UserR = ReadMe.Models.User;


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

        public ActionResult UserProfile()
        {
            userRepository.InsertUser(new UserD() {FirstName =  "ira",LastName = "bokalo"});
            return View(new [] { new UserD() { FirstName = "ira", LastName = "bokalo" }});
        }
    }
}