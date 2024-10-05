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
                   .HasColumnName("pass_id")
                   .HasComment("������������� ������")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(p => p.StudentId)
                   .HasColumnName("f_student_id")
                   .HasComment("������������� ��������")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(p => p.DisciplineId)
                   .HasColumnName("f_discipline_id")
                   .HasComment("������������� ����������")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(p => p.PassDate)
                   .HasColumnName("d_pass")
                   .HasComment("���� ������")
                   .HasColumnType(ColumnType.Date)
                   .IsRequired();

            builder.Property(p => p.IsPassed)
                   .HasColumnName("b_passed")
                   .HasComment("��������� ������")
                   .HasColumnType(ColumnType.Bool)
                   .IsRequired();

            // ���������
            builder.HasOne<Student>()
                .WithMany()
                .HasForeignKey(p => p.StudentId)
                .HasConstraintName($"fk_{TableName}_student_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Discipline>()
                .WithMany()
                .HasForeignKey(p => p.DisciplineId)
                .HasConstraintName($"fk_{TableName}_discipline_id")
                .OnDelete(DeleteBehavior.Cascade);

            // "������" �������� ����������
            builder.Navigation(s => s.Discipline).AutoInclude();
        }
    }
}
