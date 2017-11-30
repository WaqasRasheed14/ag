using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            return new User() {
                Username ="Waqas",
                HashedPassword ="dasjkdhashdasd54dd6ss6d67qwee",
                FirstName="Waqas",
                LastName="Rasheed",
                ModifiedAt=DateTime.Now
            };
            //return _userService.Find(s => s.HashedPassword == userCred.HashedPassword && s.Username == userCred.Username);
        }
        [HttpGet]
        public User GetAll()
        {
            return null;// _userService.Find(s => s.HashedPassword == userCred.HashedPassword && s.Username == userCred.Username);
        }
    }
}