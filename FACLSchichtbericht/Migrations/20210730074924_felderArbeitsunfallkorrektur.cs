using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class felderArbeitsunfallkorrektur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arbeitunsfall",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "Arbeitunsfall",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "Arbeitunsfall",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "Arbeitunsfall",
                table: "BerichtBD451");

            migrationBuilder.DropColumn(
                name: "Arbeitunsfall",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "Arbeitunsfall",
                table: "BerichtBD420");

            migrationBuilder.AddColumn<string>(
                name: "Arbeitsunfall",
                table: "BerichtBU437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitsunfall",
                table: "BerichtBU420",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitsunfall",
                table: "BerichtBU320",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitsunfall",
                table: "BerichtBD451",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitsunfall",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Awaiting",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BDStart",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hal",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pending",
                table: "BerichtBD437",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitsunfall",
                table: "BerichtBD420",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BerichtBU437_ID",
                table: "BerichtBCLPosition",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BerichtBD437_ID",
                table: "BerichtBCLPosition",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "erstelltam",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "erstelltvon",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "istabgeschlossen",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schichtbeurteilung",
                table: "BerichtBCLPosition",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "schichtdatum",
                table: "BerichtBCLPosition",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "schichttyp",
                table: "BerichtBCLPosition",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arbeitsunfall",
                table: "BerichtBU437");

            migrationBuilder.DropColumn(
                name: "Arbeitsunfall",
                table: "BerichtBU420");

            migrationBuilder.DropColumn(
                name: "Arbeitsunfall",
                table: "BerichtBU320");

            migrationBuilder.DropColumn(
                name: "Arbeitsunfall",
                table: "BerichtBD451");

            migrationBuilder.DropColumn(
                name: "Arbeitsunfall",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "Awaiting",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "BDStart",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "Hal",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "Pending",
                table: "BerichtBD437");

            migrationBuilder.DropColumn(
                name: "Arbeitsunfall",
                table: "BerichtBD420");

            migrationBuilder.DropColumn(
                name: "erstelltam",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "erstelltvon",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "istabgeschlossen",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "schichtbeurteilung",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "schichtdatum",
                table: "BerichtBCLPosition");

            migrationBuilder.DropColumn(
                name: "schichttyp",
                table: "BerichtBCLPosition");

            migrationBuilder.AddColumn<string>(
                name: "Arbeitunsfall",
                table: "BerichtBU437",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitunsfall",
                table: "BerichtBU420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitunsfall",
                table: "BerichtBU320",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitunsfall",
                table: "BerichtBD451",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitunsfall",
                table: "BerichtBD437",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Arbeitunsfall",
                table: "BerichtBD420",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BerichtBU437_ID",
                table: "BerichtBCLPosition",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BerichtBD437_ID",
                table: "BerichtBCLPosition",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
