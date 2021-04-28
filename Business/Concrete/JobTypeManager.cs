using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class JobTypeManager : IJobTypeService
    {
        IJobTypeDal _jobTypeDal;

        public JobTypeManager(IJobTypeDal jobTypeDal)
        {
            _jobTypeDal = jobTypeDal;
        }

        public IResult Insert(JobType jobType)
        {
            _jobTypeDal.Insert(jobType);
            return new SuccessResult();
        }

        public IDataResult<List<JobType>> GetAll()
        {
            return new SuccessDataResult<List<JobType>>(_jobTypeDal.GetAll());
        }

        public IResult Update(JobType jobType)
        {
            _jobTypeDal.Update(jobType);
            return new SuccessResult();
        }
    }
}
