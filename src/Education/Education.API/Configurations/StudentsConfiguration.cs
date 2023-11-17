using Education.API.Models.Students;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Education.API.Configurations
{
    public class StudentsConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Course)
                .HasMaxLength(5)
                .HasDefaultValue("1")
                .IsRequired();

            builder.Property(x => x.Group)
                .HasMaxLength(10)
                .HasDefaultValue("211-21")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithOne(x => x.Student)
                .HasForeignKey<Student>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
