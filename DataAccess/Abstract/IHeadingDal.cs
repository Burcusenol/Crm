using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IHeadingDal: IEntityRepository<Heading>
    {
        List<HeadingDetailDto> GetHeadingDetails();
    }
}
