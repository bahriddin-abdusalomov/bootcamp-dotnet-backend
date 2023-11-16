using JWT.Auth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWT.Auth.Configurations;

public class CarsConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(x => x.CarId);

        builder.Property(x => x.Name)
            .HasMaxLength(20)
            .HasDefaultValue("Car")
            .IsRequired();

        builder.HasOne(x => x.User)
            .WithMany(x => x.Cars)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
