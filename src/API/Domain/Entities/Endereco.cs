using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Domain.Entities
{

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