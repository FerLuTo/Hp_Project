using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Hp_Project.Models
{
    public class Character
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Gender { get; set; }
        [DisplayName("Date of Birth")]
        public string DateOfBirth { get; set; }
        public string Wizard { get; set; }
        

    }
}