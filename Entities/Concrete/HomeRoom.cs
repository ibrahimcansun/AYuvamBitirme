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
    public class HomeRoom:IEntity
    {
        public int HomeId { get; set; }
        public int RoomId { get; set; }
    }
}
