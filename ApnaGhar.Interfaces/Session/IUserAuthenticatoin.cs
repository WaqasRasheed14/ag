using ApnaGhar.DataTransferObjects.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApnaGhar.Interfaces.Session
{
    public interface IUserAuthenticatoin
    {
        bool ValidateUser(UserCredentials userCred);
    }
}
