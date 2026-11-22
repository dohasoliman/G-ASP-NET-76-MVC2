using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC2.Entities;

namespace MVC2.Configurations
{
    public class GymUserConfig<TUser> : IEntityTypeConfiguration<TUser> where TUser : GymUser
    {
        public void Configure(EntityTypeBuilder<TUser> builder)
        {
            builder.Property(G => G.Name).HasColumnType("varchar(50)");
            builder.Property(G => G.Email).HasColumnType("varchar(100)");
            builder.Property(G => G.Phone).HasColumnType("varchar(11)");

            builder.ComplexProperty(G => G.Address);

            builder.HasIndex(G => G.Email).IsUnique();
            builder.HasIndex(G => G.Phone).IsUnique();

            builder.ToTable(U =>
            {
                U.HasCheckConstraint("ck_EmailConstraint", "Email Like '_%@_%._%' ");
                U.HasCheckConstraint("ck_PhoneConstraint", "Phone Like '010%' OR Phone Like '011%' OR Phone Like '012%' OR Phone Like '015%'");
            });

        }
    }
}
