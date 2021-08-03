using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class updatePersonalschichttyp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "schtichttyp",
                table: "Personalplan");

            migrationBuilder.AddColumn<string>(
                name: "schichttyp",
                table: "Personalplan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "schichttyp",
                table: "Personalplan");

            migrationBuilder.AddColumn<string>(
                name: "schtichttyp",
                table: "Personalplan",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
