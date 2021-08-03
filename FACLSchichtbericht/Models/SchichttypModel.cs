using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class SchichttypModel
    {
        [Key]
        public int ID { get; set; }

        public string Bezeichnung { get; set; }

    }
}
