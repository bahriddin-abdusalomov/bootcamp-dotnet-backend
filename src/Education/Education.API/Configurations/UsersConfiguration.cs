using Education.API.Models.Teachers;
using Education.API.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Education.API.Configurations;

public class UsersConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .HasMaxLength(50)
            .HasDefaultValue("first name")
            .IsRequired();

        builder.Property(x => x.LastName)
            .HasMaxLength (50)
            .HasDefaultValue("last name")
            .IsRequired();

        builder.HasIndex(x => x.Email)
            .IsUnique();

        builder.Property(x => x.Password)
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.PhoneNumber)
            .HasMaxLength(13)
            .HasDefaultValue("+998991234567")
            .IsRequired();

    }
}
