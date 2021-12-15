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
        //This is an update
        //Anotha one
        //Last one
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
        public bool UpdateSpecies(SpeciesEdit species)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .SpeciesList
                    .Single(e => e.SpeciesId == species.Id);

                entity.SpeciesName = species.SpeciesName;
                entity.Lifespan = species.Lifespan;
                entity.Origin = species.Origin;
                entity.Height = species.Height;

                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<SpeciesListItem> GetSpecies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                ctx.SpeciesList
                    .Select(
                    e =>
                    new SpeciesListItem
                    {

                    });
                        SpeciesId = e.SpeciesId,
                        Lifespan = e.Lifespan,
                        Origin = e.Origin,
                        SpeciesName = e.SpeciesName,
                        Height = e.Height
                    }
                );
                return query.ToArray();
            }
        }
        public bool DeleteSpecies(int speciesId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .SpeciesList
                    .Single(e => e.SpeciesId == speciesId);

                ctx.SpeciesList.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
