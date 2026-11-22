using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC2.Entities;

namespace MVC2.Configurations
{
    public class SessionConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.HasOne(S => S.Trainer)
                .WithMany(T => T.Sessions)
                .HasForeignKey(S => S.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(S => S.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(X =>
            {
                X.HasCheckConstraint("ck_CapacityConstraint","Capacity Between 1 AND 25");
                X.HasCheckConstraint("ck_EndDateConstraint", "EndDate > StartDate");
            });
        }
    }
}
