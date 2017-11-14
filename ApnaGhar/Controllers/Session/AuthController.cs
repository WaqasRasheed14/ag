using Microsoft.AspNetCore.Mvc;
using ApnaGhar.DataTransferObjects.Session;
using System.Net;
using ApnaGhar.BusinessLogicLibrary.Session;
using ApnaGhar.Interfaces.Session;


namespace ApnaGhar.Controllers.Session
{
    [Produces("application/json")]
    [Route("api/Auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        [Route("api/session/login")]
        public IActionResult LoginUser([FromBody]UserCredentials userCred)
        {
            IUserAuthenticatoin objUser = new UserAuthenticatoin();
            if (objUser.ValidateUser(userCred))
                return Ok(new UserDetails());
            return NotFound();
            
        }
    }
}