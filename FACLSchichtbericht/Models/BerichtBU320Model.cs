using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class BerichtBU320Model
    {
        [Key]
        public int ID { get; set; }

        public int? Leihscanner { get; set; }
        public int? Leihstapler { get; set; }
        public int? CDSStandard { get; set; }
        public int? CDSDGR { get; set; }
        public string Arbeitsunfall { get; set; }
        public int? SupervisorSoll { get; set; }
        public int? SupervisorIst { get; set; }
        public int? SupervisorKrank { get; set; }
        public int? SupervisorZusatz { get; set; }
        public int? TeamleadSoll { get; set; }
        public int? TeamleadIst { get; set; }
        public int? TeamleadKrank { get; set; }
        public int? TeamleadZusatz { get; set; }
        public int? PalettiererSoll { get; set; }
        public int? PalettiererIst { get; set; }
        public int? PalettiererKrank { get; set; }
        public int? PalettiererZusatz { get; set; }
        public int? AbfertigerIst { get; set; }
        public int? AbfertigerSoll { get; set; }
        public int? AbfertigerKrank { get; set; }
        public int? AbfertigerZusatz { get; set; }
        public int? AKHMengeMenge { get; set; }
        public decimal? AKHMengeMAStunden { get; set; }
        public decimal? AKHMengeProdu { get; set; }
        public int? AKHKGMenge { get; set; }
        public decimal? AKHKGMAStunden { get; set; }
        public decimal? AKHKGProdu { get; set; }
        public int? BellyMengeMenge { get; set; }
        public decimal? BellyMengeMAStunden { get; set; }
        public decimal? BellyMengeProdu { get; set; }
        public string zuletztbearbeitetvon { get; set; }
        public string zuletztbearbeitetam { get; set; }
        public string istabgeschlossen { get; set; }
        public string istfreigegeben { get; set; }
        public string abgeschlossenvon { get; set; }
        public string freigegebenvon { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime schichtdatum { get; set; }
        public string schichtbeginn { get; set; }
        public string schichtende { get; set; }
        public string schichttyp { get; set; }
        public string schichtbeurteilung { get; set; }

        public string erstelltam { get; set; }
        public string erstelltvon { get; set; }
        public string abgeschlossenam { get; set; }
        public string freigegebenam { get; set; }

    }
}
