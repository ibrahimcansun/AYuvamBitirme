using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMainDeviceService
    {
        IDataResult<List<MainDevice>> GetAll();
        IDataResult<List<MainDevice>> GetById(int mainDeviceId);
        IResult Add(MainDevice mainDevice);
        IResult Update(MainDevice mainDevice);
        IResult Delete(MainDevice mainDevice);
    }
}
