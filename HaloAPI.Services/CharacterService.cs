using HaloAPI.Data;
using HaloAPI.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Services
{
    public class CharacterService
    {
        public Species GetSpeciesById(int Id)
        {
            using (var ctx);
        }
        public bool CreateCharacter(CharacterCreate model)
        {
            var entity = new Character()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,

            };
            return false;
        }
    }
}
