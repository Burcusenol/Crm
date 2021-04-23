using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOS
{
    public class HeadingDetailDto:IDto
    {
       
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
        public string BirthPlace { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Place { get; set; }
        public string Nationality { get; set; }
        public int NationalityStatus { get; set; }
    }
}
