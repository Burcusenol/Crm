using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {

        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new  SuccessDataResult<List<Contact>>(_contactDal.GetAll(), Messages.ContactListed);
        }

        public IResult Insert(Contact contact)
        {
            _contactDal.Insert(contact);
            return new SuccessResult(Messages.ContactAdded);
        }

        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult(Messages.ContactUpdated);
        }
    }
}
