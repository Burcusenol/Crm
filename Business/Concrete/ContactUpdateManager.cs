using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ContactUpdateManager : IContactUpdateService
    {
        IContactUpdateDal _contactUpdateDal;

        public ContactUpdateManager(IContactUpdateDal contactUpdateDal)
        {
            _contactUpdateDal = contactUpdateDal;
        }

        public IDataResult<List<ContactUpdate>> GetAll()
        {
            return new SuccessDataResult<List<ContactUpdate>>(_contactUpdateDal.GetAll());
        }

        public IDataResult<List<ContactUpdateDetailsDto>> GetContactUpdateDetails()
        {
            return new SuccessDataResult<List<ContactUpdateDetailsDto>>(_contactUpdateDal.GetContactUpdateDetails());
        }

        public IResult Update(ContactUpdate contactUpdate)
        {
            _contactUpdateDal.Update(contactUpdate);
                return new SuccessResult();
        }
    }
}
