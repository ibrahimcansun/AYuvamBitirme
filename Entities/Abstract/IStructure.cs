using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IStructure
    {
        public int StructureId { get; set; }
        public byte AreaId { get; set; }
        public string StructureName { get; set; }
    }
}
