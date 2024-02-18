using EAHS.DTOS;
using EAHS.Helper.ExceptionHendling;
using EAHS.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EAHS.Controllers
{
    public class RulesController : BaseController
    {
        private readonly RulesServices _rulesServices;
        public RulesController(RulesServices rulesServices)
        {
            _rulesServices = rulesServices;
        }
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return new JsonResult(new { success = true, data = _rulesServices.GetAll() }) ; //@temp host hendle
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut]
        public ActionResult Put(List<RuleRequestDTO> request)
        {
            return new JsonResult(new { success = true, data = _rulesServices.Update(request) });

        }
    }
}
