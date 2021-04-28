using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTypeController : ControllerBase
    {
        IJobTypeService _jobTypeService;

        public JobTypeController(IJobTypeService jobTypeService)
        {
            _jobTypeService = jobTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _jobTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("add")]
        public IActionResult Insert(JobType jobType)
        {
            var result = _jobTypeService.Insert(jobType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(JobType jobType)
        {
            var result = _jobTypeService.Update(jobType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

