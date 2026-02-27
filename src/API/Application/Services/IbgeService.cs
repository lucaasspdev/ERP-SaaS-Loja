using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.Interfaces;
using static API.Application.DTOs.IbgeDTO;

namespace API.Application.Services
{
    public class IbgeService : ILocalidadeService
    {
        private readonly HttpClient _httpClient;

        public IbgeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<EstadoDto>> ObterEstadosAsync()
        {
            var response = await _httpClient
                .GetFromJsonAsync<IEnumerable<EstadoDto>>(
                    "https://servicodados.ibge.gov.br/api/v1/localidades/estados?orderBy=nome");

            return response ?? Enumerable.Empty<EstadoDto>();
        }

        public async Task<IEnumerable<CidadeDto>> ObterCidadesPorEstadoAsync(int estadoId)
        {
            var response = await _httpClient
                .GetFromJsonAsync<IEnumerable<CidadeDto>>(
                    $"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{estadoId}/municipios");

            return response ?? Enumerable.Empty<CidadeDto>();
        }
    }
}
