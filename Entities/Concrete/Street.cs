using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Street:IEntity
    {
        public int StreetId { get; set; }
        public string StreetName { get; set; }
        public string Street1Name { get; set; }
        public int PostalCode { get; set; }
        public int DistrictId { get; set; }

    }
}
