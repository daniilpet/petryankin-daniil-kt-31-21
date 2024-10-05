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
                   .HasComment("������������� ������ ��������")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(s => s.FirstName)
                   .HasColumnName("c_student_first_name")
                   .HasComment("��� ��������")
                   .HasColumnType(ColumnType.String)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(s => s.LastName)
                   .HasColumnName("c_student_last_name")
                   .HasComment("������� ��������")
                   .HasColumnType(ColumnType.String)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(s => s.MiddleName)
                   .HasColumnName("c_student_middle_name")
                   .HasComment("�������� ��������")
                   .HasColumnType(ColumnType.String)
                   .HasMaxLength(50);

            builder.Property(s => s.IsDeleted)
                   .HasColumnName("b_deleted")
                   .HasComment("������� ��������")
                   .HasColumnType(ColumnType.Bool);

            builder.Property(s => s.GroupId)
                   .HasColumnName("f_group_id")
                   .HasComment("������ ��������")
                   .HasColumnType(ColumnType.Int);

            // ���������
            builder.HasOne<Group>(x=>x.Group)
                   .WithMany()
                   .HasForeignKey(s => s.GroupId)
                   .HasConstraintName($"fk_{TableName}_group_id")
                   .OnDelete(DeleteBehavior.Restrict);

            // �������
            builder.ToTable(TableName)
                    .HasIndex(s => s.GroupId)
                    .HasDatabaseName($"idx_{TableName}_fk_f_group_id");
            
            // "������" ��������
            builder.Navigation(s => s.Group).AutoInclude();
        }
    }
}
