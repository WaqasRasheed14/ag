using ApnaGhar.Base;
using ApnaGhar.Data;
using ApnaGhar.IServices;
using ApnaGhar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApnaGhar.Services
{
    public class FAQService : ServiceBase<FAQ>, IFAQService
    {
        public FAQService(AppDBContext appDBContext) : base(appDBContext)
        {

        }
    }
}
