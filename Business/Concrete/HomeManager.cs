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
    public class HomeManager : IHomeService
    {
        IHomeDal _homeDal;

        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public IDataResult<List<Home>> GetAll()
        {
            return new SuccessDataResult<List<Home>>(_homeDal.GetAll(), Messages.HomeListed);
        }

        public IResult Insert(Home home)
        {
            _homeDal.Insert(home);
            return new SuccessResult(Messages.HomeAdded);
        }

        public IResult Update(Home home)
        {
            _homeDal.Update(home);
            return new SuccessResult(Messages.HomeUpdated);
        }
    }
}
