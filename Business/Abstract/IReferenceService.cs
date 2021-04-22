using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IReferenceService
    {
        IResult Insert(Reference reference);
        IResult Update(Reference reference);
        IDataResult<List<Reference>> GetAll();
    }
}
