using HaloAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HaloAPI.WebAPI.Controllers
{
    [Authorize]
    public class FactionController : ApiController
    {
        private FactionService CreateFactionService()
        {
            var factionService = CreateFactionService();
            return factionService;
        }
    }
}