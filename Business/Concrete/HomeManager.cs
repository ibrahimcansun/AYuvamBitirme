using Business.Abstract;
using Business.Constants;
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
    public class HomeManager : IHomeService
    {
        IHomeDal _homeDal;

        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public IDataResult<List<Home>> GetAll()
        {
            return new SuccessDataResult<List<Home>>(_homeDal.GetAll(), Messages.HomesListed);
        }

        public IResult Add(Home home)
        {
            _homeDal.Add(home);
            return new SuccessResult(Messages.HomeAdded);
        }

        public IResult Update(Home home)
        {
            _homeDal.Add(home);
            return new SuccessResult(Messages.HomeAdded);
        }


    }
}
