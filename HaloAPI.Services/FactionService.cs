using HaloAPI.Data;
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
    }
}
