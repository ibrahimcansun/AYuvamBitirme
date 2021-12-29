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
    public class SensorDevicesController : ControllerBase
    {
        ISensorDeviceService _sensorDeviceService;
        public SensorDevicesController(ISensorDeviceService sensorDeviceService)
        {
            _sensorDeviceService = sensorDeviceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sensorDeviceService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(SensorDevice sensorDevice)
        {
            var result = _sensorDeviceService.Add(sensorDevice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(SensorDevice sensorDevice)
        {
            var result = _sensorDeviceService.Update(sensorDevice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SensorDevice sensorDevice)
        {
            var result = _sensorDeviceService.Delete(sensorDevice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
