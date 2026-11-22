using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC2.Entities;

namespace MVC2.Configurations
{
    public class MemberConfig :GymUserConfig<Member> ,IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasMany(M => M.Plans)
                .WithOne(MS => MS.Members)
                .HasForeignKey(MS => MS.MembersId);

            builder.Property(M => M.CreatedAt).HasColumnName("JoinDate").HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
        }
    }
}
