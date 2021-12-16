using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Data
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public virtual Species Species { get; set; }

        [Required]
        [ForeignKey(nameof(Species))]
        public int SpeciesId { get; set; }

        public virtual Faction Faction { get; set; }

        [ForeignKey(nameof(Faction))]
        public int FactionId { get; set; }

        public string Description { get; set; }

        public string Renown { get; set; }
    }
}
