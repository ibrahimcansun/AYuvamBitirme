using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISensorDeviceService
    {
        IDataResult<List<SensorDevice>> GetAll();
        //IDataResult<SensorDevice> DeviceWork(SensorDevice sensorDevice);
        IResult Add(SensorDevice sensorDevice);
        IResult Update(SensorDevice sensorDevice);
        IResult Delete(SensorDevice sensorDevice);
    }
}
