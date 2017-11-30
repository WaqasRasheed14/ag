using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models
{
    public class UserAddress
    {
        [ForeignKey("Address")]
        [Column(Order = 1)]
        public int UserAddressID { get; set; }
        [ForeignKey("Contact")]
        [Column(Order = 2)]
        public int ContactID { get; set; }
    }
}
