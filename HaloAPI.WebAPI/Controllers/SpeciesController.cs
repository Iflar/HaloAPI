using HaloAPI.Models.SpeciesModels;
using HaloAPI.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HaloAPI.WebAPI.Controllers
{
    [Authorize]
    public class SpeciesController : ApiController
    {
        private SpeciesService CreateSpeciesSerivce()
        {
            var speciesService = new SpeciesService();
            return speciesService;
        }

        public IHttpActionResult Get()
        {
            SpeciesService speciesService = CreateSpeciesSerivce();
            var species = speciesService.GetSpecies();
            return Ok(species);
        }

        public IHttpActionResult GetById(int id)
        {
            var service = CreateSpeciesSerivce();
            var species = service.GetSpeciesById(id);

            return Ok(species);
        }

        public IHttpActionResult GetBySpeciesId(int Id)
        {

        }

        public IHttpActionResult Post(SpeciesCreate species)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateSpeciesSerivce();

            if (!service.CreateSpecies(species))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(SpeciesEdit species)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateSpeciesSerivce();

            if (!service.UpdateSpecies(species))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateSpeciesSerivce();

            if (!service.DeleteSpecies(id))
                return InternalServerError();

            return Ok();
        }
    }
}
