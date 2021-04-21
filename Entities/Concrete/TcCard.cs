using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TcCard:IEntity
    {
        public int Id { get; set; }
        public int IdentityId { get; set; }
        public string IdentityNo { get; set; }
        public string SerialNo { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

    }
}
