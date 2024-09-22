using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace petryankin_daniil_kt_31_21.Migrations
{
    /// <inheritdoc />
    public partial class CorrectConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_students_cd_students_group_GroupId",
                table: "cd_students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cd_students_group",
                table: "cd_students_group");

            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "cd_students_group",
                newName: "group_name");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "cd_students_group",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "cd_students",
                newName: "middle_name");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "cd_students",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "cd_students",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "cd_students",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "cd_students",
                newName: "student_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_students_GroupId",
                table: "cd_students",
                newName: "idx_cd_students_group_id");

            migrationBuilder.AlterColumn<string>(
                name: "group_name",
                table: "cd_students_group",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "group_id",
                table: "cd_students_group",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "group_id",
                table: "cd_students",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "cd_students",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "student_id",
                table: "cd_students",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "pk_cd_students_group_group_id",
                table: "cd_students_group",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "idx_cd_students_group_group_name",
                table: "cd_students_group",
                column: "group_name");

            migrationBuilder.CreateIndex(
                name: "idx_cd_students_last_first_name",
                table: "cd_students",
                columns: new[] { "last_name", "first_name" });

            migrationBuilder.AddForeignKey(
                name: "FK_cd_students_cd_students_group_group_id",
                table: "cd_students",
                column: "group_id",
                principalTable: "cd_students_group",
                principalColumn: "group_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_students_cd_students_group_group_id",
                table: "cd_students");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cd_students_group_group_id",
                table: "cd_students_group");

            migrationBuilder.DropIndex(
                name: "idx_cd_students_group_group_name",
                table: "cd_students_group");

            migrationBuilder.DropIndex(
                name: "idx_cd_students_last_first_name",
                table: "cd_students");

            migrationBuilder.RenameColumn(
                name: "group_name",
                table: "cd_students_group",
                newName: "GroupName");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "cd_students_group",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "middle_name",
                table: "cd_students",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "cd_students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "cd_students",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "cd_students",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "cd_students",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "idx_cd_students_group_id",
                table: "cd_students",
                newName: "IX_cd_students_GroupId");

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "cd_students_group",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "cd_students_group",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "cd_students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "cd_students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "cd_students",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "cd_students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "cd_students",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
    }
}
