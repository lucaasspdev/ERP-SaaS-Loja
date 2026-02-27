using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static API.Application.DTOs.IbgeDTO;

namespace API.Application.Interfaces
{
    public interface ILocalidadeService
    {
        Task<IEnumerable<EstadoDto>> ObterEstadosAsync();
        Task<IEnumerable<CidadeDto>> ObterCidadesPorEstadoAsync(int estadoId);
    }
}
