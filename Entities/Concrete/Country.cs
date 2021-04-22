using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Country:IEntity
    {
        public int CountryId { get; set; }
        public string BinaryCode { get; set; }
        public string ThirdCode { get; set; }
        public string CountryName { get; set; }
        public string PhoneCode { get; set; }

    }
}
