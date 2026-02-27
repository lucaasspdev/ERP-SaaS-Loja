using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_SaaS_Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using src.Domain.Entities;

namespace API.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> User { get; set; }

        public DbSet<Cliente> Cliente { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>()
                .OwnsOne(c => c.Endereco);
        }

    }
}