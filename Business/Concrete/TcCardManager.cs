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
    public class TcCardManager : ITcCardService
    {
        ITcCardDal _tcCardDal;

        public TcCardManager(ITcCardDal tcCardDal)
        {
            _tcCardDal = tcCardDal;
        }

        public IDataResult<List<TcCard>> GetAll()
        {
            return new SuccessDataResult<List<TcCard>>(_tcCardDal.GetAll(), Messages.TcCardListed);
        }

        public IResult Insert(TcCard tcCard)
        {
            _tcCardDal.Insert(tcCard);
            return new SuccessResult(Messages.TcCardAdded);
        }

        public IResult Update(TcCard tcCard)
        {
            _tcCardDal.Update(tcCard);
            return new SuccessResult(Messages.TcCardUpdated);
        }
    }
}
