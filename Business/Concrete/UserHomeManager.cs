using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserHomeManager : IUserHomeService
    {
        IUserHomeDal _userHomeDal;
        public UserHomeManager(IUserHomeDal userHomeDal)
        {
            _userHomeDal = userHomeDal;
        }

        public IDataResult<List<UserHome>> GetAll()
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<UserHome>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<UserHome>>(_userHomeDal.GetAll(), Messages.HomesListed);
        }

        public IDataResult<List<UserHome>> GetAllByHomeId(int homeId)
        {
            return new SuccessDataResult<List<UserHome>>(_userHomeDal.GetAll(h=>h.HomeId == homeId));
        }

        public IDataResult<List<UserHome>> GetAllByUserId(int userId)
        {
            return new SuccessDataResult<List<UserHome>>(_userHomeDal.GetAll(h=>h.UserId == userId));
        }

        public IDataResult<List<UserHomeNameDto>> GetUserHomeName()
        {
            return new SuccessDataResult<List<UserHomeNameDto>>(_userHomeDal.GetUserHomeName());
        }

        [ValidationAspect(typeof(UserHomeValidator))]
        public IResult Add(UserHome userHome)
        {
            IResult result = BusinessRules.Run(CheckIfUserHomeCountBigger(userHome.HomeId));

            if (result != null)
            {
                return result;
            }

            _userHomeDal.Add(userHome);
            return new SuccessResult(Messages.HomeAdded);
        }
        [ValidationAspect(typeof(UserHomeValidator))]
        public IResult Update(UserHome userHome)
        {
            _userHomeDal.Update(userHome);
            return new SuccessResult(Messages.HomeUpdated);
        }

        private IResult CheckIfUserHomeCountBigger(int homeId)
        {
            var result = _userHomeDal.GetAll(uhm => uhm.HomeId == homeId).Count();
            if (result > 5)
            {
                return new ErrorResult(Messages.UserHomeBigger);
            }
            return new SuccessResult();
        }
    }
}
