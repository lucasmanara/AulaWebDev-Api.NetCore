using AulaWebDev.Dominio.DTOs;
using AulaWebDev.Dominio.Entidades;
using AulaWebDev.Dominio.Repositorios;
using AulaWebDev.Dominio.Validacoes;
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

        public async Task<ResultService> AlterarAsync(ClienteDto clienteDto)
        {
            if (clienteDto.Id == Guid.Empty)
                return ResultService.Fail<ClienteDto>("ID precisa ser informado");

            var result = await new ClienteDtoValidator().ValidateAsync(clienteDto);
            if (!result.IsValid)
                return ResultService.RequestError<ClienteDto>("Um ou mais erros foram encontrados", result);

            var clienteEditado = await _clienteRepository.EditarAsync(_mapper.Map<Cliente>(clienteDto));
            var clienteDtoEditado = _mapper.Map<ClienteDto>(clienteEditado);

            return ResultService.Ok(clienteDtoEditado);
        }

        public async Task<ResultService<ClienteDto>> CriarAsync(ClienteDto clienteDto)
        {
            if(clienteDto == null)
                return ResultService.Fail<ClienteDto>("Objeto nao pode ser nullo");

            var result = await new ClienteDtoValidator().ValidateAsync(clienteDto);
            if (!result.IsValid)
                return ResultService.RequestError<ClienteDto>("Um ou mais erros foram encontrados", result);

            var clientePersistido = await _clienteRepository.CriarAsync(_mapper.Map<Cliente>(clienteDto));
            var clienteDtoPersistido = _mapper.Map<ClienteDto>(clientePersistido);

            return ResultService.Ok(clienteDtoPersistido);
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
