using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC2.Entities;

namespace MVC2.Configurations
{
    public class PlanConfig : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.HasMany(P => P.Members)
                .WithOne(MS => MS.Plans)
                .HasForeignKey(MS => MS.PlansId);

            builder.Property(P => P.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(X => {
                X.HasCheckConstraint("ck_DurationDaysConstraint", "DurationDays Between 1 AND 365 ");
            });
        }
    }
}
