using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.SpeciesModels
{
    public class SpeciesCreate
    {
        
        public int Lifespan { get; set; }
        
        [MinLength(2, ErrorMessage ="Please enter a longer Origin name.")]
        [MaxLength(100, ErrorMessage ="Please enter a shorter Origin name.")]
        public string Origin { get; set; }
        
        [MinLength(2, ErrorMessage ="Please enter a longer Species name.")]
        [MaxLength(800, ErrorMessage ="Please enter a shorter Species name.")]
        public string SpeciesName { get; set; }

        public double Height { get; set; }
    }
}
