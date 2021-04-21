using Core.Entities;

namespace Entities.Concrete
{
    public class Home:IEntity
    {
        public int Id { get; set; }
        public int HomePersonCount { get; set; }
        public int KidCount { get; set; }
        public int PersonCount { get; set; }
        public int Year { get; set; }
        public int HomeKidCount { get; set; }
        public int HomeStatus { get; set; }

    }
}