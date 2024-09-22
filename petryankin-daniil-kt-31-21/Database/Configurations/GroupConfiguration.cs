using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using petryankin_daniil_kt_31_21.Database.Helpers;
using petryankin_daniil_kt_31_21.Models;

namespace petryankin_daniil_kt_31_21.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        private const string TableName = "cd_students_group";

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable(TableName);

            builder.Property(g => g.GroupId)
                   .HasColumnName("c_group_id")
                   .HasComment("Идентификатор группы")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(g => g.GroupName)
                   .HasColumnName("c_group_name")
                   .HasComment("Имя группы")
                   .HasColumnType($"{ColumnType.String}(100)")
                   .IsRequired();

            builder.HasKey(g => g.GroupId)
                   .HasName($"pk_{TableName}_group_id");
        }
    }
}
