using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Interfaces;
using API.Infrastructure.Data;
using ERP_SaaS_Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<Cliente?> GetByIdAsync(int id)
        {
            return _context.Cliente.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<Cliente?> GetByCpfOuCnpjAsync(string cpfOuCnpj)
        {
            return _context.Cliente.FirstOrDefaultAsync(c => c.CpfOuCnpj == cpfOuCnpj);
        }

        public async Task AddClienteAsync(Cliente cliente)
        {
            await _context.Cliente.AddAsync(cliente);
        }

        public async Task RemoveClienteAsync(Cliente cliente)
        {
            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            await _context.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}