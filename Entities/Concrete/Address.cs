using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Address:IEntity
    {
        public int Id { get; set; }
        public string RecipientName{ get; set; }
        public string AddressType { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Street1 { get; set; }
        public string Apartment { get; set; }
        public int ApartmentNo { get; set; }
        public int PostalCode { get; set; }


    }
}
