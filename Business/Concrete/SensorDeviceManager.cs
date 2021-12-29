using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SensorDeviceManager : ISensorDeviceService
    {
        ISensorDeviceDal _sensorDeviceDal;
        public SensorDeviceManager(ISensorDeviceDal sensorDeviceDal)
        {
            _sensorDeviceDal = sensorDeviceDal;
        }

        public IDataResult<List<SensorDevice>> GetAll()
        {
            return new SuccessDataResult<List<SensorDevice>>(_sensorDeviceDal.GetAll(), Messages.SensorsListed);
        }

        [ValidationAspect(typeof(SensorDeviceValidator))]
        public IResult Add(SensorDevice sensorDevice)
        {
            _sensorDeviceDal.Add(sensorDevice);
            return new SuccessResult(Messages.SensorAdded);
        }

        [ValidationAspect(typeof(SensorDeviceValidator))]
        public IResult Update(SensorDevice sensorDevice)
        {
            _sensorDeviceDal.Update(sensorDevice);
            return new SuccessResult(Messages.SensorUpdated);
        }

        public IResult Delete(SensorDevice sensorDevice)
        {
            _sensorDeviceDal.Delete(sensorDevice);
            return new SuccessResult(Messages.UserDeleted);
        }
    }
}
