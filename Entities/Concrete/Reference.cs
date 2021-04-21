using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Reference:IEntity
    {
        public int Id { get; set; }
        public string ReferenceType { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }

    }
}
