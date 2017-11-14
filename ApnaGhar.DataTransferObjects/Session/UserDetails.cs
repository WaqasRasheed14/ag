using System;
using System.Collections.Generic;
using System.Text;

namespace ApnaGhar.DataTransferObjects.Session
{
    public class UserDetails : Person
    {
        public int UserID { get; set; }
        public bool IsAnyAdPosted { get; set; }
    }
}
