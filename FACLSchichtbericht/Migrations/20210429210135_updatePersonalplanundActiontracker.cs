using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class updatePersonalplanundActiontracker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "istabgeschlossen",
                table: "Personalplan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "istabgeschlossen",
                table: "Actiontracker",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "istabgeschlossen",
                table: "Personalplan");

            migrationBuilder.DropColumn(
                name: "istabgeschlossen",
                table: "Actiontracker");
        }
    }
}
