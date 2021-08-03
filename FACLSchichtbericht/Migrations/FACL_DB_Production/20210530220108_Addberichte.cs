using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations.FACL_DB_Production
{
    public partial class Addberichte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BerichtBD437",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerichtBD437", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BerichtBD451",
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
                    AwaitingLoco = table.Column<int>(nullable: true),
                    PendingLoco = table.Column<int>(nullable: true),
                    HalLoco = table.Column<int>(nullable: true),
                    BDStartLoco = table.Column<int>(nullable: true),
                    ULDMengeMenge = table.Column<int>(nullable: true),
                    ULDMengeMAStunden = table.Column<decimal>(nullable: true),
                    ULDMengeProdu = table.Column<decimal>(nullable: true),
                    ULDKG = table.Column<int>(nullable: true),
                    ULDKGMAStunden = table.Column<decimal>(nullable: true),
                    ULDKGProdu = table.Column<decimal>(nullable: true),
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
                    table.PrimaryKey("PK_BerichtBD451", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BerichtBU320",
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
                    TeamleadSoll = table.Column<int>(nullable: true),
                    TeamleadIst = table.Column<int>(nullable: true),
                    TeamleadKrank = table.Column<int>(nullable: true),
                    TeamleadZusatz = table.Column<int>(nullable: true),
                    PalettiererSoll = table.Column<int>(nullable: true),
                    PalettiererIst = table.Column<int>(nullable: true),
                    PalettiererKrank = table.Column<int>(nullable: true),
                    PalettiererZusatz = table.Column<int>(nullable: true),
                    AbfertigerIst = table.Column<int>(nullable: true),
                    AbfertigerSoll = table.Column<int>(nullable: true),
                    AbfertigerKrank = table.Column<int>(nullable: true),
                    AbfertigerZusatz = table.Column<int>(nullable: true),
                    ULDMengeMenge = table.Column<int>(nullable: true),
                    ULDMengeMAStunden = table.Column<decimal>(nullable: true),
                    ULDMengeProdu = table.Column<decimal>(nullable: true),
                    AKHKG = table.Column<int>(nullable: true),
                    AKHKGMAStunden = table.Column<decimal>(nullable: true),
                    AKHKGProdu = table.Column<decimal>(nullable: true),
                    BellyMengeMenge = table.Column<int>(nullable: true),
                    BellyMengeMAStunden = table.Column<decimal>(nullable: true),
                    BellyMengeProdu = table.Column<decimal>(nullable: true),
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
                    table.PrimaryKey("PK_BerichtBU320", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BerichtBU420",
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
                    TeamleadSoll = table.Column<int>(nullable: true),
                    TeamleadIst = table.Column<int>(nullable: true),
                    TeamleadKrank = table.Column<int>(nullable: true),
                    TeamleadZusatz = table.Column<int>(nullable: true),
                    PalettiererSoll = table.Column<int>(nullable: true),
                    PalettiererIst = table.Column<int>(nullable: true),
                    PalettiererKrank = table.Column<int>(nullable: true),
                    PalettiererZusatz = table.Column<int>(nullable: true),
                    AbfertigerIst = table.Column<int>(nullable: true),
                    AbfertigerSoll = table.Column<int>(nullable: true),
                    AbfertigerKrank = table.Column<int>(nullable: true),
                    AbfertigerZusatz = table.Column<int>(nullable: true),
                    ULDMengeMenge = table.Column<int>(nullable: true),
                    ULDMengeMAStunden = table.Column<decimal>(nullable: true),
                    ULDMengeProdu = table.Column<decimal>(nullable: true),
                    ULDKG = table.Column<int>(nullable: true),
                    ULDKGMAStunden = table.Column<decimal>(nullable: true),
                    ULDKGProdu = table.Column<decimal>(nullable: true),
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
                    table.PrimaryKey("PK_BerichtBU420", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BerichtBU437",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerichtBU437", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BerichtTransport",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerichtTransport", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Datei",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Base64 = table.Column<long>(nullable: true),
                    Endung = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Kategorie = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Erstelltam = table.Column<string>(nullable: true),
                    Erstelltvon = table.Column<string>(nullable: true),
                    Istabgeschlossen = table.Column<string>(nullable: true),
                    IstFreigegeben = table.Column<string>(nullable: true),
                    Abgeschlossenam = table.Column<string>(nullable: true),
                    Abgeschlossenvon = table.Column<string>(nullable: true),
                    Freigegebenam = table.Column<string>(nullable: true),
                    Freigegebenvon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datei", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Flugleistungen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flugleistungen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Flugplan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flugnummer = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    DepDateLtFRA = table.Column<string>(nullable: true),
                    Weekday = table.Column<string>(nullable: true),
                    Startime = table.Column<string>(nullable: true),
                    Endetime = table.Column<string>(nullable: true),
                    Palettierplatz = table.Column<string>(nullable: true),
                    Dienstleister = table.Column<string>(nullable: true),
                    PlatzOffnungvorSTD = table.Column<string>(nullable: true),
                    DIR = table.Column<string>(nullable: true),
                    Indikator = table.Column<string>(nullable: true),
                    USG13 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flugplan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Overview",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HDO = table.Column<string>(nullable: true),
                    SchichtleiterPT = table.Column<string>(nullable: true),
                    SchichtleiterLF = table.Column<string>(nullable: true),
                    DutymanagerSoll = table.Column<int>(nullable: true),
                    DutymanagerIst = table.Column<int>(nullable: true),
                    DutymanagerKrank = table.Column<int>(nullable: true),
                    DutymanagerZusatz = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BDSupervisorSoll = table.Column<int>(nullable: true),
                    BDSupervisorIst = table.Column<int>(nullable: true),
                    BDSupervisorKrank = table.Column<int>(nullable: true),
                    BDSupervisorZusatz = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BDCheckerSoll = table.Column<int>(nullable: true),
                    BDCheckerIst = table.Column<int>(nullable: true),
                    BDCheckerKrank = table.Column<int>(nullable: true),
                    BDCheckerZusatz = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BDAufbauerSoll = table.Column<int>(nullable: true),
                    BDAufbauerIst = table.Column<int>(nullable: true),
                    BDAufbauerKrank = table.Column<int>(nullable: true),
                    BDAufbauerZusatz = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BDAbfertigerSoll = table.Column<int>(nullable: true),
                    BDAbfertigerIst = table.Column<int>(nullable: true),
                    BDAbfertigerKrank = table.Column<int>(nullable: true),
                    BDAbfertigerZusatz = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BUSupervisorSoll = table.Column<int>(nullable: true),
                    BUSupervisorIst = table.Column<int>(nullable: true),
                    BUSupervisorKrank = table.Column<int>(nullable: true),
                    BUSupervisorZusatz = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BUTeamleadSoll = table.Column<int>(nullable: true),
                    BUTeamleadIst = table.Column<int>(nullable: true),
                    BUTeamleadKrank = table.Column<int>(nullable: true),
                    BUTeamleadZusatz = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BUPalettiererSoll = table.Column<int>(nullable: true),
                    BUPalettiererIst = table.Column<int>(nullable: true),
                    BUPalettiererKrank = table.Column<int>(nullable: true),
                    BUPalettiererZusatz = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BUAbfertigerSoll = table.Column<int>(nullable: true),
                    BUAbfertigerIst = table.Column<int>(nullable: true),
                    BUAbfertigerKrank = table.Column<int>(nullable: true),
                    BUAbfertigerZusatz = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    LeihscannerBD420 = table.Column<int>(nullable: true),
                    LeihstaplerBD420 = table.Column<int>(nullable: true),
                    CDSstandardBD420 = table.Column<int>(nullable: true),
                    CDSdgrBD420 = table.Column<int>(nullable: true),
                    ArbeitsunfallBD420 = table.Column<string>(nullable: true),
                    LeihscannerBD451 = table.Column<int>(nullable: true),
                    LeihstaplerBD451 = table.Column<int>(nullable: true),
                    CDSstandardBD451 = table.Column<int>(nullable: true),
                    CDSdgrBD451 = table.Column<int>(nullable: true),
                    ArbeitsunfallBD451 = table.Column<string>(nullable: true),
                    LeihscannerBU320 = table.Column<int>(nullable: true),
                    LeihstaplerBU320 = table.Column<int>(nullable: true),
                    CDSstandardBU320 = table.Column<int>(nullable: true),
                    CDSdgrBU320 = table.Column<int>(nullable: true),
                    ArbeitsunfallBU320 = table.Column<string>(nullable: true),
                    LeihscannerBU420 = table.Column<int>(nullable: true),
                    LeihstaplerBU420 = table.Column<int>(nullable: true),
                    CDSstandardBU420 = table.Column<int>(nullable: true),
                    CDSdgrBU420 = table.Column<int>(nullable: true),
                    ArbeitsunfallBU420 = table.Column<string>(nullable: true),
                    LeihscannerBD437 = table.Column<int>(nullable: true),
                    LeihstaplerBD437 = table.Column<int>(nullable: true),
                    CDSstandardBD437 = table.Column<int>(nullable: true),
                    CDSdgrBD437 = table.Column<int>(nullable: true),
                    ArbeitsunfallBD437 = table.Column<string>(nullable: true),
                    LeihscannerBU437 = table.Column<int>(nullable: true),
                    LeihstaplerBU437 = table.Column<int>(nullable: true),
                    CDSstandardBU437 = table.Column<int>(nullable: true),
                    CDSdgrBU437 = table.Column<int>(nullable: true),
                    ArbeitsunfallBU437 = table.Column<string>(nullable: true),
                    BD420ULDMengeMenge = table.Column<int>(nullable: true),
                    BD420ULDKGMenge = table.Column<int>(nullable: true),
                    BD420BULKMengeMenge = table.Column<int>(nullable: true),
                    BD420ULDMengeStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD420ULDKGStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD420BulkMengeStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD420ULDMengeProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD420ULDKGProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD420BulkMengeProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD451ULDMengeMenge = table.Column<int>(nullable: true),
                    BD451ULDKGMenge = table.Column<int>(nullable: true),
                    BD451ULDMengeStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD451ULDKGStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD451ULDMengeProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD451ULDKGProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU320AKHMengeMenge = table.Column<int>(nullable: true),
                    BU320AKHKGMenge = table.Column<int>(nullable: true),
                    BU320BellyMengeMenge = table.Column<int>(nullable: true),
                    BU320AKHMengeStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU320AKHKGStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU320BellyMengeStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU320AKHMengeProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU320AKHKGProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU320BellyMengeProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU420ULDMengeMenge = table.Column<int>(nullable: true),
                    BU420ULDKGMenge = table.Column<int>(nullable: true),
                    BU420ULDMengeStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU420ULDKGStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU420ULDMengeProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU420ULDKGProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU437ULDMengeMenge = table.Column<int>(nullable: true),
                    BU437ULDKGMenge = table.Column<int>(nullable: true),
                    BU437ULDMengeStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU437ULDKGStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU437ULDMengeProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BU437ULDKGProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD437ULDMengeMenge = table.Column<int>(nullable: true),
                    BD437ULDKGMenge = table.Column<int>(nullable: true),
                    BD437ULDMengeStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD437ULDKGStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD437ULDMengeProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    BD437ULDKGProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    TransportHRLMenge = table.Column<int>(nullable: true),
                    TransportDIRMenge = table.Column<int>(nullable: true),
                    TransportQuerMenge = table.Column<int>(nullable: true),
                    TransportPerkoMenge = table.Column<int>(nullable: true),
                    TransportHRLStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    TransportDIRStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    TransportQuerStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    TransportPerkoStunden = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    TransportHRLProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    TransportDIRProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    TransportQuerProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    TransportPerkoProdu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    zuletztbearbeitetvon = table.Column<string>(nullable: true),
                    zuletztbearbeitetam = table.Column<DateTime>(nullable: false),
                    istabgeschlossen = table.Column<string>(nullable: true),
                    istfreigegeben = table.Column<string>(nullable: true),
                    abgeschlossenvon = table.Column<string>(nullable: true),
                    freigegebenvon = table.Column<string>(nullable: true),
                    schichttyp = table.Column<string>(nullable: true),
                    schichttyp_ID = table.Column<int>(nullable: false),
                    schichtbeurteilung = table.Column<string>(nullable: true),
                    erstelltam = table.Column<DateTime>(nullable: false),
                    erstelltvon = table.Column<DateTime>(nullable: false),
                    abgeschlossenam = table.Column<DateTime>(nullable: false),
                    freigegebenam = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Overview", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BerichtBD437");

            migrationBuilder.DropTable(
                name: "BerichtBD451");

            migrationBuilder.DropTable(
                name: "BerichtBU320");

            migrationBuilder.DropTable(
                name: "BerichtBU420");

            migrationBuilder.DropTable(
                name: "BerichtBU437");

            migrationBuilder.DropTable(
                name: "BerichtTransport");

            migrationBuilder.DropTable(
                name: "Datei");

            migrationBuilder.DropTable(
                name: "Flugleistungen");

            migrationBuilder.DropTable(
                name: "Flugplan");

            migrationBuilder.DropTable(
                name: "Overview");
        }
    }
}
