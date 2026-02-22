using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Domain.Entities;
using src.Application.DTOs;
using Microsoft.AspNetCore.Identity;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        public static User user = new() { Email = "", SenhaCriptografada = "" };

        [HttpPost("register")]
        public ActionResult<User> Register(UserDTO request)
        {
            var senhaCriptografada = new PasswordHasher<User>()
                .HashPassword(user, request.Senha);


            user.Email = request.Email;
            user.SenhaCriptografada = senhaCriptografada;

            return Ok(user);
        }

        [HttpPost("login")]
        public ActionResult<string> Login(UserDTO request)
        {
            var result = new PasswordHasher<User>()
                .VerifyHashedPassword(user, user.SenhaCriptografada, request.Senha);

            if (result == PasswordVerificationResult.Failed || request.Email != user.Email)
                return BadRequest("Senha ou usuário incorretos");

            return Ok("Login bem-sucedido");
        }
    }   
}