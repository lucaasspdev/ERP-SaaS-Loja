using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace src.Application.DTOs
{
    public class UserDTO
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        
        [Required]
        [MinLength(6, ErrorMessage = "A senha deve conter pelo menos 6 caracteres.")]
        public required string Senha { get; set; }
    }
}