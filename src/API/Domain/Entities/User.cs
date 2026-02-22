using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Domain.Entities
{
    public class User
    {
        public string email { get; set; }
        public string senhaCriptografada { get; set; }
    }
}