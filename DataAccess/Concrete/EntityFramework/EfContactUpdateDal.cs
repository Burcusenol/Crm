using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
     public class EfContactUpdateDal: EfEntityRepositoryBase<ContactUpdate, CrmContext>, IContactUpdateDal
    {

        public List<ContactUpdateDetailsDto> GetContactUpdateDetails()
        {
            using (CrmContext context=new CrmContext() )
            {

            }

            return null;

        }
    }
}
