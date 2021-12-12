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
    public class NormalUserManager : INormalUserService
    {
        INormalUserDal _normalUserDal;

        public NormalUserManager(INormalUserDal normalUserDal)
        {
            _normalUserDal = normalUserDal;
        }

        public List<NormalUser> GetAll()
        {
            //iş kodları
            //yetkisi var mı
            return _normalUserDal.GetAll();
        }

        public List<NormalUser> GetAllByHomeId(int id)
        {
            return _normalUserDal.GetAll(u => u.HomeId == id);
        }


    }
}
