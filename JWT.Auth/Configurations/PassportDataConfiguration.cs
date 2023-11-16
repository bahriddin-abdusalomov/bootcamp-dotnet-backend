using JWT.Auth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWT.Auth.Configurations;

public class PassportDataConfiguration : IEntityTypeConfiguration<PassportData>
{
    public void Configure(EntityTypeBuilder<PassportData> builder)
    {
        builder.HasKey(x => x.PassportDataId);

        builder.Property(x => x.FistName)
            .HasDefaultValue("First name")
            .HasMaxLength(50)
            .IsRequired(); 

        builder.Property(x => x.LastName)
            .HasDefaultValue("Last name")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(x => x.PassportNumber)
            .IsUnique();

        builder.HasOne(x => x.User)
            .WithOne(x => x.PassportData)
            .HasForeignKey<User>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
