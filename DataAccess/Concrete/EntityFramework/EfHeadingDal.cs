using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHeadingDal : EfEntityRepositoryBase<Heading, CrmContext>, IHeadingDal
    {
        public List<HeadingDetailDto> GetHeadingDetails()
        {
            using (CrmContext context=new CrmContext())
            {
                var result = from h in context.Headings
                             join ı in context.Identities
                             on h.IdentityId equals ı.IdentityId
                             select new HeadingDetailDto
                             {
                                 
                                 Department = h.Department,
                                 FatherName = ı.FatherName,
                                 MotherName = ı.MotherName,
                                 BirthDate = h.BirthDate,
                                 BirthPlace = ı.BirthPlace,
                                 ContactLanguage = h.ContactLanguage,
                                 FirstDate = h.FirstDate,
                                 Gender = h.Gender,
                                 Identification = h.Identification,
                                 KVK = h.KVK,
                                 Name = h.Name,
                                 SecondName = h.SecondName,
                                 SurName = h.SurName,
                                 Nationality = ı.Nationality,
                                 NationalityStatus=ı.NationalityStatus,
                                 Place = ı.Place,




                             };


                return result.ToList();
            }
            
          
        }
    }
}



 


