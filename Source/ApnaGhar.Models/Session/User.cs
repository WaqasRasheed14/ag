using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApnaGhar.Models.Session
{
    public class User : BaseModel
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Gender{ get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string AboutMe { get; set; }
        public string HashedPassword { get; set; }        
    }
}
