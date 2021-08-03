using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class FlugplanModel
    {
        [Key]
        public int ID { get; set; }

        public string Flugnummer { get; set; }
        public string Destination { get; set; }
        public string DepDateLtFRA { get; set; }
        public string Weekday { get; set; }
        public string Startime { get; set; }
        public string Endetime { get; set; }
        public string Palettierplatz { get; set; }
        public string Dienstleister { get; set; }
        public string PlatzOffnungvorSTD { get; set; }
        public string DIR { get; set; }
        public string Indikator { get; set; }
        public string USG13 { get; set; }


    }
}
