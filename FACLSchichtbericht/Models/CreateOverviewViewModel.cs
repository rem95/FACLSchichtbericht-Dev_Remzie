using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class CreateOverviewViewModel
    {

        public string istabgeschlossen { get; set; }
        public string istfreigegeben { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime berichtdatum { get; set; }
        public string schichttyp { get; set; }
        public int? schichttyp_ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime erstelltam { get; set; }

        public string erstelltvon { get; set; }


    }
}
