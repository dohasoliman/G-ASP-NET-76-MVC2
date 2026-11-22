using System.ComponentModel.DataAnnotations.Schema;

namespace MVC2.Entities
{
    public class Membership : BaseEntity<int>
    {
        public int MembersId { get; set; }
        public Member Members { get; set; }
        public int PlansId { get; set; }
        public Plan Plans { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string Status =>
        EndDate > DateTime.Now ? "Active" : "Expired";

    }
}
