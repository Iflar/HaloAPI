using HaloAPI.Models.FactionModels;
using HaloAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HaloAPI.WebAPI.Controllers
{
    [Authorize]
    public class FactionController : ApiController
    {
        private FactionService CreateFactionService()
        {
            var factionService = new FactionService();
            return factionService;
        }
        public IHttpActionResult Get()
        {
            FactionService factionService = CreateFactionService();
            var factions = factionService.GetFaction();
            return Ok(factions);
        }
        public IHttpActionResult Post(FactionCreate factions)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateFactionService();

            if (!service.CreateFaction(factions))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Put(FactionEdit faction)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateFactionService();

            if (!service.UpdateFaction(faction))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateFactionService();

            if (!service.DeleteFaction(id))
                return InternalServerError();

            return Ok();
        }
    }
}