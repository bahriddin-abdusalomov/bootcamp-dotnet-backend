using JWT.Auth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWT.Auth.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserId);

            
            builder.Property(x => x.UserName)
                .HasMaxLength(30)
                .HasDefaultValue("Bahriddin_")
                .IsRequired();

            builder.Property(x => x.Password)
                .HasMaxLength (30)
                .HasDefaultValue("bahriddin2003")
                .IsRequired();

            builder.Property(x => x.Role)
                .IsRequired();

            builder.HasOne(x => x.PassportData)
                .WithOne(x => x.User)
                .HasForeignKey<PassportData>(x => x.PassportDataId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Cars)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.CarId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
