using AulaWebDev.Dominio.Entidades;

namespace AulaWebDev.Dominio.Repositorios
{
    public interface IClienteRepository
    {
        Task<Cliente> CriarAsync(Cliente cliente);
        Task<bool> DeletarAsync(Cliente cliente);
        Task<bool> EditarAsync(Cliente cliente);
        Task<Cliente?> ObterClientePorId(Guid clienteId);
        Task<ICollection<Cliente>> ObterTodosClientes();
    }
}
