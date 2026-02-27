using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Domain.Entities;

namespace ERP_SaaS_Loja.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CpfOuCnpj { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public Endereco Endereco { get; private set; }

        private Cliente() { }

        public Cliente(string nome, string cpfOuCnpj, string email, string telefone, Endereco endereco)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome é obrigatório");

            if (string.IsNullOrWhiteSpace(cpfOuCnpj))
                throw new ArgumentException("CPF ou CNPJ é obrigatório");

            Nome = nome;
            CpfOuCnpj = cpfOuCnpj;
            Email = email;
            Telefone = telefone;
            Endereco = endereco ?? throw new ArgumentNullException(nameof(endereco));
        }

        public void AlterarEmail(string novoEmail)
        {
            if (string.IsNullOrWhiteSpace(novoEmail))
                throw new ArgumentException("Email inválido");

            Email = novoEmail;
        }


        public void AlterarTelefone(string novoTelefone)
        {
            if (string.IsNullOrWhiteSpace(novoTelefone))
                throw new ArgumentException("Telefone inválido");

            Telefone = novoTelefone;
        }

        public void AlterarEndereco(Endereco novoEndereco)
        {
            Endereco = novoEndereco ?? throw new ArgumentNullException(nameof(novoEndereco));
        }


        public void AlterarNome(string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
                throw new ArgumentException("Nome inválido");

            Nome = novoNome;
        }

        public void AlterarCpfOuCnpj(string novoCpfOuCnpj)
        {
            if (string.IsNullOrWhiteSpace(novoCpfOuCnpj))
                throw new ArgumentException("CPF ou CNPJ inválido");

            CpfOuCnpj = novoCpfOuCnpj;
        }




    }
}