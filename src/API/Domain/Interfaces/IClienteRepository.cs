using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_SaaS_Loja.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente?> GetByIdAsync(int id);
        Task<Cliente?> GetByCpfOuCnpjAsync(string cpfOuCnpj);
        Task AddClienteAsync(Cliente cliente);
        Task RemoveClienteAsync(Cliente cliente);
        Task UpdateClienteAsync(Cliente cliente);
        Task SaveChangesAsync();
    }
}