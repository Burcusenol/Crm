using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHeadingService
    {
        IResult Insert(Heading heading);
        IResult Update(Heading heading);
        IDataResult<List<Heading>> GetAll();
        IDataResult<List<HeadingDetailDto>> GetHeadingDetails(); 
    }
}
