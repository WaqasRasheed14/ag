using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models.Lookups
{
    public class LookupCity : BaseModel
    {
        [Key]
        public int CityID { get; set; }

        [ForeignKey("LookupState")]
        public int StateID { get; set; }
        //public LookupState LookupState { get; set; }
        public string CityName { get; set; }
        public string CityDesc { get; set; }    
    }
}
