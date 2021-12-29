using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserSensorDeviceService
    {
        IDataResult<List<UserSensorDevice>> GetAll();
        IResult Add(UserSensorDevice userSensorDevice);
        IResult Update(UserSensorDevice userSensorDevice);
        IResult Delete(UserSensorDevice userSensorDevice);
    }
}
