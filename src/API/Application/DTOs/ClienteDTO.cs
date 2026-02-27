using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using API.Application.DTOs;
using src.Domain.Entities;

namespace ERP_SaaS_Loja.Application.DTOs
{
    public class ClienteDTO
    {

        [JsonIgnore]
        public int Id { get; }
        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(14, MinimumLength = 11)]
        public string CpfOuCnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        [Required]
        public EnderecoDTO Endereco { get; set; }
    }
}