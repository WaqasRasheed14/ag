using ApnaGhar.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        [ForeignKey("LookupCity")]
        public int CityID { get; set; }
        public string PostalCode { get; set; }

    }
}
