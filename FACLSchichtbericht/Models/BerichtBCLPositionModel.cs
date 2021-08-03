using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class BerichtBCLPositionModel
    {
        [Key]
        public int ID { get; set; }

        public int? BerichtBD437_ID { get; set; }
        public int? BerichtBU437_ID { get; set; }

        public int? Leihscanner { get; set; }
        public int? Leihstapler { get; set; }
        public int? CDSStandard { get; set; }
        public int? CDSDGR { get; set; }
        public string Arbeitsunfall { get; set; }

        public int? BU437Soll { get; set; }
        public int? BU437Ist { get; set; }
        public int? BD437Soll { get; set; }
        public int? BD437Ist { get; set; }



        public string Awaiting { get; set; }
        public string Pending { get; set; }
        public string Hal { get; set; }
        public string BDStart { get; set; }

        public int? RFSactual { get; set; }
        public int? RFScoming { get; set; }

        public int? Bu437ULDMengeMenge { get; set; }
        public decimal? Bu437ULDMengeStunden { get; set; }
        public decimal? Bu437ULDMengeProdu { get; set; }
        public int? Bu437ULDKGMenge { get; set; }
        public decimal? Bu437ULDKGStunden { get; set; }
        public decimal? Bu437ULDKGProdu { get; set; }
        public int? Bd437ULDMengeMenge { get; set; }
        public decimal? Bd437ULDMengeStunden { get; set; }
        public decimal? Bd437ULDMengeProdu { get; set; }
        public int? Bd437ULDKGMenge { get; set; }
        public decimal? Bd437ULDKGStunden { get; set; }
        public decimal? Bd437ULDKGProdu { get; set; }


        public string BCLBL { get; set; }
        public string BCLSV420 { get; set; }

        public string BCLSV437 { get; set; }


        public string zuletztbearbeitetvon { get; set; }
        public string zuletztbearbeitetam { get; set; }
        public string istabgeschlossen { get; set; }
        public string istfreigegeben { get; set; }
        public string abgeschlossenvon { get; set; }
        public string abgeschlossenam { get; set; }

        public string freigegebenvon { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime schichtdatum { get; set; }
        public string schichtbeurteilung { get; set; }
        public string schichttyp { get; set; }
        public string erstelltam { get; set; }

        public string erstelltvon { get; set; }


    }
}
