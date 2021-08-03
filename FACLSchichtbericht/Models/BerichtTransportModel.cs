using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class BerichtTransportModel
    {

        [Key]
        public int ID { get; set; }

        public int? Leihscanner { get; set; }
        public int? Leihstapler { get; set; }
        public int? CDSStandard { get; set; }
        public int? CDSDgr { get; set; }
        public string Arbeitsunfall { get; set; }
        public int? HRLSoll { get; set; }
        public int? HRLIst { get; set; }
        public int? HRLKrank { get; set; }
        public int? HRLZusatzleistung { get; set; }
        public int? DIRSoll { get; set; }
        public int? DIRIst { get; set; }
        public int? DIRKrank { get; set; }
        public int? DIRZusatzleistung { get; set; }
        public int? QuerSoll { get; set; }
        public int? QuerIst { get; set; }
        public int? QuerKrank { get; set; }
        public int? QuerZusatzleistung { get; set; }
        public int? PerkoSoll { get; set; }
        public int? PerkoIst { get; set; }
        public int? PerkoKrank { get; set; }
        public int? PerkoZusatzleistung { get; set; }

        public int? HRLMenge { get; set; }
        public decimal? HRLStunden { get; set; }
        public decimal? HRLProdu { get; set; }
        public int? DIRMenge { get; set; }
        public decimal? DIRStunden { get; set; }
        public decimal? DIRProdu { get; set; }
        public int? QuerMenge { get; set; }
        public decimal? QuerStunden { get; set; }
        public decimal? QuerProdu { get; set; }
        public int? PerkoMenge { get; set; }
        public decimal? PerkoStunden { get; set; }
        public decimal? PerkoProdu { get; set; }

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
