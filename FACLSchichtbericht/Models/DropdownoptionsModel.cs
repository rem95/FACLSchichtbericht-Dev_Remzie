using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class DropdownoptionsModel
    {
        [Key]
        public int ID { get; set; }

        public int value { get; set; }

        public string Selectbezeichnung { get; set; }

        public string Optionbezeichnung { get; set; }

    }
}
