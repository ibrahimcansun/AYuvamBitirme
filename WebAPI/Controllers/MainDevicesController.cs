using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainDevicesController : ControllerBase
    {
        IMainDeviceService _mainDeviceService;

        public MainDevicesController(IMainDeviceService mainDeviceService)
        {
            _mainDeviceService = mainDeviceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _mainDeviceService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(MainDevice mainDevice)
        {
            var result = _mainDeviceService.Add(mainDevice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(MainDevice mainDevice)
        {
            var result = _mainDeviceService.Update(mainDevice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(MainDevice mainDevice)
        {
            var result = _mainDeviceService.Delete(mainDevice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}
