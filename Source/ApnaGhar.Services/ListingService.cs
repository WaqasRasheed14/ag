using ApnaGhar.Base;
using ApnaGhar.Data;
using ApnaGhar.IServices;
using ApnaGhar.Models.Listings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApnaGhar.Services
{
    public class ListingService : ServiceBase<Listing>,IListingService
    {
        public ListingService(AppDBContext appDBContext) : base(appDBContext)
        {

        }
    }
}
