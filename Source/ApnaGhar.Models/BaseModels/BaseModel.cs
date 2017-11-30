using System;
using System.Collections.Generic;
using System.Text;

namespace ApnaGhar.Models.BaseModels
{
    public class BaseModel
    {
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
    }
}
