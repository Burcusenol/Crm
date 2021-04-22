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
    public class TcCardsController : ControllerBase
    {
        ITcCardService _tcCardService;

        public TcCardsController(ITcCardService tcCardService)
        {
            _tcCardService = tcCardService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _tcCardService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("add")]
        public IActionResult Insert(TcCard tcCard)
        {
            var result = _tcCardService.Insert(tcCard);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(TcCard tcCard)
        {
            var result = _tcCardService.Update(tcCard);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
