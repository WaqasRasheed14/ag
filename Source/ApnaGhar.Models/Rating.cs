using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApnaGhar.Models
{
    public class Rating
    {
        [Key]
        public int RatingID { get; set; }
        [Required]
        [Range(1, 5)]
        public int RatingNum { get; set; }
        public int RatingFromID { get; set; }
        public int RatingToID { get; set; }
        public string RatingFeedback { get; set; }
    }
}
