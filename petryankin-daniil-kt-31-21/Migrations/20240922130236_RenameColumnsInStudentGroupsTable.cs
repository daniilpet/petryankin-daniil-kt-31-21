using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace petryankin_daniil_kt_31_21.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumnsInStudentGroupsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_students_cd_students_group_group_id",
                table: "cd_students");

            migrationBuilder.RenameColumn(
                name: "group_name",
                table: "cd_students_group",
                newName: "c_group_name");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "cd_students_group",
                newName: "c_group_id");

            migrationBuilder.RenameColumn(
                name: "middle_name",
                table: "cd_students",
                newName: "c_middle_name");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "cd_students",
                newName: "c_group_id");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "cd_students",
                newName: "c_student_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_students_cd_students_group_c_group_id",
                table: "cd_students",
                column: "c_group_id",
                principalTable: "cd_students_group",
                principalColumn: "c_group_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_students_cd_students_group_c_group_id",
                table: "cd_students");

            migrationBuilder.RenameColumn(
                name: "c_group_name",
                table: "cd_students_group",
                newName: "group_name");

            migrationBuilder.RenameColumn(
                name: "c_group_id",
                table: "cd_students_group",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "c_middle_name",
                table: "cd_students",
                newName: "middle_name");

            migrationBuilder.RenameColumn(
                name: "c_group_id",
                table: "cd_students",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "c_student_id",
                table: "cd_students",
                newName: "student_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_students_cd_students_group_group_id",
                table: "cd_students",
                column: "group_id",
                principalTable: "cd_students_group",
                principalColumn: "group_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
