using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class BerichtBD451Model
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
        public int? CheckerSoll { get; set; }
        public int? CheckerIst { get; set; }
        public int? CheckerKrank { get; set; }
        public int? CheckerZusatz { get; set; }
        public int? AufbauerSoll { get; set; }
        public int? AufbauerIst { get; set; }
        public int? AufbauerKrank { get; set; }
        public int? AufbauerZusatz { get; set; }
        public int? AbfertigerIst { get; set; }
        public int? AbfertigerSoll { get; set; }
        public int? AbfertigerKrank { get; set; }
        public int? AbfertigerZusatz { get; set; }
        public int? AwaitingLoco { get; set; }
        public int? PendingLoco { get; set; }
        public int? HalLoco { get; set; }
        public int? BDStartLoco { get; set; }
        public int? ULDMengeMenge { get; set; }
        public decimal? ULDMengeMAStunden { get; set; }
        public decimal? ULDMengeProdu { get; set; }
        public int? ULDKGMenge { get; set; }
        public decimal? ULDKGMAStunden { get; set; }
        public decimal? ULDKGProdu { get; set; }
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
