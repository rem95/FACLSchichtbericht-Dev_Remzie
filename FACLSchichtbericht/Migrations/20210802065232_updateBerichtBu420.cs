using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class updateBerichtBu420 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BCLPersonalSoll",
                table: "BerichtBU420",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BCLPersonalSoll",
                table: "BerichtBU420");
        }
    }
}
