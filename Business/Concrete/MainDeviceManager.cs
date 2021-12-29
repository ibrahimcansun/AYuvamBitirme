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
    public class MainDeviceManager : IMainDeviceService
    {
        IMainDeviceDal _mainDeviceDal;

        public MainDeviceManager(IMainDeviceDal mainDeviceDal)
        {
            _mainDeviceDal = mainDeviceDal;
        }
        public IDataResult<List<MainDevice>> GetAll()
        {
            return new SuccessDataResult<List<MainDevice>>(_mainDeviceDal.GetAll(), Messages.MainDevicesListed);
        }

        [ValidationAspect(typeof(MainDeviceValidator))]
        public IResult Add(MainDevice mainDevice)
        {
            _mainDeviceDal.Add(mainDevice);
            return new SuccessResult(Messages.MainDeviceCreated);
        }

        [ValidationAspect(typeof(MainDeviceValidator))]
        public IResult Update(MainDevice mainDevice)
        {
            _mainDeviceDal.Update(mainDevice);
            return new SuccessResult(Messages.MainDeviceUpdated);
        }

        public IResult Delete(MainDevice mainDevice)
        {
            _mainDeviceDal.Delete(mainDevice);
            return new SuccessResult(Messages.MainDeviceDeleted);
        }

        public IDataResult<List<MainDevice>> GetById(int mainDeviceId)
        {
            return new SuccessDataResult<List<MainDevice>>(_mainDeviceDal.GetAll(m => m.DeviceId == mainDeviceId));
        }
    }
}
