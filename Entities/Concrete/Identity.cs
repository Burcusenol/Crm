using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Identity:IEntity
    {
        public int IdentityId { get; set; }
        public string BirthPlace { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Place { get; set; }
        public string Nationality { get; set; }
        public int NationalityStatus { get; set; }


    }
}
