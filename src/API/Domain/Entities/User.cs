using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Domain.Entities
{
    public class User
    {
        public required string Email { get; set; }
        public required string SenhaCriptografada { get; set; }
    }
}