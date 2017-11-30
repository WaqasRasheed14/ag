using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models
{
    public class MediaGallery : BaseModel
    {
        [Key]
        public int MediaGalleryID { get; set; }
        [ForeignKey("User")]
        [Column(Order =1)]
        public int UserID { get; set; }
        [ForeignKey("LookupMedia")]
        [Column(Order = 2)]
        public int MediaTypeID { get; set; }
        public string GalleryName { get; set; }
        public string GalleryDescription { get; set; }
    }

    public class LookupMedia
    {
        [Key]
        public int MediaTypeID { get; set; }
        public string MediaTypeName { get; set; }
        public string MediaTypeDescription { get; set; }
    }

    public class UserMedia : BaseModel
    {
        [Key]
        public int UserMediaID { get; set; }
        [ForeignKey("MediaGallery")]
        public int MediaGalleryID { get; set; }            
    }

    public class MediaSize : BaseModel
    {
        [Key]
        public int MediaSizeID { get; set; }
        [ForeignKey("UserMedia")]
        public int UserMediaID { get; set; }
        public string SmallSizePath { get; set; }
        public string MediumSizePath { get; set; }
        public string LargeSizePath { get; set; }
        public string ThumbnailSizePath { get; set; }

    }
}
