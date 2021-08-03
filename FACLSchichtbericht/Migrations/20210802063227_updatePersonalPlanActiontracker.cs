using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class updatePersonalPlanActiontracker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ULDKGMenge",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "ULDKGProdu",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "ULDKGStunden",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "ULDMengeMenge",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "ULDMengeProdu",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "ULDMengeStunden",
                table: "BerichtBCLPosition");

            migrationBuilder.AddColumn<int>(
                name: "BerichtBD437_ID",
                table: "Personalplan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BerichtBU437_ID",
                table: "Personalplan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BerichtTransport_ID",
                table: "Personalplan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BCLPersonalIst",
                table: "BerichtBU420",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BclULDKGMAStunden",
                table: "BerichtBU420",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BclULDKGMenge",
                table: "BerichtBU420",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BclULDKGProdu",
                table: "BerichtBU420",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BclULDMengeMAStunden",
                table: "BerichtBU420",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BclULDMengeMenge",
                table: "BerichtBU420",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BclULDMengeProdu",
                table: "BerichtBU420",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bd437ULDKGMenge",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Bd437ULDKGProdu",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Bd437ULDKGStunden",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bd437ULDMengeMenge",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Bd437ULDMengeProdu",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Bd437ULDMengeStunden",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bu437ULDKGMenge",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Bu437ULDKGProdu",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Bu437ULDKGStunden",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bu437ULDMengeMenge",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Bu437ULDMengeProdu",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Bu437ULDMengeStunden",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BerichtBD437_ID",
                table: "Actiontracker",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BerichtBU437_ID",
                table: "Actiontracker",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BerichtTransport_ID",
                table: "Actiontracker",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BerichtBD437_ID",
                table: "Personalplan");

            migrationBuilder.DropColumn(
                name: "BerichtBU437_ID",
                table: "Personalplan");

            migrationBuilder.DropColumn(
                name: "BerichtTransport_ID",
                table: "Personalplan");

            migrationBuilder.DropColumn(
                name: "BCLPersonalIst",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "BclULDKGMAStunden",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "BclULDKGMenge",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "BclULDKGProdu",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "BclULDMengeMAStunden",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "BclULDMengeMenge",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "BclULDMengeProdu",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "Bd437ULDKGMenge",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bd437ULDKGProdu",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bd437ULDKGStunden",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bd437ULDMengeMenge",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bd437ULDMengeProdu",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bd437ULDMengeStunden",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bu437ULDKGMenge",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bu437ULDKGProdu",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bu437ULDKGStunden",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bu437ULDMengeMenge",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bu437ULDMengeProdu",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Bu437ULDMengeStunden",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "BerichtBD437_ID",
                table: "Actiontracker");

            migrationBuilder.DropColumn(
                name: "BerichtBU437_ID",
                table: "Actiontracker");

            migrationBuilder.DropColumn(
                name: "BerichtTransport_ID",
                table: "Actiontracker");

            migrationBuilder.AddColumn<int>(
                name: "ULDKGMenge",
                table: "BerichtBCLPosition",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDKGProdu",
                table: "BerichtBCLPosition",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDKGStunden",
                table: "BerichtBCLPosition",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDMengeMenge",
                table: "BerichtBCLPosition",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeProdu",
                table: "BerichtBCLPosition",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeStunden",
                table: "BerichtBCLPosition",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
