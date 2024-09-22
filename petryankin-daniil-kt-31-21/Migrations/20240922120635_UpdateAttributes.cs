using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace petryankin_daniil_kt_31_21.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "idx_cd_students_group_group_name",
                table: "cd_students_group");

            migrationBuilder.DropIndex(
                name: "idx_cd_students_last_first_name",
                table: "cd_students");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "cd_students",
                newName: "c_student_last_name");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "cd_students",
                newName: "c_student_first_name");

            migrationBuilder.RenameIndex(
                name: "idx_cd_students_group_id",
                table: "cd_students",
                newName: "idx_cd_students_fk_f_group_id");

            migrationBuilder.AlterColumn<string>(
                name: "group_name",
                table: "cd_students_group",
                type: "varchar(100)",
                nullable: false,
                comment: "Имя группы",
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<int>(
                name: "group_id",
                table: "cd_students_group",
                type: "int4",
                nullable: false,
                comment: "Идентификатор группы",
                oldClrType: typeof(int),
                oldType: "int4")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: true,
                comment: "Отчество студента",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "group_id",
                table: "cd_students",
                type: "int4",
                nullable: false,
                comment: "Группа студента",
                oldClrType: typeof(int),
                oldType: "int4");

            migrationBuilder.AlterColumn<int>(
                name: "student_id",
                table: "cd_students",
                type: "int4",
                nullable: false,
                comment: "Идентификатор записи студента",
                oldClrType: typeof(int),
                oldType: "int4")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "c_student_last_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: false,
                comment: "Фамилия студента",
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "c_student_first_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: false,
                comment: "Имя студента",
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "c_student_last_name",
                table: "cd_students",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "c_student_first_name",
                table: "cd_students",
                newName: "first_name");

            migrationBuilder.RenameIndex(
                name: "idx_cd_students_fk_f_group_id",
                table: "cd_students",
                newName: "idx_cd_students_group_id");

            migrationBuilder.AlterColumn<string>(
                name: "group_name",
                table: "cd_students_group",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldComment: "Имя группы");

            migrationBuilder.AlterColumn<int>(
                name: "group_id",
                table: "cd_students_group",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "Идентификатор группы")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true,
                oldComment: "Отчество студента");

            migrationBuilder.AlterColumn<int>(
                name: "group_id",
                table: "cd_students",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "Группа студента");

            migrationBuilder.AlterColumn<int>(
                name: "student_id",
                table: "cd_students",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "Идентификатор записи студента")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldComment: "Фамилия студента");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldComment: "Имя студента");

            migrationBuilder.CreateIndex(
                name: "idx_cd_students_group_group_name",
                table: "cd_students_group",
                column: "group_name");

            migrationBuilder.CreateIndex(
                name: "idx_cd_students_last_first_name",
                table: "cd_students",
                columns: new[] { "last_name", "first_name" });
        }
    }
}
