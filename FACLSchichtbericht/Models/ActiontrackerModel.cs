using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FACLSchichtbericht.Models
{
    public class ActiontrackerModel
    {
        [Key]
        public int ID { get; set; }

        public string UserName { get; set; }

        public DateTime Datum { get; set; }

        public string Von { get; set; }

        public string Bis { get; set; }

        public string Action { get; set; }

        public string Priorität { get; set; }

        public string Bereich { get; set; }

        public string Beschreibung { get; set; }

        public string Maßnahme { get; set; }

        public string erstelltam { get; set; }

        public string erstelltvon { get; set; }

        public string zuletztbearbeitetam { get; set; }

        public string zuletztbearbeitetvon { get; set; }

        public string istabgeschlossen { get; set; }

        public int? BerichtBD420_ID { get; set; }

        public int? BerichtBD451_ID { get; set; }

        public int? BerichtBU320_ID { get; set; }

        public int? BerichtBU420_ID { get; set; }

        public int? BerichtBD437_ID { get; set; }
        public int? BerichtBU437_ID { get; set; }
        public int? BerichtTransport_ID { get; set; }
        public int? BerichtBCLPosition_ID { get; set; }

        public int? Overview_ID { get; set; }


    }
}
