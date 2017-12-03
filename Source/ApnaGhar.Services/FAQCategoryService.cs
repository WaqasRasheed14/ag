using ApnaGhar.Base;
using ApnaGhar.Data;
using ApnaGhar.IServices;
using ApnaGhar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApnaGhar.Services
{
    public class FAQCategoryService : ServiceBase<FAQCategory>, IFAQCategoryService
    {
        public FAQCategoryService(AppDBContext appDBContext) : base(appDBContext)
        {

        }
    }
}
