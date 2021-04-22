using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEducationService
    {
        IResult Insert(Education education);
        IResult Update(Education education);
        IDataResult<List<Education>> GetAll();
    }
}
