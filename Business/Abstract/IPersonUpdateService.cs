using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonUpdateService
    {
        IResult Insert(PersonUpdate personUpdate);
        IResult Update(PersonUpdate personUpdate);
        IDataResult<List<PersonUpdate>> GetAll();
        
    }
}
