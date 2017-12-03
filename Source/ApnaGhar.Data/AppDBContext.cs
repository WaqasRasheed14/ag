using ApnaGhar.Models;
using ApnaGhar.Models.Listings;
using ApnaGhar.Models.Lookups;
using ApnaGhar.Models.Session;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ApnaGhar.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserLoginChannels>().HasKey(table => new {
                table.LoginChannelID,
                table.UserID
            });

            builder.Entity<ListingAvailability>()
                .HasKey(table => new {
                    table.ListingID,
                    table.LookupAvailibilityID
                });

            builder.Entity<ListingFacilities>()
                .HasKey(table => new {
                    table.ListingID,
                    table.FacilitiesLookupID
                });

            builder.Entity<ListingFurnishing>()
                .HasKey(table => new {
                    table.ListingID,
                    table.LookupFurnishingID
                });

            builder.Entity<ListingSpecifications>()
                .HasKey(table => new {
                    table.ListingID,
                    table.SpecificationLookupID
                });

            builder.Entity<ListingLandmark>()
                .HasKey(table => new {
                    table.ListingID,
                    table.LookupLandmarkID
                });

            //
            //
            //
            //

            // builder.Entity<LookupCity>()
            //.Property(b => b.CreatedAt)
            //.HasDefaultValue(DateTime.Now);

            builder.Entity<LookupCity>()
           .Property(b => b.ModifiedAt)
           .HasDefaultValue(DateTime.Now);
        }
        /*public DbSet<Property> Properties { get; set; }        
        public DbSet<LookupContinent> LookupContinent { get; set; }        
        public DbSet<LookupCountry> LookupCountry { get; set; }
        public DbSet<Listing> Listing { get; set; }
        public DbSet<CurrencyType> CurrencyType { get; set; }*/

        public DbSet<LookupLoginChannels> LookupLoginChannels { get; set; }
        public DbSet<UserLoginChannels> UserLoginChannels { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<LookupContinent> LookupContinent { get; set; }
        public DbSet<LookupCountry> LookupCountry { get; set; }
        public DbSet<LookupState> LookupState { get; set; }
        public DbSet<LookupCity> LookupCity { get; set; }
        public DbSet<FAQ> FAQ { get; set; }
        public DbSet<FAQCategory> FAQCategory { get; set; }

        public DbSet<Listing> Listing { get; set; }
        public DbSet<ListingType> ListingType { get; set; }
        public DbSet<CurrencyType> CurrencyType { get; set; }
        public DbSet<ListingSpecifications> ListingSpecifications { get; set; }
        public DbSet<ListingFurnishing> ListingFurnishing { get; set; }
        public DbSet<ListingAvailability> ListingAvailability { get; set; }
        public DbSet<ListingLandmark> ListingLandmark { get; set; }
        public DbSet<ListingTypeCategory> ListingTypeCategory { get; set; }
        public DbSet<FacilitiesLookup> FacilitiesLookup { get; set; }
        public DbSet<ListingFacilities> ListingFacilities { get; set; }
        public DbSet<LookupFurnishing> LookupFurnishing { get; set; }
        public DbSet<LookupAvailibility> LookupAvailibility { get; set; }
        public DbSet<LookupLandmark> LookupLandmark { get; set; }
        
    }
    
}
