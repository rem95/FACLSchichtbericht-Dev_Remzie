using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class SvEditorPersonalplanModel
    {

        //public int ID { get; set; }
        public string PK { get; set; }

        public string Nachname { get; set; }

        public string Vorname { get; set; }

        public string Gewerk { get; set; }

        public string Bereich { get; set; }

        public string Jobtitel { get; set; }

        public string Einsatzals { get; set; }

        public string anwesend { get; set; }

        public string Bemerkung { get; set; }

        public string datumgeplant { get; set; }

        public string schichttyp { get; set; }


    }
}
