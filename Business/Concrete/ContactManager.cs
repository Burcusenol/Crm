using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [ValidationAspect(typeof(ContactValidator))]
        public IResult Insert(Contact contact)
        {

            IResult result = BusinessRules.Run(CheckIfPhoneNumberExists(contact.MobilePhone));
               
            if(result!=null)
            {
                return result;
            }
            _contactDal.Insert(contact);
            return new SuccessResult(Messages.ContactAdded);
        }

        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult(Messages.ContactUpdated);
        }

        private IResult CheckIfPhoneNumberExists(string phoneNumber)
        {
            var result = _contactDal.GetAll(c => c.MobilePhone == phoneNumber).Any();
            if(result)
            {
                return new ErrorResult(Messages.PhoneNumberAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}
