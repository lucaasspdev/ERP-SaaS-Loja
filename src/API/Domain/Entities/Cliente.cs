using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Domain.Entities;

namespace ERP_SaaS_Loja.Domain.Entities
{
    public class Cliente
    {
        public int id;
        public string nome;
        public string cpfOuCnpj;
        public string email;
        public string telefone;
        public Endereco endereco;


        public Cliente(int id, string nome, string cpfOuCnpj, string email, string telefone, Endereco endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cpfOuCnpj = cpfOuCnpj;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
        }
    }
}