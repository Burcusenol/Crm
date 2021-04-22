using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IJobService
    {
        IResult Insert(Job job);
        IResult Update(Job job);
        IDataResult<List<Job>> GetAll();
    }
}
