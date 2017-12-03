using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ApnaGhar.IServices;
using ApnaGhar.Models;
using ApnaGhar.Data;
using Microsoft.EntityFrameworkCore;

namespace ApnaGhar.Web.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/FAQCategory")]
    public class FAQCategoryController : Controller
    {
        private readonly IFAQCategoryService _faqCategoryService;

        public FAQCategoryController(IFAQCategoryService faqCategoryService)
        {
            _faqCategoryService= faqCategoryService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<FAQCategory> GetAll()
        {   
            return _faqCategoryService.GetAll().Include(a => a.FAQ);         
        }

    }
}