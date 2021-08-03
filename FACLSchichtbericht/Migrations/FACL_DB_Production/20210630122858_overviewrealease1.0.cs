using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations.FACL_DB_Production
{
    public partial class overviewrealease10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ULDKG",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "AKHKG",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "ULDMengeMAStunden",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "ULDMengeMenge",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "ULDMengeProdu",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "ULDKG",
                table: "BerichtBD451");

            migrationBuilder.DropColumn(
                name: "ULDKG",
                table: "BerichtBD420");

            migrationBuilder.AlterColumn<DateTime>(
                name: "zuletztbearbeitetam",
                table: "Overview",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "freigegebenam",
                table: "Overview",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "erstelltvon",
                table: "Overview",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "erstelltam",
                table: "Overview",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "abgeschlossenam",
                table: "Overview",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "berichtdatum",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "overviewdatum",
                table: "Overview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DIRMenge",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DIRProdu",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DIRStunden",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HRLMenge",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HRLProdu",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HRLStunden",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerkoMenge",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PerkoProdu",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PerkoStunden",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuerMenge",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "QuerProdu",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "QuerStunden",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "abgeschlossenam",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "abgeschlossenvon",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "erstelltam",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "erstelltvon",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "freigegebenam",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "freigegebenvon",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "istabgeschlossen",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "istfreigegeben",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichtbeginn",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichtbeurteilung",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "schichtdatum",
                table: "BerichtTransport",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "schichtende",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichttyp",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zuletztbearbeitetam",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zuletztbearbeitetvon",
                table: "BerichtTransport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitunsfall",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSDGR",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSStandard",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Leihscanner",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Leihstapler",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDKGMenge",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDKGProdu",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDKGStunden",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDMengeMenge",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeProdu",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeStunden",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "abgeschlossenam",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "abgeschlossenvon",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "erstelltam",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "erstelltvon",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "freigegebenam",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "freigegebenvon",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "istabgeschlossen",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "istfreigegeben",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichtbeginn",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichtbeurteilung",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "schichtdatum",
                table: "BerichtBU437",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "schichtende",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichttyp",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zuletztbearbeitetam",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zuletztbearbeitetvon",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDKGMenge",
                table: "BerichtBU420",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AKHKGMenge",
                table: "BerichtBU320",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AKHMengeMAStunden",
                table: "BerichtBU320",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AKHMengeMenge",
                table: "BerichtBU320",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AKHMengeProdu",
                table: "BerichtBU320",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDKGMenge",
                table: "BerichtBD451",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitunsfall",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSDGR",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDSStandard",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Leihscanner",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Leihstapler",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDKGMenge",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDKGProdu",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDKGStunden",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDMengeMenge",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeProdu",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeStunden",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "abgeschlossenam",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "abgeschlossenvon",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "erstelltam",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "erstelltvon",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "freigegebenam",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "freigegebenvon",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "istabgeschlossen",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "istfreigegeben",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichtbeginn",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichtbeurteilung",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "schichtdatum",
                table: "BerichtBD437",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "schichtende",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichttyp",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zuletztbearbeitetam",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zuletztbearbeitetvon",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDKGMenge",
                table: "BerichtBD420",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "berichtdatum",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "overviewdatum",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "DIRMenge",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "DIRProdu",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "DIRStunden",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "HRLMenge",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "HRLProdu",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "HRLStunden",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "PerkoMenge",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "PerkoProdu",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "PerkoStunden",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "QuerMenge",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "QuerProdu",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "QuerStunden",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "abgeschlossenam",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "abgeschlossenvon",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "erstelltam",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "erstelltvon",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "freigegebenam",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "freigegebenvon",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "istabgeschlossen",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "istfreigegeben",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "schichtbeginn",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "schichtbeurteilung",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "schichtdatum",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "schichtende",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "schichttyp",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "zuletztbearbeitetam",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "zuletztbearbeitetvon",
                table: "BerichtTransport");

            migrationBuilder.DropColumn(
                name: "Arbeitunsfall",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "CDSDGR",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "CDSStandard",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "Leihscanner",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "Leihstapler",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "ULDKGMenge",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "ULDKGProdu",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "ULDKGStunden",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "ULDMengeMenge",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "ULDMengeProdu",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "ULDMengeStunden",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "abgeschlossenam",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "abgeschlossenvon",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "erstelltam",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "erstelltvon",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "freigegebenam",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "freigegebenvon",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "istabgeschlossen",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "istfreigegeben",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "schichtbeginn",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "schichtbeurteilung",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "schichtdatum",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "schichtende",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "schichttyp",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "zuletztbearbeitetam",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "zuletztbearbeitetvon",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "ULDKGMenge",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "AKHKGMenge",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "AKHMengeMAStunden",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "AKHMengeMenge",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "AKHMengeProdu",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "ULDKGMenge",
                table: "BerichtBD451");

            migrationBuilder.DropColumn(
                name: "Arbeitunsfall",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "CDSDGR",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "CDSStandard",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "Leihscanner",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "Leihstapler",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "ULDKGMenge",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "ULDKGProdu",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "ULDKGStunden",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "ULDMengeMenge",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "ULDMengeProdu",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "ULDMengeStunden",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "abgeschlossenam",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "abgeschlossenvon",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "erstelltam",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "erstelltvon",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "freigegebenam",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "freigegebenvon",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "istabgeschlossen",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "istfreigegeben",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "schichtbeginn",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "schichtbeurteilung",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "schichtdatum",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "schichtende",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "schichttyp",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "zuletztbearbeitetam",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "zuletztbearbeitetvon",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "ULDKGMenge",
                table: "BerichtBD420");

            migrationBuilder.AlterColumn<DateTime>(
                name: "zuletztbearbeitetam",
                table: "Overview",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "freigegebenam",
                table: "Overview",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "erstelltvon",
                table: "Overview",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "erstelltam",
                table: "Overview",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "abgeschlossenam",
                table: "Overview",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDKG",
                table: "BerichtBU420",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AKHKG",
                table: "BerichtBU320",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeMAStunden",
                table: "BerichtBU320",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDMengeMenge",
                table: "BerichtBU320",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ULDMengeProdu",
                table: "BerichtBU320",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDKG",
                table: "BerichtBD451",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ULDKG",
                table: "BerichtBD420",
                type: "int",
                nullable: true);
        }
    }
}
