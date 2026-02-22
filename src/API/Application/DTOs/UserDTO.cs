using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Application.DTOs
{
    public class UserDTO
    {
        public required string Email { get; set; }
        public required string Senha { get; set; }
    }
}