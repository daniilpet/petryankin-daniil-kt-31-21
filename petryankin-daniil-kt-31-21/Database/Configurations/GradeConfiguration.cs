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
                   .HasColumnName("grade_id")
                   .HasComment("������������� ������")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(g => g.StudentId)
                   .HasColumnName("f_student_id")
                   .HasComment("��f���������� ��������")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(g => g.DisciplineId)
                   .HasColumnName("f_discipline_id")
                   .HasComment("������������� ����������")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(g => g.GradeDate)
                   .HasColumnName("d_grade")
                   .HasComment("���� ������")
                   .HasColumnType(ColumnType.Date)
                   .IsRequired();

            builder.Property(g => g.GradeValue)
                   .HasColumnName("n_grade_value")
                   .HasComment("�������� ������")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            // ���������
            builder.HasOne<Student>()
                   .WithMany()
                   .HasForeignKey(g => g.StudentId)
                   .HasConstraintName($"fk_{TableName}_student_id")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Discipline>()
                   .WithMany()
                   .HasForeignKey(g => g.DisciplineId)
                   .HasConstraintName($"fk_{TableName}_discipline_id")
                   .OnDelete(DeleteBehavior.Cascade);

            // "������" �������� ����������
            builder.Navigation(s => s.Discipline).AutoInclude();
        }
    }
}
