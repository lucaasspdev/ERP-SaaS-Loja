using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Application.DTOs
{
    public class ChangePasswordDTO
    {

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string SenhaAtual { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "A Nova senha deve conter pelo menos 6 caracteres.")]
        public required string NovaSenha { get; set; }
    }
}