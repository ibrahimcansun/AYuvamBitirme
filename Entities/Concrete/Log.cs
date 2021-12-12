using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Log:IEntity
    {
        [Key]
        public int LogId { get; set; }
        public DateTime Date { get; set; }
        public string Information { get; set; }

    }
}
