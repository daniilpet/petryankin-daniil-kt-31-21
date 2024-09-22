using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using petryankin_daniil_kt_31_21.Database.Helpers;
using petryankin_daniil_kt_31_21.Models;

namespace petryankin_daniil_kt_31_21.Database.Configurations
{
    public class PassConfiguration : IEntityTypeConfiguration<Pass>
    {
        private const string TableName = "cd_passes";

        public void Configure(EntityTypeBuilder<Pass> builder)
        {
            builder.ToTable(TableName);

            builder.HasKey(p => p.PassId)
                   .HasName($"pk_{TableName}_pass_id");

            builder.Property(p => p.PassId)
                   .HasColumnName("c_pass_id")
                   .HasComment("Идентификатор зачета")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(p => p.StudentId)
                   .HasColumnName("c_student_id")
                   .HasComment("Идентификатор студента")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(p => p.DisciplineId)
                   .HasColumnName("c_discipline_id")
                   .HasComment("Идентификатор дисциплины")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(p => p.PassDate)
                   .HasColumnName("c_pass_date")
                   .HasComment("Дата зачета")
                   .HasColumnType(ColumnType.Date)
                   .IsRequired();

            builder.Property(p => p.IsPassed)
                   .HasColumnName("c_is_passed")
                   .HasComment("Результат зачета")
                   .HasColumnType(ColumnType.Bool)
                   .IsRequired();
        }
    }
}
