using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IDevice
    {
        public int DeviceId { get; set; }
        public int UserId { get; set; }
        public int HomeId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceProps { get; set; }
    }
}
