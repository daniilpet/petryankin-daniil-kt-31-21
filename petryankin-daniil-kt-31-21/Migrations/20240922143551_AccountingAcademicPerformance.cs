using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace petryankin_daniil_kt_31_21.Migrations
{
    /// <inheritdoc />
    public partial class AccountingAcademicPerformance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cd_disciplines",
                columns: table => new
                {
                    c_discipline_id = table.Column<int>(type: "int4", nullable: false, comment: "Идентификатор дисциплины")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_discipline_name = table.Column<string>(type: "varchar(160)", nullable: false, comment: "Название дисциплины"),
                    c_discipline_code = table.Column<string>(type: "varchar(20)", nullable: false, comment: "Код дисциплины")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_disciplines_discipline_id", x => x.c_discipline_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_grades",
                columns: table => new
                {
                    c_grade_id = table.Column<int>(type: "int4", nullable: false, comment: "Идентификатор оценки")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_student_id = table.Column<int>(type: "int4", nullable: false, comment: "Идентификатор студента"),
                    c_discipline_id = table.Column<int>(type: "int4", nullable: false, comment: "Идентификатор дисциплины"),
                    c_grade_date = table.Column<DateTime>(type: "timestamp", nullable: false, comment: "Дата оценки"),
                    c_grade_value = table.Column<int>(type: "int4", nullable: false, comment: "Значение оценки")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_grades_grade_id", x => x.c_grade_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_passes",
                columns: table => new
                {
                    c_pass_id = table.Column<int>(type: "int4", nullable: false, comment: "Идентификатор зачета")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_student_id = table.Column<int>(type: "int4", nullable: false, comment: "Идентификатор студента"),
                    c_discipline_id = table.Column<int>(type: "int4", nullable: false, comment: "Идентификатор дисциплины"),
                    c_pass_date = table.Column<DateTime>(type: "timestamp", nullable: false, comment: "Дата зачета"),
                    c_is_passed = table.Column<bool>(type: "bool", nullable: false, comment: "Результат зачета")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_passes_pass_id", x => x.c_pass_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cd_disciplines");

            migrationBuilder.DropTable(
                name: "cd_grades");

            migrationBuilder.DropTable(
                name: "cd_passes");
        }
    }
}
