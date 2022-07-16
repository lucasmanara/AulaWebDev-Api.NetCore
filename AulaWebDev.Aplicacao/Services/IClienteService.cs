using AulaWebDev.Dominio.DTOs;

namespace AulaWebDev.Aplicacao.Services
{
    public interface IClienteService
    {
        Task<ResultService<ClienteDto>> CriarAsync(ClienteDto clienteDto);
        Task<ResultService> AlterarAsync(Guid clienteId, ClienteDto clienteDto);
        Task<ResultService<ClienteDto>> ObterPorIdAsync(Guid clienteId);
        Task<ResultService<ICollection<ClienteDto>>> ObterTodosAsync();
        Task<ResultService> DeletarAsync(Guid clienteId);
    }
}
