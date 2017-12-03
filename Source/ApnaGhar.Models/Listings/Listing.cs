using ApnaGhar.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApnaGhar.Models.Listings
{
    public class Listing : BaseModel
    {
        [Key]
        public int ListingID { get; set; }

        [ForeignKey("ListingType")]
        public int ListingTypeID { get; set; }
        [ForeignKey("CurrencyType")]
        public int CurrencyTypeID { get; set; }
        public int Price { get; set; }
        public bool IsNegotiable { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public string SizeMeasurement { get; set; }
        public ICollection<ListingSpecifications> ListingSpecifications { get; set; }
        public ICollection<ListingFurnishing> ListingFurnishing { get; set; }
        public ICollection<ListingAvailability> ListingAvailability { get; set; }
        public ICollection<ListingLandmark> ListingLandmarks { get; set; }
        public ICollection<ListingFacilities> ListingFacilities { get; set; }

    }
   
    public class ListingTypeCategory : BaseModel
    {
        [Key]
        public int ListingTypeCategoryID { get; set; }

        public ICollection<ListingType> ListingTypes { get; set; }
    }
    public class ListingType : BaseModel
    {
        [Key]
        public int ListingTypeID { get; set; }
        [ForeignKey("ListingTypeCategory")]
        public int ListingTypeCategoryID { get; set; }

        public string ListingTypeName { get; set; }
        public string ListingTypeDescription { get; set; }
        public ICollection<Listing> Listings { get; set; }
    }
    public class CurrencyType : BaseModel
    {
        [Key]
        public int CurrencyTypeID { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyDescription { get; set; }
        public string CurrencySymbol { get; set; }
        public ICollection<Listing> Listings { get; set; }
    }

    public class FacilitiesLookup : BaseModel
    {
        [Key]
        public int FacilityID { get; set; }
        public string FacilityName { get; set; }
        public string FacilityDescription { get; set; }
        public ICollection<ListingFacilities> ListingFacilitiess { get; set; }
    }

    public class ListingFacilities : BaseModel
    {
        [ForeignKey("FacilitiesLookup")]
        [Column(Order = 1)]
        public int FacilitiesLookupID { get; set; }
        [ForeignKey("ListingID")]
        [Column(Order = 1)]
        public int ListingID { get; set; }
    }
    public class SpecificationLookup : BaseModel
    {
        [Key]
        public int SpecificationLookupID { get; set; }
        public string SpecificationKey { get; set; }
        public string SpecificationKeyDescription { get; set; }
        public ICollection<ListingSpecifications> ListingSpecificationss { get; set; }        
    }

    public class ListingSpecifications : BaseModel
    {
        [ForeignKey("SpecificationLookup")]
        [Column(Order = 1)]
        public int SpecificationLookupID { get; set; }
        [ForeignKey("Listing")]
        [Column(Order =1)]
        public int ListingID { get; set; }
    }

    public class LookupFurnishing
    {
        [Key]
        public int LookupFurnishingID { get; set; }
        public string FurnishingItemName { get; set; }
        public string FurnishingItemDescription { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<ListingFurnishing> ListingFurnishing { get; set; }
    }

    public class ListingFurnishing : BaseModel
    {
        [ForeignKey("Listing")]
        [Column(Order = 1)]
        public int ListingID { get; set; }

        [ForeignKey("LookupFurnishing")]
        [Column(Order = 2)]
        public int LookupFurnishingID { get; set; }
    }

    public class LookupAvailibility
    {
        [Key]
        public int LookupAvailibilityID { get; set; }
        public string AvailibilityName { get; set; }
        public string AvailibilityDescription { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<ListingAvailability> ListingAvailability { get; set; }
    }   
    public class ListingAvailability
    {
        [ForeignKey("Listing")]
        [Column(Order = 1)]
        public int ListingID { get; set; }

        [ForeignKey("LookupAvailibility")]
        [Column(Order = 2)]
        public int LookupAvailibilityID { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class LookupLandmark
    {
        [Key]
        public int LookupLandmarkID { get; set; }
        public string AvailibilityName { get; set; }
        public string AvailibilityDescription { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<ListingLandmark> ListingLandmark { get; set; }
    }
    public class ListingLandmark
    {
        [ForeignKey("Listing")]
        [Column(Order = 1)]
        public int ListingID { get; set; }

        [ForeignKey("LookupLandmark")]
        [Column(Order = 2)]
        public int LookupLandmarkID { get; set; }
        public DateTime ModifiedDate { get; set; }
    }   

}
