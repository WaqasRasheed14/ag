using ApnaGhar.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApnaGhar.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Property> Properties { get; set; }
    }
}
