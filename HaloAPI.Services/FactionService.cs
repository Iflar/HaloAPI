using HaloAPI.Data;
using HaloAPI.Models.CharacterModels;
using HaloAPI.Models.FactionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Services
{
    public class FactionService
    {
        public bool CreateFaction(FactionCreate model)
        {
            var entity =
                new Faction()
                {
                    FactionName = model.FactionName,
                    Motto = model.Motto,
                    YearActive = model.YearActive,
                    Engagements = model.Engagements
                };
            
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Factions.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public Faction GetFactionById(int Id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Factions
                    .Single(e => e.FactionId == Id);
                return
                    new Faction
                    {
                        FactionId = entity.FactionId,
                        FactionName = entity.FactionName,
                        YearActive = entity.YearActive,
                        Motto = entity.Motto,
                        Engagements = entity.Engagements
                    };
            }
        }
        public IEnumerable<CharacterListItem> GetCharacterByFactionName(string factionName)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Characters
                    .Where(e => e.Faction.FactionName == factionName)
                    .Select(
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
        public IEnumerable<FactionListItem> GetFaction()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Factions
                        .Select(
                        e =>
                    new FactionListItem
                    {
                        FactionId = e.FactionId,
                        FactionName = e.FactionName,
                        YearActive = e.YearActive,
                        Motto = e.Motto,
                        Engagements = e.Engagements
                    }
                );
                return query.ToArray();
            }    
        }
        public bool UpdateFaction(FactionEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Factions
                    .Single(e => e.FactionId == model.FactionId);

                entity.FactionId = model.FactionId;
                entity.FactionName = model.FactionName;
                entity.Motto = model.Motto;

                return ctx.SaveChanges() == 1;

            }
        }
        public bool DeleteFaction(int factionId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                     ctx
                    .Factions
                    .Single(e => e.FactionId == factionId);
                ctx.Factions.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
