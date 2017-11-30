using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models.Lookups
{
    public class LookupState : BaseModel
    {
        [Key]
        public int StateID { get; set; }

        [ForeignKey("LookupCountry")]
        public int CountryID { get; set; }        
        public string StateName { get; set; }
        public string StateDesc { get; set; }
        public ICollection<LookupCity> LookupCity { get; set; }
    }
}
