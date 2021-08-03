using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class ADDclmDatetoOverview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Schichtdatum",
                table: "Overview",
                newName: "schichtdatum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "schichtdatum",
                table: "Overview",
                newName: "Schichtdatum");
        }
    }
}
