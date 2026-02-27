using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace API.Application.DTOs
{
    public class IbgeDTO
    {
        private readonly IMemoryCache _cache;
        public class EstadoDto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Sigla { get; set; }
        }

        public class CidadeDto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}