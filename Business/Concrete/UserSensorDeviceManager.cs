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
    public class UserSensorDeviceManager:IUserSensorDeviceService
    {
        IUserSensorDeviceDal _userSensorDeviceDal;
        public UserSensorDeviceManager(IUserSensorDeviceDal userSensorDeviceDal)
        {
            _userSensorDeviceDal = userSensorDeviceDal;
        }

        public IDataResult<List<UserSensorDevice>> GetAll()
        {
            return new SuccessDataResult<List<UserSensorDevice>>(_userSensorDeviceDal.GetAll(), Messages.UserSensorDevicesListed);
        }

        [ValidationAspect(typeof(UserSensorDeviceValidator))]
        public IResult Add(UserSensorDevice userSensorDevice)
        {
            _userSensorDeviceDal.Add(userSensorDevice);
            return new SuccessResult(Messages.UserSensorDeviceAdded);
        }

        [ValidationAspect(typeof(UserSensorDeviceValidator))]
        public IResult Update(UserSensorDevice userSensorDevice)
        {
            _userSensorDeviceDal.Update(userSensorDevice);
            return new SuccessResult(Messages.UserSensorDeviceUpdated);
        }

        public IResult Delete(UserSensorDevice userSensorDevice)
        {
            _userSensorDeviceDal.Delete(userSensorDevice);
            return new SuccessResult(Messages.UserSensorDeviceDeleted);
        }
    }
}
