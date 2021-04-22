using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IHomeService
    {
        IResult Insert(Home home);
        IResult Update(Home home);
        IDataResult<List<Home>> GetAll();
    }
}
