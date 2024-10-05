using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace petryankin_daniil_kt_31_21.Migrations
{
    /// <inheritdoc />
    public partial class CorrectMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_students_cd_students_group_f_group_id",
                table: "cd_students");

            migrationBuilder.RenameColumn(
                name: "c_is_passed",
                table: "cd_passes",
                newName: "b_passed");

            migrationBuilder.AddColumn<int>(
                name: "GroupId1",
                table: "cd_students",
                type: "int4",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "b_deleted",
                table: "cd_students",
                type: "bool",
                nullable: false,
                defaultValue: false,
                comment: "Признак удаления");

            migrationBuilder.CreateIndex(
                name: "IX_cd_students_GroupId1",
                table: "cd_students",
                column: "GroupId1");

            migrationBuilder.CreateIndex(
                name: "IX_cd_passes_c_discipline_id",
                table: "cd_passes",
                column: "c_discipline_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_passes_c_student_id",
                table: "cd_passes",
                column: "c_student_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_grades_c_discipline_id",
                table: "cd_grades",
                column: "c_discipline_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_grades_c_student_id",
                table: "cd_grades",
                column: "c_student_id");

            migrationBuilder.AddForeignKey(
                name: "fk_cd_grades_discipline_id",
                table: "cd_grades",
                column: "c_discipline_id",
                principalTable: "cd_disciplines",
                principalColumn: "c_discipline_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cd_grades_student_id",
                table: "cd_grades",
                column: "c_student_id",
                principalTable: "cd_students",
                principalColumn: "c_student_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cd_passes_discipline_id",
                table: "cd_passes",
                column: "c_discipline_id",
                principalTable: "cd_disciplines",
                principalColumn: "c_discipline_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cd_passes_student_id",
                table: "cd_passes",
                column: "c_student_id",
                principalTable: "cd_students",
                principalColumn: "c_student_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_students_cd_students_group_GroupId1",
                table: "cd_students",
                column: "GroupId1",
                principalTable: "cd_students_group",
                principalColumn: "c_group_id");

            migrationBuilder.AddForeignKey(
                name: "fk_cd_students_group_id",
                table: "cd_students",
                column: "f_group_id",
                principalTable: "cd_students_group",
                principalColumn: "c_group_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cd_grades_discipline_id",
                table: "cd_grades");

            migrationBuilder.DropForeignKey(
                name: "fk_cd_grades_student_id",
                table: "cd_grades");

            migrationBuilder.DropForeignKey(
                name: "fk_cd_passes_discipline_id",
                table: "cd_passes");

            migrationBuilder.DropForeignKey(
                name: "fk_cd_passes_student_id",
                table: "cd_passes");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_students_cd_students_group_GroupId1",
                table: "cd_students");

            migrationBuilder.DropForeignKey(
                name: "fk_cd_students_group_id",
                table: "cd_students");

            migrationBuilder.DropIndex(
                name: "IX_cd_students_GroupId1",
                table: "cd_students");

            migrationBuilder.DropIndex(
                name: "IX_cd_passes_c_discipline_id",
                table: "cd_passes");

            migrationBuilder.DropIndex(
                name: "IX_cd_passes_c_student_id",
                table: "cd_passes");

            migrationBuilder.DropIndex(
                name: "IX_cd_grades_c_discipline_id",
                table: "cd_grades");

            migrationBuilder.DropIndex(
                name: "IX_cd_grades_c_student_id",
                table: "cd_grades");

            migrationBuilder.DropColumn(
                name: "GroupId1",
                table: "cd_students");

            migrationBuilder.DropColumn(
                name: "b_deleted",
                table: "cd_students");

            migrationBuilder.RenameColumn(
                name: "b_passed",
                table: "cd_passes",
                newName: "c_is_passed");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_students_cd_students_group_f_group_id",
                table: "cd_students",
                column: "f_group_id",
                principalTable: "cd_students_group",
                principalColumn: "c_group_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
