using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IdentityManager : IIdentityService
    {
        IIdentityDal _ıdentityDal;

        public IdentityManager(IIdentityDal ıdentityDal)
        {
            _ıdentityDal = ıdentityDal;
        }

        public IDataResult<List<Identity>> GetAll()
        {
            return new SuccessDataResult<List<Identity>>(_ıdentityDal.GetAll(), Messages.IdentityListed);
        }

        [ValidationAspect(typeof(IdentityValidator))]
        public IResult Insert(Identity ıdentity)
        {
            _ıdentityDal.Insert(ıdentity);
            return new SuccessResult(Messages.IdentityAdded);
        }

        public IResult Update(Identity ıdentity)
        {
            _ıdentityDal.Update(ıdentity);
            return new SuccessResult(Messages.IdentityUpdated);
        }
    }
}
