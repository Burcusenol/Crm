using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonUpdateManager : IPersonUpdateService
    {

        IPersonUpdateDal _personUpdateDal;

        public PersonUpdateManager(IPersonUpdateDal personUpdateDal)
        {
            _personUpdateDal = personUpdateDal;
        }

        public IDataResult<List<PersonUpdate>> GetAll()
        {
            return new SuccessDataResult<List<PersonUpdate>>(_personUpdateDal.GetAll());
        }

        public IResult Insert(PersonUpdate personUpdate)
        {
            _personUpdateDal.Insert(personUpdate);
            return new SuccessResult();
        }

        public IResult Update(PersonUpdate personUpdate)
        {
            _personUpdateDal.Update(personUpdate);
            return new SuccessResult();
        }
    }
}
