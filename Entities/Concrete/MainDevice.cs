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
    public class MainDevice:IDevice,IEntity
    {
        [Key]
        public int DeviceId { get; set; }
        public int UserId { get; set; }
        public int HomeId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceProps { get; set; }
        public byte Analog { get; set; }
        public byte Digital { get; set; }
    }
}
