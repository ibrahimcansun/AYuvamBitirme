using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class UserSensorDevicesController : ControllerBase
    {
        IUserSensorDeviceService _userSensorDevice;
        public UserSensorDevicesController(IUserSensorDeviceService userSensorDevice)
        {
            _userSensorDevice = userSensorDevice;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userSensorDevice.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(UserSensorDevice userSensorDevice)
        {
            var result = _userSensorDevice.Add(userSensorDevice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(UserSensorDevice userSensorDevice)
        {
            var result = _userSensorDevice.Update(userSensorDevice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(UserSensorDevice userSensorDevice)
        {
            var result = _userSensorDevice.Delete(userSensorDevice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
