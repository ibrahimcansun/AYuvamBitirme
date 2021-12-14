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

        [HttpGet]
        public List<UserHome> Get()
        {
            var result = _userHomeService.GetAll();

            return result.Data;
        }
    }
}
