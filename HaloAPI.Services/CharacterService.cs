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
        private readonly Guid _userId;

        public CharacterService(Guid userId)
        {
            _userId = userId;
        }
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

        //POST
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
        //GET
        public IEnumerable<CharacterListItem> GetCharacters()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Characters.Select(
                    e =>
                    new CharacterListItem
                    {
                        CharacterId = e.CharacterId,
                        FirstName = e.FirstName,
                        LastName = e.LastName
                    }
                );
                return query.ToArray();
            }
        }
        //GET
        public CharacterDetail GetCharacterByID(int Id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Characters.Single(e => e.CharacterId == Id);
                Species species = GetSpeciesById(entity.SpeciesId);
                Faction faction = GetFactionById(entity.FactionId);

                return
                    new CharacterDetail
                    {
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        CharacterId = entity.CharacterId,
                        Renown = entity.Renown,
                        Species = species.SpeciesName,
                        Faction = faction.FactionName,
                        SpeciesId = entity.SpeciesId,
                        FactionId = entity.FactionId
                    };
            }
        }
        //PUT
        public bool UpdateCharacter(CharacterEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Characters.Single(e => e.CharacterId == model.CharacterId);

                Faction faction = GetFactionById(entity.FactionId);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Description = model.Description;
                entity.Renown = model.Renown;
                entity.FactionId = faction.FactionId;

                return ctx.SaveChanges() == 1;
            }
        }
        //DELETE
        public bool DeleteCharacter(int characterId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Characters.Single(e => e.CharacterId == characterId);
                ctx.Characters.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public Species GetSpeciesByCharacterId(int id)
        {
            var character = GetCharacterByID(id);

            int speciesId = character.SpeciesId;

            Species species = GetSpeciesById(speciesId);

            return species;
        }

        public Faction GetFactionByCharacterId(int id)
        {
            var character = GetCharacterByID(id);

            int factionId = character.FactionId;

            Faction faction = GetFactionById(factionId);

            return faction;
        }
    }
}
