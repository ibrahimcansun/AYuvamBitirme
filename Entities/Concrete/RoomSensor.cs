using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Keyless]
    public class RoomSensor:IEntity
    {
        public int RoomId { get; set; }
        public int SensorId { get; set; }
    }
}
