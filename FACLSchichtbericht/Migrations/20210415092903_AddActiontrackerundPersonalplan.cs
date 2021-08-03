using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class AddActiontrackerundPersonalplan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Checker1",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "Checker2",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "Checker3",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "Checker4",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "Checker5",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "DGRChecker1",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "DGRChecker2",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "Frachtsicherung",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "LagerdatenChecker",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "QundS",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "SchichtleiterLCAG",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "Supervisor1",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "Supervisor2",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "VormannLCAG",
                table: "BerichtBD420");

            migrationBuilder.CreateTable(
                name: "Actiontracker",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Datum = table.Column<string>(nullable: true),
                    Von = table.Column<string>(nullable: true),
                    Bis = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Priorität = table.Column<string>(nullable: true),
                    Bereich = table.Column<string>(nullable: true),
                    Beschreibung = table.Column<string>(nullable: true),
                    Maßnahme = table.Column<string>(nullable: true),
                    erstelltam = table.Column<string>(nullable: true),
                    erstelltvon = table.Column<string>(nullable: true),
                    zuletztbearbeitetam = table.Column<string>(nullable: true),
                    zuletztbearbeitetvon = table.Column<string>(nullable: true),
                    BerichtBD420_ID = table.Column<int>(nullable: true),
                    BerichtBD451_ID = table.Column<int>(nullable: true),
                    BerichtBU320_ID = table.Column<int>(nullable: true),
                    BerichtBU420_ID = table.Column<int>(nullable: true),
                    Overview_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actiontracker", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Personalplan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PK = table.Column<string>(nullable: true),
                    Nachname = table.Column<string>(nullable: true),
                    Vorname = table.Column<string>(nullable: true),
                    Gewerk = table.Column<string>(nullable: true),
                    Jobtitel = table.Column<string>(nullable: true),
                    Einsatzals = table.Column<string>(nullable: true),
                    AG = table.Column<string>(nullable: true),
                    Brandschutzhelfer = table.Column<string>(nullable: true),
                    Ersthelfer = table.Column<string>(nullable: true),
                    anwesend = table.Column<string>(nullable: true),
                    mehrarbeitgenehmight = table.Column<string>(nullable: true),
                    Bemerkung = table.Column<string>(nullable: true),
                    erstelltam = table.Column<string>(nullable: true),
                    erstelltvon = table.Column<string>(nullable: true),
                    zuletztbearbeitetam = table.Column<string>(nullable: true),
                    zuletztbearbeitetvon = table.Column<string>(nullable: true),
                    BerichtBD420_ID = table.Column<int>(nullable: true),
                    BerichtBD451_ID = table.Column<int>(nullable: true),
                    BerichtBU320_ID = table.Column<int>(nullable: true),
                    BerichtBU420_ID = table.Column<int>(nullable: true),
                    datumgeplant = table.Column<string>(nullable: true),
                    schtichttyp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personalplan", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actiontracker");

            migrationBuilder.DropTable(
                name: "Personalplan");

            migrationBuilder.AddColumn<string>(
                name: "Checker1",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Checker2",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Checker3",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Checker4",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Checker5",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DGRChecker1",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DGRChecker2",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Frachtsicherung",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LagerdatenChecker",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QundS",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchichtleiterLCAG",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Supervisor1",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Supervisor2",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VormannLCAG",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
