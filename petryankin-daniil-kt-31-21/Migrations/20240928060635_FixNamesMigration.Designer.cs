﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using petryankin_daniil_kt_31_21;

#nullable disable

namespace petryankin_daniil_kt_31_21.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20240928060635_FixNamesMigration")]
    partial class FixNamesMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("petryankin_daniil_kt_31_21.Models.Discipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int4")
                        .HasColumnName("discipline_id")
                        .HasComment("Идентификатор дисциплины");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DisciplineId"));

                    b.Property<string>("DisciplineCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("c_discipline_code")
                        .HasComment("Код дисциплины");

                    b.Property<string>("DisciplineName")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("varchar")
                        .HasColumnName("c_discipline_name")
                        .HasComment("Название дисциплины");

                    b.HasKey("DisciplineId")
                        .HasName("pk_cd_disciplines_discipline_id");

                    b.ToTable("cd_disciplines", (string)null);
                });

            modelBuilder.Entity("petryankin_daniil_kt_31_21.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int4")
                        .HasColumnName("grade_id")
                        .HasComment("Идентификатор оценки");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GradeId"));

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int4")
                        .HasColumnName("f_discipline_id")
                        .HasComment("Идентификатор дисциплины");

                    b.Property<int>("DisciplineId1")
                        .HasColumnType("int4");

                    b.Property<DateTime>("GradeDate")
                        .HasColumnType("timestamp")
                        .HasColumnName("d_grade")
                        .HasComment("Дата оценки");

                    b.Property<int>("GradeValue")
                        .HasColumnType("int4")
                        .HasColumnName("n_grade_value")
                        .HasComment("Значение оценки");

                    b.Property<int>("StudentId")
                        .HasColumnType("int4")
                        .HasColumnName("f_student_id")
                        .HasComment("Идfнтификатор студента");

                    b.HasKey("GradeId")
                        .HasName("pk_cd_grades_grade_id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("DisciplineId1");

                    b.HasIndex("StudentId");

                    b.ToTable("cd_grades", (string)null);
                });

            modelBuilder.Entity("petryankin_daniil_kt_31_21.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int4")
                        .HasColumnName("group_id")
                        .HasComment("Идентификатор группы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GroupId"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("c_group_name")
                        .HasComment("Имя группы");

                    b.HasKey("GroupId")
                        .HasName("pk_cd_students_group_group_id");

                    b.ToTable("cd_students_group", (string)null);
                });

            modelBuilder.Entity("petryankin_daniil_kt_31_21.Models.Pass", b =>
                {
                    b.Property<int>("PassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int4")
                        .HasColumnName("pass_id")
                        .HasComment("Идентификатор зачета");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PassId"));

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int4")
                        .HasColumnName("f_discipline_id")
                        .HasComment("Идентификатор дисциплины");

                    b.Property<int>("DisciplineId1")
                        .HasColumnType("int4");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("bool")
                        .HasColumnName("b_passed")
                        .HasComment("Результат зачета");

                    b.Property<DateTime>("PassDate")
                        .HasColumnType("timestamp")
                        .HasColumnName("d_pass")
                        .HasComment("Дата зачета");

                    b.Property<int>("StudentId")
                        .HasColumnType("int4")
                        .HasColumnName("f_student_id")
                        .HasComment("Идентификатор студента");

                    b.HasKey("PassId")
                        .HasName("pk_cd_passes_pass_id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("DisciplineId1");

                    b.HasIndex("StudentId");

                    b.ToTable("cd_passes", (string)null);
                });

            modelBuilder.Entity("petryankin_daniil_kt_31_21.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int4")
                        .HasColumnName("student_id")
                        .HasComment("Идентификатор записи студента");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_first_name")
                        .HasComment("Имя студента");

                    b.Property<int>("GroupId")
                        .HasColumnType("int4")
                        .HasColumnName("f_group_id")
                        .HasComment("Группа студента");

                    b.Property<int?>("GroupId1")
                        .HasColumnType("int4");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bool")
                        .HasColumnName("b_deleted")
                        .HasComment("Признак удаления");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_last_name")
                        .HasComment("Фамилия студента");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_middle_name")
                        .HasComment("Отчество студента");

                    b.HasKey("StudentId")
                        .HasName("pk_cd_students_student_id");

                    b.HasIndex("GroupId")
                        .HasDatabaseName("idx_cd_students_fk_f_group_id");

                    b.HasIndex("GroupId1");

                    b.ToTable("cd_students", (string)null);
                });

            modelBuilder.Entity("petryankin_daniil_kt_31_21.Models.Grade", b =>
                {
                    b.HasOne("petryankin_daniil_kt_31_21.Models.Discipline", null)
                        .WithMany()
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cd_grades_discipline_id");

                    b.HasOne("petryankin_daniil_kt_31_21.Models.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("petryankin_daniil_kt_31_21.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cd_grades_student_id");

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("petryankin_daniil_kt_31_21.Models.Pass", b =>
                {
                    b.HasOne("petryankin_daniil_kt_31_21.Models.Discipline", null)
                        .WithMany()
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cd_passes_discipline_id");

                    b.HasOne("petryankin_daniil_kt_31_21.Models.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("petryankin_daniil_kt_31_21.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cd_passes_student_id");

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("petryankin_daniil_kt_31_21.Models.Student", b =>
                {
                    b.HasOne("petryankin_daniil_kt_31_21.Models.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_cd_students_group_id");

                    b.HasOne("petryankin_daniil_kt_31_21.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId1");

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
