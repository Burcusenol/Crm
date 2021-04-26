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
    public class PersonUpdateController : ControllerBase
    {
        IPersonUpdateService _personUpdateService;

        public PersonUpdateController(IPersonUpdateService personUpdateService)
        {
            _personUpdateService = personUpdateService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _personUpdateService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("add")]
        public IActionResult Insert(PersonUpdate personUpdate)
        {
            var result = _personUpdateService.Insert(personUpdate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(PersonUpdate personUpdate)
        {
            var result = _personUpdateService.Update(personUpdate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

