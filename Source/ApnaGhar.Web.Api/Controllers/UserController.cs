using Microsoft.AspNetCore.Mvc;
using ApnaGhar.IServices;
using ApnaGhar.Models.Session;

namespace ApnaGhar.Web.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("loginuser")]
        public User LoginUser([FromBody]User userCred )
        {
            return _userService.Find(s => s.HashedPassword == userCred.HashedPassword && s.Username == userCred.Username);
        }
        [HttpGet]
        public User GetAll()
        {
            return null;// _userService.Find(s => s.HashedPassword == userCred.HashedPassword && s.Username == userCred.Username);
        }

        [HttpPost]
        [Route("signupuser")]
        public User SignupUser([FromBody]User userData)
        {
            return _userService.Add(userData);
        }
    }
}