using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.SpeciesModels
{
    public class SpeciesDetail
    {
        public int Id { get; set; }

        public int Lifespan { get; set; }

        public string Origin { get; set; }

        public string SpeciesName { get; set; }

        public double Height { get; set; }
    }
}
