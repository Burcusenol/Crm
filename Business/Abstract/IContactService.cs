using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContactService
    {
        IResult Insert(Contact contact);
        IResult Update(Contact contact);
        IDataResult<List<Contact>> GetAll();
    }
}
