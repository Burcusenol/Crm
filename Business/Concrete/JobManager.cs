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
    public class JobManager : IJobService
    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public IDataResult<List<Job>> GetAll()
        {
            return new SuccessDataResult<List<Job>>(_jobDal.GetAll(), Messages.JobListed);
        }

        [ValidationAspect(typeof(JobValidator))]
        public IResult Insert(Job job)
        {
            _jobDal.Insert(job);
            return new SuccessResult(Messages.JobAdded);

        }

        public IResult Update(Job job)
        {
            _jobDal.Update(job);
            return new SuccessResult(Messages.JobUpdated);
        }
    }
}
