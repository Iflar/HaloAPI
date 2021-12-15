using HaloAPI.Data;
using HaloAPI.Models.SpeciesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Services
{
    public class SpeciesService
    {
        public bool CreateSpecies(SpeciesCreate species)
        {
            var entity =
                new Species()
                {
                    Lifespan = species.Lifespan,
                    Origin = species.Origin,
                    SpeciesName = species.SpeciesName,
                    Height = species.Height
                };
            using(var ctx = new ApplicationDbContext())
            {
                ctx.SpeciesList.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<SpeciesListItem> GetSpecies()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query =
                ctx.SpeciesList
                    .Select(
                    e =>
                    new SpeciesListItem
                    {
                        
                    })
            }
        }

    }
}
