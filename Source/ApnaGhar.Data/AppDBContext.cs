using ApnaGhar.Models;
using ApnaGhar.Models.Listings;
using ApnaGhar.Models.Lookups;
using ApnaGhar.Models.Session;
using Microsoft.EntityFrameworkCore;
using System;

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

            builder.Entity<LookupCity>()
           .Property(b => b.CreatedAt)
           .HasDefaultValue(DateTime.Now);

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


    }
}
