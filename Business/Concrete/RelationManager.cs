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
    public class RelationManager : IRelationService
    {
        IRelationDal _relationDal;

        public RelationManager(IRelationDal relationDal)
        {
            _relationDal = relationDal;
        }

        public IDataResult<List<Relation>> GetAll()
        {
            return new SuccessDataResult<List<Relation>>(_relationDal.GetAll(), Messages.RelationListed);
        }

        public IResult Insert(Relation relation)
        {
            _relationDal.Insert(relation);
            return new SuccessResult(Messages.RelationAdded);
        }

        public IResult Update(Relation relation)
        {
            _relationDal.Update(relation);
            return new SuccessResult(Messages.RelationUpdated);
        }
    }
}
