using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.CharacterModels
{
    public class CharacterEdit
    {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FactionId { get; set; }
        public string Description { get; set; }
        public string Renown { get; set; }
    }
}
