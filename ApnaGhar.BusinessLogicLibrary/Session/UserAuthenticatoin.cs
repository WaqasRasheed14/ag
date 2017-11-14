using ApnaGhar.Interfaces.Session;
using System;
using System.Collections.Generic;
using System.Text;
using ApnaGhar.DataTransferObjects.Session;
using ApnaGhar.DataAccessLibrary.Session;

namespace ApnaGhar.BusinessLogicLibrary.Session
{
    public class UserAuthenticatoin : IUserAuthenticatoin
    {
        public bool ValidateUser(UserCredentials userCred)
        {
            return UserDAL.IsUserAuthenticated(userCred);
        }
    }
}
