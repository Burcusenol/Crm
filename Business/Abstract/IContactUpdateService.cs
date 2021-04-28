using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IContactUpdateService
    {
        IDataResult<List<ContactUpdate>> GetAll();
        IResult Update(ContactUpdate contactUpdate);

        IDataResult<List<ContactUpdateDetailsDto>> GetContactUpdateDetails();
    }
}
