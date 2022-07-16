using AulaWebDev.Dominio.Entidades;
using AulaWebDev.Dominio.Repositorios;
using AulaWebDev.Infra.Context;
using Microsoft.Extensions.Logging;

namespace AulaWebDev.Infra.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AulaWebDevDbContext _dbContext;
        private readonly ILogger<ClienteRepository> _logger;

        public ClienteRepository(AulaWebDevDbContext dbContext, ILogger<ClienteRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public Task<Cliente> CriarAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditarAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente?> ObterClientePorId(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Cliente>> ObterTodosClientes()
        {
            throw new NotImplementedException();
        }
    }
}
