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
    public class ContactUpdateController : ControllerBase
    {
        IContactUpdateService _contactUpdateService;

        public ContactUpdateController(IContactUpdateService contactUpdateService)
        {
            _contactUpdateService = contactUpdateService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _contactUpdateService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update(ContactUpdate contactUpdate)
        {
            var result = _contactUpdateService.Update(contactUpdate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
