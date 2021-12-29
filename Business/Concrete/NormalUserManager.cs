using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
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
    public class NormalUserManager : INormalUserService
    {
        INormalUserDal _normalUserDal;

        public NormalUserManager(INormalUserDal normalUserDal)
        {
            _normalUserDal = normalUserDal;
        }

        public IDataResult<List<NormalUser>> GetAll()
        {
            //iş kodları
            //yetkisi var mı
            return new SuccessDataResult<List<NormalUser>>(_normalUserDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<NormalUser> GetById(int userId)
        {
            return new SuccessDataResult<NormalUser>(_normalUserDal.Get(u => u.UserId == userId));
        }

        [ValidationAspect(typeof(NormalUserValidator))]
        public IResult Add(NormalUser normalUser)
        {
            IResult result = BusinessRules.Run(CheckIfUserEmailUsed(normalUser.Email));

            if (result!=null)
            {
                return result;
            }
            _normalUserDal.Add(normalUser);
            return new SuccessResult(Messages.UserCreated);
        }

        [ValidationAspect(typeof(NormalUserValidator))]
        public IResult Update(NormalUser normalUser)
        {
            IResult result = BusinessRules.Run(CheckIfUserEmailUsed(normalUser.Email));

            if (result != null)
            {
                return result;
            }
            _normalUserDal.Update(normalUser);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IResult Delete(NormalUser normalUser)
        {
            _normalUserDal.Delete(normalUser);
            return new SuccessResult(Messages.UserDeleted);
        }

        private IResult CheckIfUserEmailUsed(string email)
        {
            var result = _normalUserDal.GetAll(u => u.Email == email).ToString();
            if(result == email)
            {
                return new ErrorResult(Messages.EmailUsing);
            }
            return new SuccessResult();
        }
    }
}
