using EAHS.Controllers;
using EAHS.DTOS;
using EAHS.Infrastructure;
using EAHS.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CGT_API.Controllers
{
    public class CountryController : BaseController
    {
        private readonly CountryServices _countryServices;
        public CountryController(CountryServices countryServices)
        {
            _countryServices = countryServices;
        }
        // GET: api/<CountryController>
        [HttpGet]
        public ActionResult Get([FromQuery] FiltersRequestDTO request)
        {
            try
            {
                return new JsonResult(new { success = true, data = _countryServices.Get(request) }); //@temp host hendle
            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CountryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
