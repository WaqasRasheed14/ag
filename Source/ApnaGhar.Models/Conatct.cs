using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models
{
    public class Conatct
    {
        [Key]
        public int ContactID { get; set; }

        [ForeignKey("UserAddress")]
        public int UserAddressID { get; set; }
    }
}
