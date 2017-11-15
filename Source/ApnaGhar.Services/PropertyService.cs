using ApnaGhar.Base;
using ApnaGhar.IServices;
using ApnaGhar.Models;
using System;
using ApnaGhar.Data;

namespace ApnaGhar.Services
{
    public class PropertyService : ServiceBase<Property>, IPropertyService
    {
        // implement extra methods here those are not in base or in interface
        public PropertyService(AppDBContext appDBContext) : base(appDBContext)
        {

        }
    }
}
