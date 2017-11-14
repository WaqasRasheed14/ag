﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApnaGhar.DataTransferObjects.Session
{
    public class UserCredentials
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HashedPassword { get; set; }

    }
}
