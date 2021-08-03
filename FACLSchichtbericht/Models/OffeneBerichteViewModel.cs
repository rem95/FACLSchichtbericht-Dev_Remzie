using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FACLSchichtbericht.Models
{
    public class OffeneBerichteViewModel
    {
        public BerichtBD420Model berichtBD420 { get; set; }
        public BerichtBD451Model berichtBD451 { get; set; }

        public BerichtBU320Model berichtBU320 { get; set; }

        public BerichtBU420Model berichtBU420 { get; set; }

    }
}
