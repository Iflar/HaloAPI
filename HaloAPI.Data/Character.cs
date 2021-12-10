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
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [ForeignKey(nameof(Species))]
        public int SpeciesId { get; set; }

        [ForeignKey(nameof(Faction))]
        public int FactionId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Renown { get; set; }
    }
}
