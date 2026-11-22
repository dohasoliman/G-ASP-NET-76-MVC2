using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC2.Entities;

namespace MVC2.Configurations
{
    public class TrainerConfig : GymUserConfig<Trainer>,  IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            base.Configure(builder);
            builder.Property(T => T.CreatedAt).HasColumnName("HireDate").HasDefaultValueSql("GETDATE()");

        }
    }
}
