using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models.Session
{
    public class UserLoginChannels: BaseModel
    {
        [ForeignKey("User")] 
        [Column(Order = 1)]
        public int UserID { get; set; }

        [ForeignKey("LookupLoginChannels")] 
        [Column(Order = 2)]
        public int LoginChannelID { get; set; }        
    }
}
