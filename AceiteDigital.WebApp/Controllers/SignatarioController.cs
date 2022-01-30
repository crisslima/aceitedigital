﻿using AceiteDigital.Application.Documentos.Queries;
using AceiteDigital.Application.Signatarios.Commands.CriarSignatario;
using Microsoft.AspNetCore.Mvc;

namespace AceiteDigital.WebApp.Controllers
{
    public class SignatarioController : ApiController
    {

        [HttpGet]
        public async Task<IActionResult> GetAsync(
            [FromQuery] GetSignatariosQuery query)
        {
            var result = await Mediator.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CriarSignatarioCommand command)
        {
            var result = await Mediator.Send(command);

            return Created($"id={result.Id}", result);
        }
    }
}
