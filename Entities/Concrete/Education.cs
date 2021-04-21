using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Education:IEntity
    {
        public int Id { get; set; }
        public string EducationStatus { get; set; }
        public DateTime GraduationDate { get; set; }
        public string MilitaryStatus { get; set; }
        public string LastSchool { get; set; }
        public string Language { get; set; }

    }
}
