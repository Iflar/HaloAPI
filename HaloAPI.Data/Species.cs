using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Data
{
    public class Species
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Lifespan { get; set; }

        [Required]
        public string Origin { get; set; }

        [Required]
        public string SpeciesName { get; set; }

        [Required]
        public int Height { get; set; }
    }
}
