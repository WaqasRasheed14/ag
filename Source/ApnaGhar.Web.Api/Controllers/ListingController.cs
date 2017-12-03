using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApnaGhar.Models.Listings;
using ApnaGhar.IServices;
using Microsoft.EntityFrameworkCore;

namespace ApnaGhar.Web.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Listing")]
    public class ListingController : Controller
    {
        private readonly IListingService _listingService;
        public ListingController(IListingService listingService)
        {
            _listingService = listingService;
        }
        [HttpGet("GetAll")]
        public IEnumerable<Listing> GetAll()
        {
            return _listingService.GetAll()
                .Include(a => a.ListingAvailability)
                .Include(a => a.ListingFurnishing)
                .Include(a => a.ListingLandmarks)
                .Include(a => a.ListingSpecifications)
                .Include(a => a.ListingFacilities);
        }
    }
}