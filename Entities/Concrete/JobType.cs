using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class JobType:IEntity
    {
        public int Id { get; set; }
        public string JobTypes { get; set; }
        public string CompanyName{ get; set; }
        public string Title { get; set; }
        public string SSK { get; set; }
        public string ActivityField{ get; set; }
        public string CompanyAddress { get; set; }
        public DateTime JobDate { get; set; }
        public int SSKNo { get; set; }

    }
}
