using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IIdentityService
    {
        IResult Insert(Identity ıdentity);
        IResult Update(Identity ıdentity);
        IDataResult<List<Identity>> GetAll();
    }
}
