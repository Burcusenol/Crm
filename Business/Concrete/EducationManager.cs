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
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public IDataResult<List<Education>> GetAll()
        {
            return new SuccessDataResult<List<Education>>(_educationDal.GetAll(), Messages.EducationListed);
        }

        public IResult Insert(Education education)
        {
            _educationDal.Insert(education);
            return new SuccessResult(Messages.EducationAdded);
        }

        public IResult Update(Education education)
        {
            _educationDal.Update(education);
            return new SuccessResult(Messages.EducationUpdated);
        }
    }
}
