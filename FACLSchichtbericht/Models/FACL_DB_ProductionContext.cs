using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class FACL_DB_ProductionContext :DbContext
    {
        public FACL_DB_ProductionContext(DbContextOptions<FACL_DB_ProductionContext> options) : base(options)
        {

        }

        public DbSet<BerichtBD420Model> BerichtBD420 { get; set; }

        public DbSet<BerichtBD451Model> BerichtBD451 { get; set; }

        public DbSet<BerichtBU320Model> BerichtBU320 { get; set; }

        public DbSet<BerichtBU420Model> BerichtBU420 { get; set; }

        public DbSet<BerichtBD437Model> BerichtBD437 { get; set; }

        public DbSet<BerichtBU437Model> BerichtBU437 { get; set; }

        public DbSet<BerichtTransportModel> BerichtTransport { get; set; }

        public DbSet<BerichtBCLPositionModel> BerichtBCLPosition { get; set; }


        public DbSet<DateiModel> Datei { get; set; }

        public DbSet<OverviewModel> Overview { get; set; }

        public DbSet<DropdownoptionsModel> Dropdownoptions { get; set; }

        public DbSet<FlugplanModel> Flugplan { get; set; }

        public DbSet<FlugleistungenModel> Flugleistungen { get; set; }

        public DbSet<PersonalplanModel> Personalplan { get; set; }

        public DbSet<ActiontrackerModel> Actiontracker { get; set; }

        public DbSet<SchichttypModel> Schichttyp { get; set; }


    }


}

