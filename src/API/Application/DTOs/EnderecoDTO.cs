using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Application.DTOs
{
    public class EnderecoDTO
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string EstadoSigla { get; set; }

        [Required]
        public string Cep { get; set; }
    }
}