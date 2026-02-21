using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


        public class Endereco
        {
            public string rua;
            public string numero;
            public string complemento;
            public string bairro;
            public string cidade;
            public string estado;
            public string cep;

            public Endereco(string rua, string numero, string complemento, string bairro, string cidade, string estado, string cep)
            {
                this.rua = rua;
                this.numero = numero;
                this.complemento = complemento;
                this.bairro = bairro;
                this.cidade = cidade;
                this.estado = estado;
                this.cep = cep;
            }
        }

    }
}