using ApnaGhar.Base;
using ApnaGhar.Data;
using ApnaGhar.IServices;
using ApnaGhar.Models.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApnaGhar.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(AppDBContext appDBContext) : base(appDBContext)
        {

        }
    }
}
