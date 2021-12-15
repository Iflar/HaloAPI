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
                var entity = ctx.SpeciesList.Single(e => e.SpeciesId == Id);
                return
                    new Species
                    {
                        SpeciesId = entity.SpeciesId,
                        Lifespan = entity.Lifespan,
                        Height = entity.Height,
                        Origin = entity.Origin,
                        SpeciesName = entity.SpeciesName
                    };
            }
        }
        public Faction GetFactionById(int Id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Factions.Single(e => e.FactionId == Id);
                return
                    new Faction
                    {
                        FactionId = entity.FactionId,
                        FactionName = entity.FactionName,
                        Motto = entity.Motto,
                        Engagements = entity.Engagements,
                        YearActive = entity.YearActive
                    };
            }

        }
        public bool CreateCharacter(CharacterCreate model)
        {
            Species species = GetSpeciesById(model.SpeciesId);
            Faction faction = GetFactionById(model.FactionId);
            var entity = new Character()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                SpeciesId = species.SpeciesId,
                FactionId = faction.FactionId
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
