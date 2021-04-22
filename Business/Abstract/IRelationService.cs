using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRelationService
    {
        IResult Insert(Relation relation);
        IResult Update(Relation relation);
        IDataResult<List<Relation>> GetAll();
    }
}
