using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BerichtBD420",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Supervisor1 = table.Column<string>(nullable: true),
                    Supervisor2 = table.Column<string>(nullable: true),
                    Checker1 = table.Column<string>(nullable: true),
                    Checker2 = table.Column<string>(nullable: true),
                    Checker3 = table.Column<string>(nullable: true),
                    Checker4 = table.Column<string>(nullable: true),
                    Checker5 = table.Column<string>(nullable: true),
                    DGRChecker1 = table.Column<string>(nullable: true),
                    DGRChecker2 = table.Column<string>(nullable: true),
                    Frachtsicherung = table.Column<string>(nullable: true),
                    LagerdatenChecker = table.Column<string>(nullable: true),
                    QundS = table.Column<string>(nullable: true),
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
                    ULDMengeMAStunden = table.Column<int>(nullable: true),
                    ULDMengeProdu = table.Column<int>(nullable: true),
                    ULDKG = table.Column<int>(nullable: true),
                    ULDKGMAStunden = table.Column<int>(nullable: true),
                    ULDKGProdu = table.Column<int>(nullable: true),
                    BulkMengeMenge = table.Column<int>(nullable: true),
                    BulkMengeMaStunden = table.Column<int>(nullable: true),
                    BulkMengeProdu = table.Column<int>(nullable: true),
                    zuletztbearbeitetvon = table.Column<string>(nullable: true),
                    zuletztbearbeitetam = table.Column<string>(nullable: true),
                    istabgeschlossen = table.Column<string>(nullable: true),
                    istfreigegeben = table.Column<string>(nullable: true),
                    abgeschlossenvon = table.Column<string>(nullable: true),
                    freigegebenvon = table.Column<string>(nullable: true),
                    schichtdatum = table.Column<string>(nullable: true),
                    schichtbeginn = table.Column<string>(nullable: true),
                    schichtende = table.Column<string>(nullable: true),
                    schichttyp = table.Column<string>(nullable: true),
                    schichtbeurteilung = table.Column<string>(nullable: true),
                    VormannLCAG = table.Column<string>(nullable: true),
                    SchichtleiterLCAG = table.Column<string>(nullable: true),
                    erstelltam = table.Column<string>(nullable: true),
                    erstelltvon = table.Column<string>(nullable: true),
                    abgeschlossenam = table.Column<string>(nullable: true),
                    freigegebenam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerichtBD420", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BerichtBD420");
        }
    }
}
