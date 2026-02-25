using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Domain.Entities;
using src.Application.DTOs;
using Microsoft.AspNetCore.Identity;
using API.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using API.Application.DTOs;
using API.Application.Services;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly TokenService _tokenService;
        public AuthController(UserService userService, TokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDTO request)
        {
            try
            {
                var user = await _userService.RegisterAsync(request);
                return StatusCode(201, new
                {
                    user.Id,
                    user.Email,
                    message = "Usuário registrado com sucesso"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO request)
        {
            try
            {
                await _userService.AlterarSenhaAsync(request);
                return Ok("Senha alterada com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDTO request)
        {
            try
            {
                var user = await _userService.LoginAsync(request);

                var token = _tokenService.GenerateToken(user);

                return StatusCode(200, new
                {
                    token,
                    user.Id,
                    user.Email,
                    message = "Login bem-sucedido"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("logout")]
        [Authorize]
        public async Task<ActionResult<string>> Logout()
        {
            return Ok("Logout bem-sucedido");
        }




    }
}