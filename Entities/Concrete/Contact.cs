using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Contact:IEntity
    {
        public int Id { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string OfficePhone { get; set; }
        public string Email { get; set; }
        public string WebAddress { get; set; }

    }
}
