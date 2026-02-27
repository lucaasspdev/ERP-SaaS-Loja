using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.Services;
using ERP_SaaS_Loja.Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ClienteController : ControllerBase
    {

        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarCliente(ClienteDTO clienteDTO)
        {
            try
            {
                var cliente = await _clienteService.AddClienteAsync(clienteDTO);
                return StatusCode(201, new
                {
                    cliente.Id,
                    cliente.Nome,
                    cliente.CpfOuCnpj,
                    message = "Cliente criado com sucesso"
                });
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao criar cliente: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClienteById(int id)
        {
            try
            {
                var cliente = await _clienteService.GetClienteByIdAsync(id);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao obter cliente: {ex.Message}");
            }
        }

        [HttpGet("cpfOuCnpj/{cpfOuCnpj}")]
        public async Task<IActionResult> GetClienteByCpfOuCnpjAsync(string cpfOuCnpj)
        {
            try
            {
                var cliente = await _clienteService.GetClienteByCpfOuCnpjAsync(cpfOuCnpj);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao obter cliente: {ex.Message}");
            }
        }
        

        [HttpPut]
        public async Task<IActionResult> UpdateCliente(int id, ClienteDTO clienteDTO)
        {
            try
            {
                await _clienteService.UpdateClienteAsync(id, clienteDTO);
                return Ok(new { message = "Cliente atualizado com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao atualizar cliente: {ex.Message}");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            try
            {
                await _clienteService.RemoveClienteAsync(id);
                return Ok(new { message = "Cliente deletado com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao deletar cliente: {ex.Message}");
            }
        }

    }
}