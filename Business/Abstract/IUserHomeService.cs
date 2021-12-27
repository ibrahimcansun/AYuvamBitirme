using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserHomeService
    {
        IDataResult<List<UserHome>> GetAll();
        IDataResult<List<UserHomeNameDto>> GetUserHomeName();
        IDataResult<List<UserHome>> GetAllByUserId(int userId);
        IDataResult<List<UserHome>> GetAllByHomeId(int homeId);
        IResult Add(UserHome userHome);
        IResult Update(UserHome userHome);
    }
}
