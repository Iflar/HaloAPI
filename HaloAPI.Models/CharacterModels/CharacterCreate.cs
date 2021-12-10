using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.CharacterModels
{
    public class CharacterCreate
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Renown { get; set; }
        public int SpeciesId { get; set; }
        public int FactionId { get; set; }
    }
}
