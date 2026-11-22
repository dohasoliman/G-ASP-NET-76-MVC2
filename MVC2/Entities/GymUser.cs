using MVC2.Entities.Enums;

namespace MVC2.Entities
{
    public class GymUser : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
