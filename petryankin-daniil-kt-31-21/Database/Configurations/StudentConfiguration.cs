using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using petryankin_daniil_kt_31_21.Models;

namespace petryankin_daniil_kt_31_21.Database.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        private const string TableName = "cd_students";

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable(TableName);

            builder.HasKey(s => s.StudentId)
                    .HasName($"pk_{TableName}_student_id");

            // Свойства
            builder.Property(s => s.FirstName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(s => s.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(s => s.MiddleName)
                   .HasMaxLength(50);

            // Связь с группой
            builder.HasOne(s => s.Group)
                   .WithMany(g => g.Students)
                   .HasForeignKey(s => s.GroupId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}