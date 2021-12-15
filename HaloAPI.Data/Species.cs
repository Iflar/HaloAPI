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
        public int SpeciesId { get; set; }
        
        public int Lifespan { get; set; }
       
        public string Origin { get; set; }

        [Required]
        public string SpeciesName { get; set; }
        
        public double Height { get; set; }
    }
}
