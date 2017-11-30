using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models
{
    public class Feedback : BaseModel
    {
        [Key]
        public int FeedbackID { get; set; }
        [ForeignKey("User")]
        [Column(Order =1)]
        public int UserID { get; set; }
        public string EmailAddrss { get; set; }
        public string FeedbackContent { get; set; }
        [ForeignKey("User")]
        [Column(Order = 2)]
        public string FeedbackCategoryID { get; set; }
    }

    public class FeedbackCategory : BaseModel
    {
        [Key]
        public int FeedbackCategoryID { get; set; }
        public int FeedbackCategoryName { get; set; }
        public int FeedbackCategoryDescription { get; set; }

    }
}
