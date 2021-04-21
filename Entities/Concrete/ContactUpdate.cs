using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ContactUpdate:IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Purpose { get; set; }
        public string Description { get; set; }

    }
}
