using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApp.Migrations
{
    public partial class GroupsTableChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "StudentLimit",
                table: "Groups",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LimitPoint",
                table: "Groups",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LimitPoint",
                table: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "StudentLimit",
                table: "Groups",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte));
        }
    }
}
