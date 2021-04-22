using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class City:IEntity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int PostCode { get; set; }
        public int PhoneCode { get; set; }
        public int RowNumber { get; set; }
    }
}
