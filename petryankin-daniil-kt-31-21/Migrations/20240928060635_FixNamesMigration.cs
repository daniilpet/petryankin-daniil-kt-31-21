using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace petryankin_daniil_kt_31_21.Migrations
{
    /// <inheritdoc />
    public partial class FixNamesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "c_group_id",
                table: "cd_students_group",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "c_student_id",
                table: "cd_students",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "c_student_id",
                table: "cd_passes",
                newName: "f_student_id");

            migrationBuilder.RenameColumn(
                name: "c_pass_date",
                table: "cd_passes",
                newName: "d_pass");

            migrationBuilder.RenameColumn(
                name: "c_discipline_id",
                table: "cd_passes",
                newName: "f_discipline_id");

            migrationBuilder.RenameColumn(
                name: "c_pass_id",
                table: "cd_passes",
                newName: "pass_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_passes_c_student_id",
                table: "cd_passes",
                newName: "IX_cd_passes_f_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_passes_c_discipline_id",
                table: "cd_passes",
                newName: "IX_cd_passes_f_discipline_id");

            migrationBuilder.RenameColumn(
                name: "c_student_id",
                table: "cd_grades",
                newName: "f_student_id");

            migrationBuilder.RenameColumn(
                name: "c_grade_value",
                table: "cd_grades",
                newName: "n_grade_value");

            migrationBuilder.RenameColumn(
                name: "c_grade_date",
                table: "cd_grades",
                newName: "d_grade");

            migrationBuilder.RenameColumn(
                name: "c_discipline_id",
                table: "cd_grades",
                newName: "f_discipline_id");

            migrationBuilder.RenameColumn(
                name: "c_grade_id",
                table: "cd_grades",
                newName: "grade_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_grades_c_student_id",
                table: "cd_grades",
                newName: "IX_cd_grades_f_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_grades_c_discipline_id",
                table: "cd_grades",
                newName: "IX_cd_grades_f_discipline_id");

            migrationBuilder.RenameColumn(
                name: "c_discipline_id",
                table: "cd_disciplines",
                newName: "discipline_id");

            migrationBuilder.AlterColumn<string>(
                name: "c_group_name",
                table: "cd_students_group",
                type: "varchar",
                maxLength: 20,
                nullable: false,
                comment: "Имя группы",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldComment: "Имя группы");

            migrationBuilder.AlterColumn<string>(
                name: "c_student_middle_name",
                table: "cd_students",
                type: "varchar",
                maxLength: 50,
                nullable: true,
                comment: "Отчество студента",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true,
                oldComment: "Отчество студента");

            migrationBuilder.AlterColumn<string>(
                name: "c_student_last_name",
                table: "cd_students",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Фамилия студента",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldComment: "Фамилия студента");

            migrationBuilder.AlterColumn<string>(
                name: "c_student_first_name",
                table: "cd_students",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Имя студента",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldComment: "Имя студента");

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId1",
                table: "cd_passes",
                type: "int4",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "f_student_id",
                table: "cd_grades",
                type: "int4",
                nullable: false,
                comment: "Идfнтификатор студента",
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "Идентификатор студента");

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId1",
                table: "cd_grades",
                type: "int4",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "c_discipline_name",
                table: "cd_disciplines",
                type: "varchar",
                maxLength: 160,
                nullable: false,
                comment: "Название дисциплины",
                oldClrType: typeof(string),
                oldType: "varchar(160)",
                oldComment: "Название дисциплины");

            migrationBuilder.AlterColumn<string>(
                name: "c_discipline_code",
                table: "cd_disciplines",
                type: "varchar",
                maxLength: 20,
                nullable: false,
                comment: "Код дисциплины",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldComment: "Код дисциплины");

            migrationBuilder.CreateIndex(
                name: "IX_cd_passes_DisciplineId1",
                table: "cd_passes",
                column: "DisciplineId1");

            migrationBuilder.CreateIndex(
                name: "IX_cd_grades_DisciplineId1",
                table: "cd_grades",
                column: "DisciplineId1");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_grades_cd_disciplines_DisciplineId1",
                table: "cd_grades",
                column: "DisciplineId1",
                principalTable: "cd_disciplines",
                principalColumn: "discipline_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_passes_cd_disciplines_DisciplineId1",
                table: "cd_passes",
                column: "DisciplineId1",
                principalTable: "cd_disciplines",
                principalColumn: "discipline_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_grades_cd_disciplines_DisciplineId1",
                table: "cd_grades");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_passes_cd_disciplines_DisciplineId1",
                table: "cd_passes");

            migrationBuilder.DropIndex(
                name: "IX_cd_passes_DisciplineId1",
                table: "cd_passes");

            migrationBuilder.DropIndex(
                name: "IX_cd_grades_DisciplineId1",
                table: "cd_grades");

            migrationBuilder.DropColumn(
                name: "DisciplineId1",
                table: "cd_passes");

            migrationBuilder.DropColumn(
                name: "DisciplineId1",
                table: "cd_grades");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "cd_students_group",
                newName: "c_group_id");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "cd_students",
                newName: "c_student_id");

            migrationBuilder.RenameColumn(
                name: "f_student_id",
                table: "cd_passes",
                newName: "c_student_id");

            migrationBuilder.RenameColumn(
                name: "f_discipline_id",
                table: "cd_passes",
                newName: "c_discipline_id");

            migrationBuilder.RenameColumn(
                name: "d_pass",
                table: "cd_passes",
                newName: "c_pass_date");

            migrationBuilder.RenameColumn(
                name: "pass_id",
                table: "cd_passes",
                newName: "c_pass_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_passes_f_student_id",
                table: "cd_passes",
                newName: "IX_cd_passes_c_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_passes_f_discipline_id",
                table: "cd_passes",
                newName: "IX_cd_passes_c_discipline_id");

            migrationBuilder.RenameColumn(
                name: "n_grade_value",
                table: "cd_grades",
                newName: "c_grade_value");

            migrationBuilder.RenameColumn(
                name: "f_student_id",
                table: "cd_grades",
                newName: "c_student_id");

            migrationBuilder.RenameColumn(
                name: "f_discipline_id",
                table: "cd_grades",
                newName: "c_discipline_id");

            migrationBuilder.RenameColumn(
                name: "d_grade",
                table: "cd_grades",
                newName: "c_grade_date");

            migrationBuilder.RenameColumn(
                name: "grade_id",
                table: "cd_grades",
                newName: "c_grade_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_grades_f_student_id",
                table: "cd_grades",
                newName: "IX_cd_grades_c_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_grades_f_discipline_id",
                table: "cd_grades",
                newName: "IX_cd_grades_c_discipline_id");

            migrationBuilder.RenameColumn(
                name: "discipline_id",
                table: "cd_disciplines",
                newName: "c_discipline_id");

            migrationBuilder.AlterColumn<string>(
                name: "c_group_name",
                table: "cd_students_group",
                type: "varchar(100)",
                nullable: false,
                comment: "Имя группы",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 20,
                oldComment: "Имя группы");

            migrationBuilder.AlterColumn<string>(
                name: "c_student_middle_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: true,
                comment: "Отчество студента",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "Отчество студента");

            migrationBuilder.AlterColumn<string>(
                name: "c_student_last_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: false,
                comment: "Фамилия студента",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Фамилия студента");

            migrationBuilder.AlterColumn<string>(
                name: "c_student_first_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: false,
                comment: "Имя студента",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Имя студента");

            migrationBuilder.AlterColumn<int>(
                name: "c_student_id",
                table: "cd_grades",
                type: "int4",
                nullable: false,
                comment: "Идентификатор студента",
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "Идfнтификатор студента");

            migrationBuilder.AlterColumn<string>(
                name: "c_discipline_name",
                table: "cd_disciplines",
                type: "varchar(160)",
                nullable: false,
                comment: "Название дисциплины",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 160,
                oldComment: "Название дисциплины");

            migrationBuilder.AlterColumn<string>(
                name: "c_discipline_code",
                table: "cd_disciplines",
                type: "varchar(20)",
                nullable: false,
                comment: "Код дисциплины",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 20,
                oldComment: "Код дисциплины");
        }
    }
}
