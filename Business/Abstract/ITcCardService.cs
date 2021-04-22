using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITcCardService
    {
        IResult Insert(TcCard tcCard);
        IResult Update(TcCard tcCard);
        IDataResult<List<TcCard>> GetAll();
    }
}
