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

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        public static User user = new() { Email = "", SenhaCriptografada = "" };

        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDTO request)
        {
            // Verifica se já existe no banco
            var existingUser = await _context.User
                .FirstOrDefaultAsync(u => u.Email == request.Email);

            if (existingUser != null)
                return BadRequest("Usuário já cadastrado com o id: " + existingUser.Id);

            var user = new User();

            var senhaCriptografada = new PasswordHasher<User>()
                .HashPassword(user, request.Senha);

            user.Email = request.Email;
            user.SenhaCriptografada = senhaCriptografada;

            _context.User.Add(user);

            await _context.SaveChangesAsync();

            return StatusCode(201, new { user.Id, user.Email, message = "Usuário registrado com sucesso" });
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDTO request)
        {

            var user = await _context.User.FirstOrDefaultAsync(u => u.Email == request.Email);

            if (user == null)
                return BadRequest("Usuário não encontrado");

            var result = new PasswordHasher<User>()
                .VerifyHashedPassword(user, user.SenhaCriptografada, request.Senha);

            if (result == PasswordVerificationResult.Failed || request.Email != user.Email)
                return BadRequest("Senha ou usuário incorretos");

            return Ok("Login bem-sucedido");
        }
    }
}