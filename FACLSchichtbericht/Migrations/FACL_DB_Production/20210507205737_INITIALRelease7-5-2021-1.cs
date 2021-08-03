using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations.FACL_DB_Production
{
    public partial class INITIALRelease7520211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actiontracker",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
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
                    istabgeschlossen = table.Column<string>(nullable: true),
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
                name: "BerichtBD420",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leihscanner = table.Column<int>(nullable: true),
                    Leihstapler = table.Column<int>(nullable: true),
                    CDSStandard = table.Column<int>(nullable: true),
                    CDSDGR = table.Column<int>(nullable: true),
                    Arbeitunsfall = table.Column<string>(nullable: true),
                    SupervisorSoll = table.Column<int>(nullable: true),
                    SupervisorIst = table.Column<int>(nullable: true),
                    SupervisorKrank = table.Column<int>(nullable: true),
                    SupervisorZusatz = table.Column<int>(nullable: true),
                    CheckerSoll = table.Column<int>(nullable: true),
                    CheckerIst = table.Column<int>(nullable: true),
                    CheckerKrank = table.Column<int>(nullable: true),
                    CheckerZusatz = table.Column<int>(nullable: true),
                    AufbauerSoll = table.Column<int>(nullable: true),
                    AufbauerIst = table.Column<int>(nullable: true),
                    AufbauerKrank = table.Column<int>(nullable: true),
                    AufbauerZusatz = table.Column<int>(nullable: true),
                    AbfertigerIst = table.Column<int>(nullable: true),
                    AbfertigerSoll = table.Column<int>(nullable: true),
                    AbfertigerKrank = table.Column<int>(nullable: true),
                    AbfertigerZusatz = table.Column<int>(nullable: true),
                    AwaitingLCC = table.Column<int>(nullable: true),
                    AwaitingLCCFast = table.Column<int>(nullable: true),
                    AwaitingBulk = table.Column<int>(nullable: true),
                    AwaitingBulkFast = table.Column<int>(nullable: true),
                    Pending = table.Column<int>(nullable: true),
                    PendingLCCFast = table.Column<int>(nullable: true),
                    PendingBulk = table.Column<int>(nullable: true),
                    PendingBulkFast = table.Column<int>(nullable: true),
                    HalLCC = table.Column<int>(nullable: true),
                    HalLCCFast = table.Column<int>(nullable: true),
                    HalBulk = table.Column<int>(nullable: true),
                    HalBulkFast = table.Column<int>(nullable: true),
                    BDStartLCC = table.Column<int>(nullable: true),
                    BDStartLCCFast = table.Column<int>(nullable: true),
                    BDStartBulk = table.Column<int>(nullable: true),
                    BDStartBulkFast = table.Column<int>(nullable: true),
                    PbMiLCC = table.Column<int>(nullable: true),
                    PbMiBulk = table.Column<int>(nullable: true),
                    PbMiLoco = table.Column<int>(nullable: true),
                    PbEiLCC = table.Column<int>(nullable: true),
                    PbEiBulk = table.Column<int>(nullable: true),
                    PbEiLoco = table.Column<int>(nullable: true),
                    ULDMengeMenge = table.Column<int>(nullable: true),
                    ULDMengeMAStunden = table.Column<decimal>(nullable: true),
                    ULDMengeProdu = table.Column<decimal>(nullable: true),
                    ULDKG = table.Column<int>(nullable: true),
                    ULDKGMAStunden = table.Column<decimal>(nullable: true),
                    ULDKGProdu = table.Column<decimal>(nullable: true),
                    BulkMengeMenge = table.Column<int>(nullable: true),
                    BulkMengeMaStunden = table.Column<decimal>(nullable: true),
                    BulkMengeProdu = table.Column<decimal>(nullable: true),
                    zuletztbearbeitetvon = table.Column<string>(nullable: true),
                    zuletztbearbeitetam = table.Column<string>(nullable: true),
                    istabgeschlossen = table.Column<string>(nullable: true),
                    istfreigegeben = table.Column<string>(nullable: true),
                    abgeschlossenvon = table.Column<string>(nullable: true),
                    freigegebenvon = table.Column<string>(nullable: true),
                    schichtdatum = table.Column<DateTime>(nullable: false),
                    schichtbeginn = table.Column<string>(nullable: true),
                    schichtende = table.Column<string>(nullable: true),
                    schichttyp = table.Column<string>(nullable: true),
                    schichtbeurteilung = table.Column<string>(nullable: true),
                    erstelltam = table.Column<string>(nullable: true),
                    erstelltvon = table.Column<string>(nullable: true),
                    abgeschlossenam = table.Column<string>(nullable: true),
                    freigegebenam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerichtBD420", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dropdownoptions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<int>(nullable: false),
                    Selectbezeichnung = table.Column<string>(nullable: true),
                    Optionbezeichnung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dropdownoptions", x => x.ID);
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
                    Bereich = table.Column<string>(nullable: true),
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
                    istabgeschlossen = table.Column<string>(nullable: true),
                    BerichtBD420_ID = table.Column<int>(nullable: true),
                    BerichtBD451_ID = table.Column<int>(nullable: true),
                    BerichtBU320_ID = table.Column<int>(nullable: true),
                    BerichtBU420_ID = table.Column<int>(nullable: true),
                    datumgeplant = table.Column<DateTime>(nullable: false),
                    schichttyp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personalplan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Schichttyp",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schichttyp", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actiontracker");

            migrationBuilder.DropTable(
                name: "BerichtBD420");

            migrationBuilder.DropTable(
                name: "Dropdownoptions");

            migrationBuilder.DropTable(
                name: "Personalplan");

            migrationBuilder.DropTable(
                name: "Schichttyp");
        }
    }
}
