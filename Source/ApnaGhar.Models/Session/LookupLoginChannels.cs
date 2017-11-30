using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApnaGhar.Models.Session
{
    public class LookupLoginChannels
    {
        [Key]
        public int LoginChannelID { get; set; }
        public string ChannelName { get; set; }
        public string ChannelDescription { get; set; }

    }
}
