using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Domain.Entities
{

    public class Endereco
    {
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string EstadoSigla { get; private set; }
        public string Cep { get; private set; }

        private Endereco() { }

        public Endereco(string rua, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {

            if (string.IsNullOrWhiteSpace(cep))
                throw new ArgumentException("CEP é obrigatório");

            if (string.IsNullOrWhiteSpace(estado))
                throw new ArgumentException("Estado é obrigatório");

            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            EstadoSigla = estado;
            Cep = cep;
        }
    }

}