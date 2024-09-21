// Database/Configurations/GroupConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using petryankin_daniil_kt_31_21.Models;

namespace petryankin_daniil_kt_31_21.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        private const string TableName = "cd_group";

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable(TableName); 

            // ������� � ����
            builder.HasKey(g => g.GroupId);

            // ��������
            builder.Property(g => g.GroupName)
                   .IsRequired()
                   .HasMaxLength(100);

            // ����� �� ����������
            builder.HasMany(g => g.Students)
                   .WithOne(s => s.Group)
                   .HasForeignKey(s => s.GroupId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
