using Microsoft.AspNetCore.Mvc;
using ApnaGhar.DataTransferObjects.Session;
using System.Net;
using ApnaGhar.BusinessLogicLibrary.Session;
using ApnaGhar.Interfaces.Session;
using System.Collections.Generic;

namespace ApnaGhar.Controllers.Session
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IUserAuthenticatoin userAuth;

        public AuthController(IUserAuthenticatoin userAuthentication)
        {
            userAuth = userAuthentication;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("login")]
        public IActionResult LoginUser([FromBody]UserCredentials userCred)
        {
            if (userAuth.ValidateUser(userCred))
                return Ok(new UserDetails());
            return NotFound();
            
        }
    }
}