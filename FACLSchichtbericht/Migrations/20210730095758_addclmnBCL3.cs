using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class addclmnBCL3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BCLBL",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCLSV420",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCLSV437",
                table: "BerichtBCLPosition",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BCLBL",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "BCLSV420",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "BCLSV437",
                table: "BerichtBCLPosition");
        }
    }
}
