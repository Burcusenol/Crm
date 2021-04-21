using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Relation:IEntity
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; } 
    }
}
