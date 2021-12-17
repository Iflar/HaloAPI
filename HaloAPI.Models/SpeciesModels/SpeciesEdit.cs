using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.SpeciesModels
{
    public class SpeciesEdit
    {
        public int Id { get; set; }

        public string SpeciesName { get; set; }

        public int Lifespan { get; set; }

        public string Origin { get; set; }

        public double Height { get; set; }

        public string NickName { get; set; }
    }
}
