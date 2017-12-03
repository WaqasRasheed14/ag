using Microsoft.AspNetCore.Mvc;
using ApnaGhar.Models;
using ApnaGhar.IServices;
using System.Collections.Generic;
using ApnaGhar.Data;
using Microsoft.EntityFrameworkCore;

namespace ApnaGhar.Web.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/FAQ")]
    public class FAQController : Controller
    {
        private readonly IFAQService _faqService;
        public FAQController(IFAQService faqService)
        {
            _faqService = faqService;
        }
        [HttpGet("GetAll")]
        public IEnumerable<FAQCategory> GetAll()
        {
            return _faqService.GetAll().Include(a => a.FAQ); ;            
        }
    }
}