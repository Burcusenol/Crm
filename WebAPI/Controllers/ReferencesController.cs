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
    public class ReferencesController : ControllerBase
    { 
        IReferenceService _referenceService;

        public ReferencesController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _referenceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("add")]
        public IActionResult Insert(Reference reference)
        {
            var result = _referenceService.Insert(reference);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Reference reference)
        {
            var result = _referenceService.Update(reference);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
