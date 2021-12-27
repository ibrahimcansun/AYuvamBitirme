using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NormalUsersController : ControllerBase
    {
        INormalUserService _userService;

        public NormalUsersController(INormalUserService normalUserService)
        {
            _userService = normalUserService;
        }

        
    }
}
