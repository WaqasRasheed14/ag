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

        [ForeignKey("ListingTypeID")]
        public ListingType ListingType { get; set; }
        [ForeignKey("CurrencyTypeID")]
        public CurrencyType CurrencyType { get; set; }
        public ICollection<ListingSpecifications> ListingSpecificationss { get; set; }
        public ICollection<ListingFurnishing> ListingFurnishings { get; set; }
        public ICollection<ListingAvailability> ListingAvailabilitys { get; set; }
        public ICollection<ListingLandmark> ListingLandmarks { get; set; }
        
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
        [ForeignKey("ListingTypeCategoryID")]
        public ListingTypeCategory ListingTypeCategory { get; set; }

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

    public class ListingFacilities
    {
        [ForeignKey("FacilitiesLookupID")]
        [Column(Order = 1)]
        public FacilitiesLookup FacilitiesLookup { get; set; }
        [ForeignKey("ListingID")]
        [Column(Order = 1)]
        public Listing Listing { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
    public class SpecificationLookup
    {
        [Key]
        public int SpecificationLookupID { get; set; }
        public string SpecificationKey { get; set; }
        public string SpecificationKeyDescription { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<ListingSpecifications> ListingSpecificationss { get; set; }        
    }

    public class ListingSpecifications
    {
        [ForeignKey("SpecificationLookupID")]
        [Column(Order = 1)]
        public SpecificationLookup SpecificationLookup { get; set; }
        [ForeignKey("Listing")]
        [Column(Order =1)]
        public Listing Listing { get; set; }
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

    public class ListingFurnishing
    {
        [ForeignKey("ListingID")]
        [Column(Order = 1)]
        public Listing Listing { get; set; }

        [ForeignKey("LookupFurnishing")]
        [Column(Order = 2)]
        public LookupFurnishing LookupFurnishing { get; set; }
    }

    public class LookupAvailibility
    {
        [Key]
        public int LookupAvailibilityID { get; set; }
        public string AvailibilityName { get; set; }
        public string AvailibilityDescription { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<ListingFurnishing> ListingFurnishing { get; set; }
    }   
    public class ListingAvailability
    {
        [ForeignKey("ListingID")]
        [Column(Order = 1)]
        public Listing Listing { get; set; }

        [ForeignKey("LookupAvailibility")]
        [Column(Order = 2)]
        public LookupAvailibility LookupAvailibility { get; set; }
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
        [ForeignKey("ListingID")]
        [Column(Order = 1)]
        public Listing Listing { get; set; }

        [ForeignKey("LookupLandmark" +
            "ID")]
        [Column(Order = 2)]
        public LookupLandmark LookupLandmark { get; set; }
        public DateTime ModifiedDate { get; set; }
    }   

}
