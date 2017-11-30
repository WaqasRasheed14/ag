using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models
{
    public class MobileNumbers
    {
        [Key]
        public int MobileNumberID { get; set; }
        public string MobileNumber { get; set; }
        [ForeignKey("Contact")]
        public int ContactID { get; set; }
    }
}
