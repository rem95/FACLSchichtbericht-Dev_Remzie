using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class AddBereiche : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arbeitsunfall",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "Areamanager1",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "Areamanager2",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "AreamanagerIst",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "AreamanagerKrank",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "AreamanagerSoll",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "AwaitingBD473",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BCLBD473",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BCLBL",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BCLBU420",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BCLBU473",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BCLSV420",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BCLSV437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "Duty1",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "Duty2",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "HalBD473",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "KoordinatorHRL",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "Lagerdatencheck",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "LoseRFSactual",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "LoseRFScoming",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "OPSExpert1",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "OPSExpert2",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "OperationalexpertIst",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "OperationalexpertKrank",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "OperationalexpertSoll",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "PWC",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "PendingBD473",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "Perkoo",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "RCAToolCheck",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "SMSVorfall",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "StartBD473",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPDIRIst",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPDIRKrank",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPDIRSoll",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPHRLIst",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPHRLKrank",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPHRLSoll",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPQuerPerkoIst",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPQuerPerkoKrank",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPQuerPerkoSoll",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TPTeamlead",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TransportQuerPerkoMenge",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BellyKG",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "BellyKGMAStunden",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "BellyKGProdu",
                table: "BerichtBU320");

            migrationBuilder.RenameColumn(
                name: "TransportQuerPerkoStunden",
                table: "Overview",
                newName: "TransportQuerStunden");

            migrationBuilder.RenameColumn(
                name: "TransportQuerPerkoProdu",
                table: "Overview",
                newName: "TransportQuerProdu");

            migrationBuilder.RenameColumn(
                name: "TPQuerPerkoZusatz",
                table: "Overview",
                newName: "TransportPerkoStunden");

            migrationBuilder.RenameColumn(
                name: "TPHRLZusatz",
                table: "Overview",
                newName: "TransportPerkoProdu");

            migrationBuilder.RenameColumn(
                name: "TPDIRZusatz",
                table: "Overview",
                newName: "BU437ULDMengeStunden");

            migrationBuilder.RenameColumn(
                name: "OperationalexpertZusatz",
                table: "Overview",
                newName: "BU437ULDMengeProdu");

            migrationBuilder.RenameColumn(
                name: "AreamanagerZusatz",
                table: "Overview",
                newName: "BU437ULDKGStunden");

            migrationBuilder.AddColumn<string>(
                name: "ArbeitsunfallBD437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArbeitsunfallBU437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BD437ULDKGMenge",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BD437ULDKGProdu",
                table: "Overview",
                type: "decimal(18, 3)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BD437ULDKGStunden",
                table: "Overview",
                type: "decimal(18, 3)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BD437ULDMengeMenge",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BD437ULDMengeProdu",
                table: "Overview",
                type: "decimal(18, 3)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BD437ULDMengeStunden",
                table: "Overview",
                type: "decimal(18, 3)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BU437ULDKGMenge",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BU437ULDKGProdu",
                table: "Overview",
                type: "decimal(18, 3)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BU437ULDMengeMenge",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSdgrBD437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSdgrBU437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSstandardBD437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSstandardBU437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeihscannerBD437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeihscannerBU437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeihstaplerBD437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeihstaplerBU437",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransportPerkoMenge",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransportQuerMenge",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BellyMengeMAStunden",
                table: "BerichtBU320",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BellyMengeMenge",
                table: "BerichtBU320",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BellyMengeProdu",
                table: "BerichtBU320",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BerichtBD437");

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

            migrationBuilder.DropColumn(
                name: "ArbeitsunfallBD437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "ArbeitsunfallBU437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BD437ULDKGMenge",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BD437ULDKGProdu",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BD437ULDKGStunden",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BD437ULDMengeMenge",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BD437ULDMengeProdu",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BD437ULDMengeStunden",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BU437ULDKGMenge",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BU437ULDKGProdu",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BU437ULDMengeMenge",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "CDSdgrBD437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "CDSdgrBU437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "CDSstandardBD437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "CDSstandardBU437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "LeihscannerBD437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "LeihscannerBU437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "LeihstaplerBD437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "LeihstaplerBU437",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TransportPerkoMenge",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "TransportQuerMenge",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "BellyMengeMAStunden",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "BellyMengeMenge",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "BellyMengeProdu",
                table: "BerichtBU320");

            migrationBuilder.RenameColumn(
                name: "TransportQuerStunden",
                table: "Overview",
                newName: "TransportQuerPerkoStunden");

            migrationBuilder.RenameColumn(
                name: "TransportQuerProdu",
                table: "Overview",
                newName: "TransportQuerPerkoProdu");

            migrationBuilder.RenameColumn(
                name: "TransportPerkoStunden",
                table: "Overview",
                newName: "TPQuerPerkoZusatz");

            migrationBuilder.RenameColumn(
                name: "TransportPerkoProdu",
                table: "Overview",
                newName: "TPHRLZusatz");

            migrationBuilder.RenameColumn(
                name: "BU437ULDMengeStunden",
                table: "Overview",
                newName: "TPDIRZusatz");

            migrationBuilder.RenameColumn(
                name: "BU437ULDMengeProdu",
                table: "Overview",
                newName: "OperationalexpertZusatz");

            migrationBuilder.RenameColumn(
                name: "BU437ULDKGStunden",
                table: "Overview",
                newName: "AreamanagerZusatz");

            migrationBuilder.AddColumn<string>(
                name: "Arbeitsunfall",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Areamanager1",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Areamanager2",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AreamanagerIst",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AreamanagerKrank",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AreamanagerSoll",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AwaitingBD473",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BCLBD473",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCLBL",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BCLBU420",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BCLBU473",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCLSV420",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCLSV437",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duty1",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duty2",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HalBD473",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KoordinatorHRL",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lagerdatencheck",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoseRFSactual",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoseRFScoming",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OPSExpert1",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OPSExpert2",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OperationalexpertIst",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OperationalexpertKrank",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OperationalexpertSoll",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PWC",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PendingBD473",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Perkoo",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RCAToolCheck",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SMSVorfall",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartBD473",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TPDIRIst",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TPDIRKrank",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TPDIRSoll",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TPHRLIst",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TPHRLKrank",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TPHRLSoll",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TPQuerPerkoIst",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TPQuerPerkoKrank",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TPQuerPerkoSoll",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TPTeamlead",
                table: "Overview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransportQuerPerkoMenge",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BellyKG",
                table: "BerichtBU320",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BellyKGMAStunden",
                table: "BerichtBU320",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BellyKGProdu",
                table: "BerichtBU320",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
