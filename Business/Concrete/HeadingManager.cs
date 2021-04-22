using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;
       

        public HeadingManager(IHeadingDal headingDal,IContactService contactService)
        {
            _headingDal = headingDal;
            
        }

        public IDataResult<List<Heading>> GetAll()
        {
            return new SuccessDataResult<List<Heading>>(_headingDal.GetAll(), Messages.HeadingListed);
        }

        public IDataResult<List<HeadingDetailDto>> GetHeadingDetails()
        {
            return new SuccessDataResult<List<HeadingDetailDto>>(_headingDal.GetHeadingDetails());
        }

        [ValidationAspect(typeof(HeadingValidator))]
        public IResult Insert(Heading heading)
        {
            IResult result = BusinessRules.Run(CheckIfTcAlreadyExists(heading.Identification));

            if(result!=null)
            {
                return result;
            }
            _headingDal.Insert(heading);
            return new SuccessResult(Messages.HeadingAdded);
        }

        public IResult Update(Heading heading)
        {
            _headingDal.Update(heading);
            return new SuccessResult(Messages.HeadingUpdated);
        }

        private IResult CheckIfTcAlreadyExists(string tcnumber)
        {
            var result = _headingDal.GetAll(h => h.Identification == tcnumber).Any();

            if(result)
            {
                return new ErrorResult(Messages.TcAlreadyExists);
            }
            return new SuccessResult();
        }
        
    }
}
