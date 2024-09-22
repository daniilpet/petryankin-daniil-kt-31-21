using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace petryankin_daniil_kt_31_21.Migrations
{
    /// <inheritdoc />
    public partial class rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_students_cd_group_GroupId",
                table: "cd_students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cd_group",
                table: "cd_group");

            migrationBuilder.RenameTable(
                name: "cd_group",
                newName: "cd_students_group");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cd_students_group",
                table: "cd_students_group",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_students_cd_students_group_GroupId",
                table: "cd_students",
                column: "GroupId",
                principalTable: "cd_students_group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_students_cd_students_group_GroupId",
                table: "cd_students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cd_students_group",
                table: "cd_students_group");

            migrationBuilder.RenameTable(
                name: "cd_students_group",
                newName: "cd_group");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cd_group",
                table: "cd_group",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_students_cd_group_GroupId",
                table: "cd_students",
                column: "GroupId",
                principalTable: "cd_group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
