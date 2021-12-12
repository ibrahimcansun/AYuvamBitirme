using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SensorDevice:IDevice,IEntity
    {
        [Key]
        public int DeviceId { get; set; }
        public int UserId { get; set; }
        public int HomeId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceProps { get; set; }
        public bool State { get; set; }
    }
}
