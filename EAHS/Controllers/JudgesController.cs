using EAHS.DTOS;
using EAHS.Helper.ExceptionHendling;
using EAHS.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EAHS.Controllers
{
    public class JudgesController : BaseController
    {
        private readonly JudgesServices _judgesServices;
        public JudgesController(JudgesServices judgesServices)
        {
            _judgesServices = judgesServices;
        }
        [HttpPost]
        public ActionResult Post([FromForm] JudgeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _judgesServices.CreateJudge(request) });

        }
        [HttpGet("getJudges")]
        public ActionResult GetJudges()
        {
            try
            {
                return new JsonResult(new { success = true, data = _judgesServices.GetJudges() }); //@temp host hendle
            }
            catch (Exception e)
            {
                throw new ApiException(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            try
            {
                return new JsonResult(new { success = true, data = _judgesServices.GetById(id) }); //@temp host hendle
            }
            catch (Exception e)
            {
                throw new ApiException(e.Message);
            }
        }
        [HttpPatch("{id}")]
        public ActionResult Put(Guid id ,[FromForm] JudgeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _judgesServices.UpdateJudge(id,request) });

        }
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            return new JsonResult(new { success = true, data = _judgesServices.DeleteJudge(id) });

        }
    }
}
