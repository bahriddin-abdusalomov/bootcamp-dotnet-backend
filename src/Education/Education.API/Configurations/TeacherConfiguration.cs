using Education.API.Models.Teachers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Education.API.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Speality)
                .HasMaxLength(30)
                .HasDefaultValue("Junior teacher")
                .IsRequired();

            builder.Property(x => x.Salary)
                .HasDefaultValue(1234567)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithOne(x => x.Teacher)
                .HasForeignKey<Teacher>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
