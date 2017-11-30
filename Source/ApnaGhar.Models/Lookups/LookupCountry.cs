using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models.Lookups
{
    public class LookupCountry :BaseModel
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryDesc { get; set; }
        [ForeignKey("LookupContinent")]
        public int ContinentID { get; set; }
        //public LookupContinent LookupContinent { get; set; }
        public ICollection<LookupState> LookupState { get; set; }
    }
}
