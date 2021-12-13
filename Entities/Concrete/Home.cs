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
    public class Home:IStructure,IEntity
    {
        [Key]
        public int StructureId { get; set; }
        public byte AreaId { get; set; }
        public string StructureName { get; set; }
    }
}
