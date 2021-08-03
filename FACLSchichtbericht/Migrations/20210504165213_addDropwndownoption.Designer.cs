﻿// <auto-generated />
using System;
using FACLSchichtbericht.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FACLSchichtbericht.Migrations
{
    [DbContext(typeof(FACL_DB_DevContext))]
    [Migration("20210504165213_addDropwndownoption")]
    partial class addDropwndownoption
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FACLSchichtbericht.Models.ActiontrackerModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bereich")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BerichtBD420_ID")
                        .HasColumnType("int");

                    b.Property<int?>("BerichtBD451_ID")
                        .HasColumnType("int");

                    b.Property<int?>("BerichtBU320_ID")
                        .HasColumnType("int");

                    b.Property<int?>("BerichtBU420_ID")
                        .HasColumnType("int");

                    b.Property<string>("Beschreibung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Maßnahme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Overview_ID")
                        .HasColumnType("int");

                    b.Property<string>("Priorität")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Von")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("erstelltam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("erstelltvon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("istabgeschlossen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zuletztbearbeitetam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zuletztbearbeitetvon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Actiontracker");
                });

            modelBuilder.Entity("FACLSchichtbericht.Models.BerichtBD420Model", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AbfertigerIst")
                        .HasColumnType("int");

                    b.Property<int?>("AbfertigerKrank")
                        .HasColumnType("int");

                    b.Property<int?>("AbfertigerSoll")
                        .HasColumnType("int");

                    b.Property<int?>("AbfertigerZusatz")
                        .HasColumnType("int");

                    b.Property<string>("Arbeitunsfall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AufbauerIst")
                        .HasColumnType("int");

                    b.Property<int?>("AufbauerKrank")
                        .HasColumnType("int");

                    b.Property<int?>("AufbauerSoll")
                        .HasColumnType("int");

                    b.Property<int?>("AufbauerZusatz")
                        .HasColumnType("int");

                    b.Property<int?>("AwaitingBulk")
                        .HasColumnType("int");

                    b.Property<int?>("AwaitingBulkFast")
                        .HasColumnType("int");

                    b.Property<int?>("AwaitingLCC")
                        .HasColumnType("int");

                    b.Property<int?>("AwaitingLCCFast")
                        .HasColumnType("int");

                    b.Property<int?>("BDStartBulk")
                        .HasColumnType("int");

                    b.Property<int?>("BDStartBulkFast")
                        .HasColumnType("int");

                    b.Property<int?>("BDStartLCC")
                        .HasColumnType("int");

                    b.Property<int?>("BDStartLCCFast")
                        .HasColumnType("int");

                    b.Property<int?>("BulkMengeMaStunden")
                        .HasColumnType("int");

                    b.Property<int?>("BulkMengeMenge")
                        .HasColumnType("int");

                    b.Property<int?>("BulkMengeProdu")
                        .HasColumnType("int");

                    b.Property<int?>("CDSDGR")
                        .HasColumnType("int");

                    b.Property<int?>("CDSStandard")
                        .HasColumnType("int");

                    b.Property<int?>("CheckerIst")
                        .HasColumnType("int");

                    b.Property<int?>("CheckerKrank")
                        .HasColumnType("int");

                    b.Property<int?>("CheckerSoll")
                        .HasColumnType("int");

                    b.Property<int?>("CheckerZusatz")
                        .HasColumnType("int");

                    b.Property<int?>("HalBulk")
                        .HasColumnType("int");

                    b.Property<int?>("HalBulkFast")
                        .HasColumnType("int");

                    b.Property<int?>("HalLCC")
                        .HasColumnType("int");

                    b.Property<int?>("HalLCCFast")
                        .HasColumnType("int");

                    b.Property<int?>("Leihscanner")
                        .HasColumnType("int");

                    b.Property<int?>("Leihstapler")
                        .HasColumnType("int");

                    b.Property<int?>("PbEiBulk")
                        .HasColumnType("int");

                    b.Property<int?>("PbEiLCC")
                        .HasColumnType("int");

                    b.Property<int?>("PbEiLoco")
                        .HasColumnType("int");

                    b.Property<int?>("PbMiBulk")
                        .HasColumnType("int");

                    b.Property<int?>("PbMiLCC")
                        .HasColumnType("int");

                    b.Property<int?>("PbMiLoco")
                        .HasColumnType("int");

                    b.Property<int?>("Pending")
                        .HasColumnType("int");

                    b.Property<int?>("PendingBulk")
                        .HasColumnType("int");

                    b.Property<int?>("PendingBulkFast")
                        .HasColumnType("int");

                    b.Property<int?>("PendingLCCFast")
                        .HasColumnType("int");

                    b.Property<int?>("SupervisorIst")
                        .HasColumnType("int");

                    b.Property<int?>("SupervisorKrank")
                        .HasColumnType("int");

                    b.Property<int?>("SupervisorSoll")
                        .HasColumnType("int");

                    b.Property<int?>("SupervisorZusatz")
                        .HasColumnType("int");

                    b.Property<int?>("ULDKG")
                        .HasColumnType("int");

                    b.Property<int?>("ULDKGMAStunden")
                        .HasColumnType("int");

                    b.Property<int?>("ULDKGProdu")
                        .HasColumnType("int");

                    b.Property<int?>("ULDMengeMAStunden")
                        .HasColumnType("int");

                    b.Property<int?>("ULDMengeMenge")
                        .HasColumnType("int");

                    b.Property<int?>("ULDMengeProdu")
                        .HasColumnType("int");

                    b.Property<string>("abgeschlossenam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("abgeschlossenvon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("erstelltam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("erstelltvon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("freigegebenam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("freigegebenvon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("istabgeschlossen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("istfreigegeben")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schichtbeginn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schichtbeurteilung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("schichtdatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("schichtende")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schichttyp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zuletztbearbeitetam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zuletztbearbeitetvon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BerichtBD420");
                });

            modelBuilder.Entity("FACLSchichtbericht.Models.PersonalplanModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bemerkung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bereich")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BerichtBD420_ID")
                        .HasColumnType("int");

                    b.Property<int?>("BerichtBD451_ID")
                        .HasColumnType("int");

                    b.Property<int?>("BerichtBU320_ID")
                        .HasColumnType("int");

                    b.Property<int?>("BerichtBU420_ID")
                        .HasColumnType("int");

                    b.Property<string>("Brandschutzhelfer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Einsatzals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ersthelfer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gewerk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Jobtitel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nachname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vorname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("anwesend")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumgeplant")
                        .HasColumnType("datetime2");

                    b.Property<string>("erstelltam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("erstelltvon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("istabgeschlossen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mehrarbeitgenehmight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schichttyp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zuletztbearbeitetam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zuletztbearbeitetvon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Personalplan");
                });

            modelBuilder.Entity("FACLSchichtbericht.Models.SchichttypModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bezeichnung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Schichttyp");
                });
#pragma warning restore 612, 618
        }
    }
}
