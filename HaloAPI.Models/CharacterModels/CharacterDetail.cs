using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.CharacterModels
{
    public class CharacterDetail
    {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Renown { get; set; }
        public string Species { get; set; }
        public string Faction { get; set; }
        public int SpeciesId { get; set; }
        public int FactionId { get; set; }
    }
}
