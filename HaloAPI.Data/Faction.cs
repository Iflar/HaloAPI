using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Data
{
    public class Faction
    {
        [Key]
        public int FactionId { get; set; }

        [Required]
        public string FactionName { get; set; }

        [Required]
        public string YearActive { get; set; }

        [Required]
        public string Motto { get; set; }

        [Required]
        public string Engagements { get; set; }
    }
}
