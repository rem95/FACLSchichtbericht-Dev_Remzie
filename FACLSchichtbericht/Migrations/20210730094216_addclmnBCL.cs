using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class addclmnBCL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Arbeitsunfall",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Awaiting",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BD437Ist",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BD437Soll",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BDStart",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BU437Ist",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BU437Soll",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSDGR",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSStandard",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hal",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Leihscanner",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Leihstapler",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pending",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RFSactual",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RFScoming",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDKGMenge",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDKGProdu",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDKGStunden",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDMengeMenge",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeProdu",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeStunden",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "abgeschlossenvon",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "freigegebenvon",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "istfreigegeben",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zuletztbearbeitetam",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zuletztbearbeitetvon",
                table: "BerichtBCLPosition",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arbeitsunfall",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Awaiting",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "BD437Ist",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "BD437Soll",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "BDStart",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "BU437Ist",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "BU437Soll",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "CDSDGR",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "CDSStandard",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Hal",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Leihscanner",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Leihstapler",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Pending",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "RFSactual",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "RFScoming",
                table: "BerichtBCLPosition");

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

            migrationBuilder.DropColumn(
                name: "abgeschlossenvon",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "freigegebenvon",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "istfreigegeben",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "zuletztbearbeitetam",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "zuletztbearbeitetvon",
                table: "BerichtBCLPosition");
        }
    }
}
