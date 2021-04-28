using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Relation:IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; } 
    }
}
