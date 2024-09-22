using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using petryankin_daniil_kt_31_21.Database.Helpers;
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

            builder.Property(s => s.StudentId)
                   .HasColumnName("student_id")
                   .HasComment("Идентификатор записи студента")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(s => s.FirstName)
                   .HasColumnName("c_student_first_name")
                   .HasComment("Имя студента")
                   .HasColumnType($"{ColumnType.String}(50)")
                   .IsRequired();

            builder.Property(s => s.LastName)
                   .HasColumnName("c_student_last_name")
                   .HasComment("Фамилия студента")
                   .HasColumnType($"{ColumnType.String}(50)")
                   .IsRequired();

            builder.Property(s => s.MiddleName)
                   .HasColumnName("middle_name")
                   .HasComment("Отчество студента")
                   .HasColumnType($"{ColumnType.String}(50)");

            builder.Property(s => s.GroupId)
                   .HasColumnName("group_id")
                   .HasComment("Группа студента")
                   .HasColumnType(ColumnType.Int);

            // Индексы
            builder.ToTable(TableName)
                    .HasIndex(s => s.GroupId)
                    .HasDatabaseName($"idx_{TableName}_fk_f_group_id");
        }
    }
}
