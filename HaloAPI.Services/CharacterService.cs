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
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.SpeciesList.Single(e => e.Id == Id);
                return
                    new Species
                    {
                        Id = entity.Id,
                        Lifespan = entity.Lifespan,
                        Height = entity.Height,
                        Origin = entity.Origin,
                        SpeciesName = entity.SpeciesName
                    };
            }
        }
        public bool CreateCharacter(CharacterCreate model)
        {
            Species species = GetSpeciesById(model.SpeciesId);
            var entity = new Character()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                SpeciesId = species.Id,
                FactionId = model.FactionId
            };
            return false;
        }
    }
}
