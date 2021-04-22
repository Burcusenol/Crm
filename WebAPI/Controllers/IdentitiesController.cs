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
    public class IdentitiesController : ControllerBase
    {
        IIdentityService _ıdentityService;

        public IdentitiesController(IIdentityService ıdentityService)
        {
            _ıdentityService = ıdentityService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _ıdentityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("add")]
        public IActionResult Insert(Identity ıdentity)
        {
            var result = _ıdentityService.Insert(ıdentity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Identity ıdentity)
        {
            var result = _ıdentityService.Update(ıdentity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
