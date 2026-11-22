using MVC2.Entities.Enums;

namespace MVC2.Entities
{
    public class Trainer : GymUser
    {
        //HireDate
        public Speciality Speciality { get; set; }

        public ICollection<Session> Sessions { get; set; }

    }
}
