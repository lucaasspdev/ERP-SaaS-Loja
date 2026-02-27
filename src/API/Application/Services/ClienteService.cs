using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Interfaces;
using ERP_SaaS_Loja.Application.DTOs;
using ERP_SaaS_Loja.Domain.Entities;
using src.Domain.Entities;

namespace API.Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        public async Task<Cliente> AddClienteAsync(ClienteDTO clienteDTO)
        {
            if (clienteDTO == null)
                throw new ArgumentNullException(nameof(clienteDTO));

            var existingCliente = await _clienteRepository.GetByCpfOuCnpjAsync(clienteDTO.CpfOuCnpj);

            if (existingCliente != null)
                throw new ArgumentException("Cliente já cadastrado.");

            var endereco = new Endereco(
                clienteDTO.Endereco.Rua,
                clienteDTO.Endereco.Numero,
                clienteDTO.Endereco.Complemento,
                clienteDTO.Endereco.Bairro,
                clienteDTO.Endereco.Cidade,
                clienteDTO.Endereco.EstadoSigla,
                clienteDTO.Endereco.Cep
            );

            var cliente = new Cliente(clienteDTO.Nome, clienteDTO.CpfOuCnpj, clienteDTO.Email, clienteDTO.Telefone, endereco);

            await _clienteRepository.AddClienteAsync(cliente);
            await _clienteRepository.SaveChangesAsync();

            return cliente;
        }

        public async Task RemoveClienteAsync(int id)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);

            if (cliente == null)
                throw new ArgumentException("Cliente não encontrado.");

            await _clienteRepository.RemoveClienteAsync(cliente);
        }


        public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);

            if (cliente == null)
                throw new ArgumentException("Cliente não encontrado.");

            return cliente;
        }

        public async Task<Cliente> GetClienteByCpfOuCnpjAsync(string cpfOuCnpj)
        {
            var cliente = await _clienteRepository.GetByCpfOuCnpjAsync(cpfOuCnpj);

            if (cliente == null)
                throw new ArgumentException("Cliente não encontrado.");

            return cliente;
        }

        public async Task UpdateClienteAsync(int id, ClienteDTO clienteDTO)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);

            if (cliente == null)
                throw new ArgumentException("Cliente não encontrado.");

            cliente.AlterarNome(clienteDTO.Nome);
            cliente.AlterarEmail(clienteDTO.Email);
            cliente.AlterarTelefone(clienteDTO.Telefone);

            var endereco = new Endereco(
                clienteDTO.Endereco.Rua,
                clienteDTO.Endereco.Numero,
                clienteDTO.Endereco.Complemento,
                clienteDTO.Endereco.Bairro,
                clienteDTO.Endereco.Cidade,
                clienteDTO.Endereco.EstadoSigla,
                clienteDTO.Endereco.Cep
            );

            cliente.AlterarEndereco(endereco);

            await _clienteRepository.UpdateClienteAsync(cliente);
        }
    }
}
