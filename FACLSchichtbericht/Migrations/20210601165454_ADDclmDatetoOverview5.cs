using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FACLSchichtbericht.Migrations
{
    public partial class ADDclmDatetoOverview5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "schichtdatum",
                table: "Overview");

            migrationBuilder.AddColumn<DateTime>(
                name: "berichtdatum",
                table: "Overview",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "overviewdatum",
                table: "Overview",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<DateTime>(
                name: "schichtdatum",
                table: "Overview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
