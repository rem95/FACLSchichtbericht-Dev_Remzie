using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class OverviewModel
    {
        [Key]
        public int ID { get; set; }


        public string HDO { get; set; }
        public string SchichtleiterPT { get; set; }
        public string SchichtleiterLF { get; set; }

        //#########################Personal aus den Bereichen###############################
        public int? DutymanagerSoll { get; set; }
        public int? DutymanagerIst { get; set; }
        public int? DutymanagerKrank { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? DutymanagerZusatz { get; set; }



        public int? BDSupervisorSoll { get; set; }
        public int? BDSupervisorIst { get; set; }

        public int? BDSupervisorKrank { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BDSupervisorZusatz { get; set; }

        public int? BDCheckerSoll { get; set; }
        public int? BDCheckerIst { get; set; }
        public int? BDCheckerKrank { get; set; }
        [Column(TypeName = "decimal(18, 3)")]

        public decimal? BDCheckerZusatz { get; set; }

        public int? BDAufbauerSoll { get; set; }
        public int? BDAufbauerIst { get; set; }
        public int? BDAufbauerKrank { get; set; }
        [Column(TypeName = "decimal(18, 3)")]

        public decimal? BDAufbauerZusatz { get; set; }

        public int? BDAbfertigerSoll { get; set; }
        public int? BDAbfertigerIst { get; set; }
        public int? BDAbfertigerKrank { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BDAbfertigerZusatz { get; set; }

        public int? BUSupervisorSoll { get; set; }
        public int? BUSupervisorIst { get; set; }
        public int? BUSupervisorKrank { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BUSupervisorZusatz { get; set; }

        public int? BUTeamleadSoll { get; set; }
        public int? BUTeamleadIst { get; set; }
        public int? BUTeamleadKrank { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BUTeamleadZusatz { get; set; }

        public int? BUPalettiererSoll { get; set; }
        public int? BUPalettiererIst { get; set; }
        public int? BUPalettiererKrank { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BUPalettiererZusatz { get; set; }

        public int? BUAbfertigerSoll { get; set; }
        public int? BUAbfertigerIst { get; set; }
        public int? BUAbfertigerKrank { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BUAbfertigerZusatz { get; set; }

       
        //##########################Scanner##############################

        public int? LeihscannerBD420 { get; set; }
        public int? LeihstaplerBD420 { get; set; }

        public int? CDSstandardBD420 { get; set; }

        public int? CDSdgrBD420 { get; set; }
        public string ArbeitsunfallBD420 { get; set; }

        public int? LeihscannerBD451 { get; set; }
        public int? LeihstaplerBD451 { get; set; }

        public int? CDSstandardBD451 { get; set; }

        public int? CDSdgrBD451 { get; set; }
        public string ArbeitsunfallBD451 { get; set; }

        public int? LeihscannerBU320 { get; set; }
        public int? LeihstaplerBU320 { get; set; }

        public int? CDSstandardBU320 { get; set; }

        public int? CDSdgrBU320 { get; set; }
        public string ArbeitsunfallBU320 { get; set; }

        public int? LeihscannerBU420 { get; set; }
        public int? LeihstaplerBU420 { get; set; }
        public int? CDSstandardBU420 { get; set; }
        public int? CDSdgrBU420 { get; set; }
        public string ArbeitsunfallBU420 { get; set; }

        public int? LeihscannerBD437 { get; set; }
        public int? LeihstaplerBD437 { get; set; }
        public int? CDSstandardBD437 { get; set; }
        public int? CDSdgrBD437 { get; set; }
        public string ArbeitsunfallBD437 { get; set; }

        public int? LeihscannerBU437 { get; set; }
        public int? LeihstaplerBU437 { get; set; }
        public int? CDSstandardBU437 { get; set; }
        public int? CDSdgrBU437 { get; set; }
        public string ArbeitsunfallBU437 { get; set; }

        //#########################PRODUKTIVITÄT###############################
        //BD420
        public int? BD420ULDMengeMenge { get; set; }

        public int? BD420ULDKGMenge { get; set; }

        public int? BD420BULKMengeMenge { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD420ULDMengeStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD420ULDKGStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD420BulkMengeStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD420ULDMengeProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD420ULDKGProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD420BulkMengeProdu { get; set; }


        //BD451
        public int? BD451ULDMengeMenge { get; set; }

        public int? BD451ULDKGMenge { get; set; }


        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD451ULDMengeStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD451ULDKGStunden { get; set; }


        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD451ULDMengeProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD451ULDKGProdu { get; set; }

        //BU320
        public int? BU320AKHMengeMenge { get; set; }

        public int? BU320AKHKGMenge { get; set; }

        public int? BU320BellyMengeMenge { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU320AKHMengeStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU320AKHKGStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU320BellyMengeStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU320AKHMengeProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU320AKHKGProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU320BellyMengeProdu { get; set; }


        //BU420
        public int? BU420ULDMengeMenge { get; set; }

        public int? BU420ULDKGMenge { get; set; }


        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU420ULDMengeStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU420ULDKGStunden { get; set; }


        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU420ULDMengeProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU420ULDKGProdu { get; set; }


        //BU437
        public int? BU437ULDMengeMenge { get; set; }

        public int? BU437ULDKGMenge { get; set; }


        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU437ULDMengeStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU437ULDKGStunden { get; set; }


        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU437ULDMengeProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BU437ULDKGProdu { get; set; }


        //BD437
        public int? BD437ULDMengeMenge { get; set; }

        public int? BD437ULDKGMenge { get; set; }


        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD437ULDMengeStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD437ULDKGStunden { get; set; }


        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD437ULDMengeProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? BD437ULDKGProdu { get; set; }

        //Transport
        public int? TransportHRLMenge { get; set; }

        public int? TransportDIRMenge { get; set; }

        public int? TransportQuerMenge { get; set; }

        public int? TransportPerkoMenge { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TransportHRLStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TransportDIRStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TransportQuerStunden { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TransportPerkoStunden { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TransportHRLProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TransportDIRProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TransportQuerProdu { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TransportPerkoProdu { get; set; }


        //Metadaten
        public string zuletztbearbeitetvon { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? zuletztbearbeitetam { get; set; }
        public string istabgeschlossen { get; set; }
        public string istfreigegeben { get; set; }
        public string abgeschlossenvon { get; set; }
        public string freigegebenvon { get; set; }

        public string schichttyp { get; set; }
        public int schichttyp_ID { get; set; }
        public string schichtbeurteilung { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? erstelltam { get; set; }
        
        public string erstelltvon { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? abgeschlossenam { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? freigegebenam { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? overviewdatum { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? berichtdatum { get; set; }

    }
}
