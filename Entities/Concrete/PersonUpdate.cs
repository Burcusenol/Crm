using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class PersonUpdate:IEntity
    {
        public int Id { get; set; }
        public string PersonType { get; set; }
        public string KVKStatus { get; set; }
        public string PersonName { get; set; }
        public string PersonStatus { get; set; }
        public string Segment { get; set; }
        public string ActionSegment { get; set; }
        public string Portfolio { get; set; }
        public string RiskClass { get; set; }

    }
    
}
