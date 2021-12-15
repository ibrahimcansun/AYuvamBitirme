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
    public class UserHomesController : ControllerBase
    {
        IUserHomeService _userHomeService;

        public UserHomesController(IUserHomeService userHomeService)
        {
            _userHomeService = userHomeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userHomeService.GetAll();

            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyhomeid")]
        public IActionResult GetByHomeId(int homeId)
        {
            var result = _userHomeService.GetAllByHomeId(homeId);
            
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        /*
        [HttpPost]
        public IActionResult Post(UserHome userHome)
        {
            var result = _userHomeService.Add(userHome);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }*/
    }
}
