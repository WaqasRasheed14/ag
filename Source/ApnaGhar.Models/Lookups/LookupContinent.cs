using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApnaGhar.Models.Lookups
{
    public class LookupContinent :  BaseModel
    {
        [Key]
        public int ContinentID { get; set; }
        public string CountryName { get; set; }
        public string CountryDesc { get; set; }
        public ICollection<LookupCountry> LookupCountry { get; set; }
    }
}
