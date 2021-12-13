using Business.Abstract;
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

        public List<MainDevice> GetAll()
        {
            return _mainDeviceDal.GetAll();
        }

        public MainDevice GetById(int mainDeviceId)
        {
            return _mainDeviceDal.Get(m => m.DeviceId == mainDeviceId);
        }
    }
}
