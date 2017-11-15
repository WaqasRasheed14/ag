using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApnaGhar.IServices;
using ApnaGhar.Models;

namespace ApnaGhar.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IPropertyService _propertyService;

        public ValuesController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Property> Get()
        {
            return _propertyService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Property property)
        {
            _propertyService.Add(property);
            _propertyService.Save();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
