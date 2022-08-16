using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Hp_Project.Models
{
    public class Staff:Character
    {
        public string House { get; set; }
        public string Ancestry { get; set; }
        [DisplayName("Eye Colour")]
        public string EyeColour { get; set; }
        [DisplayName("Hair Colour")]
        public string HairColour { get; set; }
        public string Patronus { get; set; }
        public string Actor { get; set; }
    }
}