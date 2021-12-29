using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INormalUserService
    {
        //List<NormalUser> GetAll();
        IDataResult<List<NormalUser>> GetAll();
        IDataResult<NormalUser> GetById(int userId);
        IResult Add(NormalUser normalUser);
        IResult Update(NormalUser normalUser);
        IResult Delete(NormalUser normalUser);
    }
}
