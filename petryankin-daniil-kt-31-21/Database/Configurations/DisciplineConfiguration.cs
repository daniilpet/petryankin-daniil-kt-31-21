using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using petryankin_daniil_kt_31_21.Database.Helpers;
using petryankin_daniil_kt_31_21.Models;

namespace petryankin_daniil_kt_31_21.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        private const string TableName = "cd_disciplines";

        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.ToTable(TableName);

            builder.HasKey(d => d.DisciplineId)
                  .HasName($"pk_{TableName}_discipline_id");

            builder.Property(d => d.DisciplineId)
                   .HasColumnName("discipline_id")
                   .HasComment("Идентификатор дисциплины")
                   .HasColumnType(ColumnType.Int)
                   .IsRequired();

            builder.Property(d => d.DisciplineName)
                   .HasColumnName("c_discipline_name")
                   .HasComment("Название дисциплины")
                   .HasColumnType(ColumnType.String)
                   .HasMaxLength(160)
                   .IsRequired();

            builder.Property(d => d.DisciplineCode)
                   .HasColumnName("c_discipline_code")
                   .HasComment("Код дисциплины")
                   .HasColumnType(ColumnType.String)
                   .HasMaxLength(20)
                   .IsRequired();
        }
    }
}
