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
    public class HeadingsController : ControllerBase
    {
        IHeadingService _headingService;

        public HeadingsController(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _headingService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getheadingDetails")]
        public IActionResult GetHeadingDetails()
        {
            var result = _headingService.GetHeadingDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Insert(Heading  heading)
        {
            var result = _headingService.Insert(heading);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Heading heading)
        {
            var result = _headingService.Update(heading);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
