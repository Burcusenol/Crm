using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOS
{
    public class ContactUpdateDetailsDto:IDto
    {
        public int Type { get; set; }
        public string AddressType { get; set; }
        public string Neighborhood { get; set; }
        public string MobilePhone { get; set; }

    }
}
