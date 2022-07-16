using AulaWebDev.Dominio.DTOs;
using AulaWebDev.Dominio.Repositorios;
using AutoMapper;

namespace AulaWebDev.Aplicacao.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ResultService> AlterarAsync(Guid clienteId, ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultService<ClienteDto>> CriarAsync(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultService> DeletarAsync(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultService<ClienteDto>> ObterPorIdAsync(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultService<ICollection<ClienteDto>>> ObterTodosAsync()
        {
            var clientes = await _clienteRepository.ObterTodosClientesAsync();
            var clientesMapeados = _mapper.Map<ICollection<ClienteDto>>(clientes);
            return ResultService.Ok(clientesMapeados);
        }
    }
}
