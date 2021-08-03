using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace FACLSchichtbericht.Models
{

    public class PersonalplanModel
    {
        [Key]
        public int ID { get; set; }

        public string PK { get; set; }

        public string Nachname { get; set; }

        public string Vorname { get; set; }

        public string Gewerk { get; set; }

        public string Bereich { get; set; }

        public string Jobtitel { get; set; }

        public string Einsatzals { get; set; }

        public string AG { get; set; }

        public string Brandschutzhelfer { get; set; }

        public string Ersthelfer { get; set; }

        public string anwesend { get; set; }

        public string mehrarbeitgenehmight { get; set; }

        public string Bemerkung { get; set; }

        public string erstelltam { get; set; }

        public string erstelltvon { get; set; }

        public string zuletztbearbeitetam { get; set; }

        public string zuletztbearbeitetvon { get; set; }

        public string istabgeschlossen { get; set; }


        public int? BerichtBD420_ID { get; set; }

        public int? BerichtBD451_ID { get; set; }

        public int? BerichtBU320_ID { get; set; }

        public int? BerichtBU420_ID { get; set; }


        public DateTime datumgeplant { get; set; }

        public string schichttyp { get; set; }

        public int? BerichtBD437_ID { get; set; }
        public int? BerichtBU437_ID { get; set; }
        public int? BerichtTransport_ID { get; set; }
    }
}
