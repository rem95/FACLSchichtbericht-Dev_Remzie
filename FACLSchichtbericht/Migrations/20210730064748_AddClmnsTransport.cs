using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class AddClmnsTransport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Arbeitsunfall",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSDgr",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSStandard",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DIRIst",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DIRKrank",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DIRSoll",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DIRZusatzleistung",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HRLIst",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HRLKrank",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HRLSoll",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HRLZusatzleistung",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Leihscanner",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Leihstapler",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerkoIst",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerkoKrank",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerkoSoll",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerkoZusatzleistung",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuerIst",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuerKrank",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuerSoll",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuerZusatzleistung",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BerichtBCLPosition",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BerichtBD437_ID = table.Column<int>(nullable: false),
                    BerichtBU437_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerichtBCLPosition", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "Arbeitsunfall",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "CDSDgr",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "CDSStandard",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "DIRIst",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "DIRKrank",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "DIRSoll",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "DIRZusatzleistung",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "HRLIst",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "HRLKrank",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "HRLSoll",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "HRLZusatzleistung",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "Leihscanner",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "Leihstapler",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "PerkoIst",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "PerkoKrank",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "PerkoSoll",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "PerkoZusatzleistung",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "QuerIst",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "QuerKrank",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "QuerSoll",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "QuerZusatzleistung",
                table: "BerichtTransport");
        }
    }
}
