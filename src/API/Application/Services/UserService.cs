using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using src.Application.DTOs;
using src.Domain.Entities;

namespace API.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _repository;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(
            IUserRepository repository,
            IPasswordHasher<User> passwordHasher)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
        }

        public async Task<User> RegisterAsync(UserDTO request)
        {
            var existingUser = await _repository.GetByEmailAsync(request.Email);

            if (existingUser != null)
                throw new Exception($"Usuário já cadastrado com id {existingUser.Id}");

            var user = new User(request.Email, string.Empty);

            var senhaCriptografada =
                _passwordHasher.HashPassword(user, request.Senha);

            user.AlterarSenha(senhaCriptografada);

            await _repository.AddAsync(user);
            await _repository.SaveChangesAsync();

            return user;
        }

        public async Task<User> LoginAsync(UserDTO request)
        {
            var user = await _repository.GetByEmailAsync(request.Email);

            if (user == null)
                throw new Exception("Usuário não encontrado");

            var resultado = _passwordHasher.VerifyHashedPassword(
                user,
                user.SenhaCriptografada,
                request.Senha);

            if (resultado == PasswordVerificationResult.Failed)
                throw new Exception("Senha incorreta");

            return user;
        }



        public async Task AlterarSenhaAsync(ChangePasswordDTO request)
        {
            var user = await _repository.GetByEmailAsync(request.Email);

            if (user == null)
                throw new Exception("Usuário não encontrado");

            var resultado = _passwordHasher.VerifyHashedPassword(
                user,
                user.SenhaCriptografada,
                request.SenhaAtual);

            if (resultado == PasswordVerificationResult.Failed)
                throw new Exception("Senha atual incorreta");

            if (request.SenhaAtual == request.NovaSenha)
                throw new Exception("Nova senha deve ser diferente");

            var novaSenhaCriptografada =
                _passwordHasher.HashPassword(user, request.NovaSenha);

            user.AlterarSenha(novaSenhaCriptografada);

            await _repository.SaveChangesAsync();
        }
    }
}