﻿using HaloAPI.Models.CharacterModels;
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
    public class CharacterController : ApiController
    {
        private CharacterService CreateCharacterService()
        {
            var characterService = new CharacterService();
            return characterService;
        }

        public IHttpActionResult Get()
        {
            CharacterService characterService = CreateCharacterService();
            var characters = characterService.GetCharacters();
            return Ok(characters);
        }

        public IHttpActionResult Post(CharacterCreate character)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCharacterService();

            if (!service.CreateCharacter(character))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(CharacterEdit character)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCharacterService();

            if (!service.UpdateCharacter(character))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateCharacterService();

            if (!service.DeleteCharacter(id))
                return InternalServerError();

            return Ok();
        }
    }
}