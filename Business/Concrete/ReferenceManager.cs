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
    public class ReferenceManager : IReferenceService
    {
        IReferenceDal _referenceDal;

        public ReferenceManager(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }

        public IDataResult<List<Reference>> GetAll()
        {
            return new SuccessDataResult<List<Reference>>(_referenceDal.GetAll(), Messages.ReferenceListed);
        }

        public IResult Insert(Reference reference)
        {
            _referenceDal.Insert(reference);
            return new SuccessResult(Messages.RelationAdded);

        }

        public IResult Update(Reference reference)
        {
            _referenceDal.Update(reference);
            return new SuccessResult(Messages.ReferenceUpdated);
        }
    }
}
