using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHomeService
    {
        IDataResult<List<Home>> GetAll();
        IResult Add(Home home);
        IResult Update(Home home);
        IResult Delete(Home home);
    }
}
