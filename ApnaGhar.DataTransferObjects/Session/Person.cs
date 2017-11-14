using System;
using System.Collections.Generic;
using System.Text;

namespace ApnaGhar.DataTransferObjects.Session
{
    public class Person
    {
        public int PersonID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; }        
        public bool IsValidated { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }


    }
}
