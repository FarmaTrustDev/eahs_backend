using EAHS.DTOS;
using EAHS.Helper.ExceptionHendling;
using EAHS.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EAHS.Controllers
{
    public class RulesController : BaseController
    {
        private readonly RulesServices _rulesServices;
        public RulesController(RulesServices rulesServices)
        {
            _rulesServices = rulesServices;
        }
        /*[HttpPut]
        public ActionResult Put([FromForm] RuleRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _rulesServices.Update(request) });

        }*/
    }
}
