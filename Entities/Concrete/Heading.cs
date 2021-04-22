using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Heading:Identity,IEntity
    {
        public int HeadingId { get; set; }
        public int IdentityId { get; set; }
        public int ContactId { get; set; }
        public string Department { get; set; }
        public string Identification { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime FirstDate { get; set; }
        public string KVK { get; set; }
        public string ContactLanguage { get; set; }


    }
}
