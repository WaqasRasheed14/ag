using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models
{
    public class FAQ : BaseModel
    {
        [Key]
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
        [ForeignKey("FAQCategory")]
        public int FAQCategoryID { get; set; }        

    }

    public class FAQCategory : BaseModel
    {
        [Key]
        public int FAQCategoryID { get; set; }
        public string FAQCategoryName { get; set; }
        public string FAQCategoryDescription { get; set; }
        public ICollection<FAQ> FAQ { get; set; }

    }
}
