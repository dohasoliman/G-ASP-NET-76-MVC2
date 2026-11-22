using MVC2.Entities.Enums;

namespace MVC2.Entities
{
    public class Member : GymUser
    {
        //Join date
        public string Photo { get; set; }
        public ICollection<Membership> Plans { get; set; }

    }
}
