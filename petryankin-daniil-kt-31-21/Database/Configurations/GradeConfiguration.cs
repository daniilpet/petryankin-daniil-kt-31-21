using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using petryankin_daniil_kt_31_21.Database.Helpers;
using petryankin_daniil_kt_31_21.Models;

namespace petryankin_daniil_kt_31_21.Database.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        private const string TableName = "cd_grades";

        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable(TableName);

            builder.HasKey(g => g.GradeId)
                   .HasName($"pk_{TableName}_grade_id");

            builder.Property(g => g.GradeId)
                   .HasColumnName("c_grade_id")
                   .HasComment("Идентификатор оценки")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(g => g.StudentId)
                   .HasColumnName("c_student_id")
                   .HasComment("Идентификатор студента")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(g => g.DisciplineId)
                   .HasColumnName("c_discipline_id")
                   .HasComment("Идентификатор дисциплины")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(g => g.GradeDate)
                   .HasColumnName("c_grade_date")
                   .HasComment("Дата оценки")
                   .HasColumnType(ColumnType.Date)
                   .IsRequired();

            builder.Property(g => g.GradeValue)
                   .HasColumnName("c_grade_value")
                   .HasComment("Значение оценки")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();
        }
    }
}
