using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
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

        public IResult Insert(Heading heading)
        {
            _headingDal.Insert(heading);
            return new SuccessResult(Messages.HeadingAdded);
        }

        public IResult Update(Heading heading)
        {
            _headingDal.Update(heading);
            return new SuccessResult(Messages.HeadingUpdated);
        }
    }
}
