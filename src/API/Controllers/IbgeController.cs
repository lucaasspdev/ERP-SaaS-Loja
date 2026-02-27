using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.Interfaces;
using API.Application.Services;
using Microsoft.AspNetCore.Mvc;
using static API.Application.DTOs.IbgeDTO;

namespace API.Controllers
{
    [ApiController]
    [Route("api/localidades")]
    public class LocalidadesController : ControllerBase
    {
        private readonly ILocalidadeService _localidadeService;

        public LocalidadesController(ILocalidadeService localidadeService)
        {
            _localidadeService = localidadeService;
        }

        [HttpGet("estados")]
        public async Task<IActionResult> GetEstados()
        {
            var estados = await _localidadeService.ObterEstadosAsync();
            return Ok(estados);
        }

        [HttpGet("estados/{id}/cidades")]
        public async Task<IActionResult> GetCidades(int id)
        {
            var cidades = await _localidadeService.ObterCidadesPorEstadoAsync(id);
            return Ok(cidades);
        }
    }
}