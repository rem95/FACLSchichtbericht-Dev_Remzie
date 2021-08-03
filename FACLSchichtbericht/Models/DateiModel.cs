using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class DateiModel
    {
        [Key]
        public int ID { get; set; }

        public Int64? Base64 { get; set; }

        public string Endung { get; set; }

        public string Name { get; set; }

        public string Kategorie { get; set; }

        public string Type { get; set; }

        public string Erstelltam { get; set; }

        public string Erstelltvon { get; set; }

        public string Istabgeschlossen { get; set; }

        public string IstFreigegeben { get; set; }

        public string Abgeschlossenam { get; set; }

        public string Abgeschlossenvon { get; set; }

        public string Freigegebenam { get; set; }

        public string Freigegebenvon { get; set; }



    }
}
