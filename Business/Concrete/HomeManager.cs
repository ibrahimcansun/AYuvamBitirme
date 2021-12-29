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

        [ValidationAspect(typeof(HomeValidator))]
        public IResult Add(Home home)
        {
            _homeDal.Add(home);
            return new SuccessResult(Messages.HomeAdded);
        }

        [ValidationAspect(typeof(HomeValidator))]
        public IResult Update(Home home)
        {
            _homeDal.Update(home);
            return new SuccessResult(Messages.HomeUpdated);
        }

        public IResult Delete(Home home)
        {
            _homeDal.Delete(home);
            return new SuccessResult(Messages.HomeDeleted);
        }
    }
}
