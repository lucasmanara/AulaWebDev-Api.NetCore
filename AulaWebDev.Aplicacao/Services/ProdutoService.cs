using AulaWebDev.Dominio.DTOs;
using AulaWebDev.Dominio.Entidades;
using AulaWebDev.Dominio.Repositorios;
using AulaWebDev.Dominio.Validacoes;
using AutoMapper;

namespace AulaWebDev.Aplicacao.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<ResultService<ProdutoDto>> CriarAsync(ProdutoDto produtoDto)
        {
            if (produtoDto == null)
                return ResultService.Fail<ProdutoDto>("Objeto nao pode ser nullo");

            var result = await new ProdutoDtoValidator().ValidateAsync(produtoDto);
            if (!result.IsValid)
                return ResultService.RequestError<ProdutoDto>("Um ou mais erros foram encontrados", result);

            var produtoPersistido = await _produtoRepository.CriarAsync(_mapper.Map<Produto>(produtoDto));
            var produtoDtoPersistido = _mapper.Map<ProdutoDto>(produtoPersistido);

            return ResultService.Ok(produtoDtoPersistido);
        }

        public async Task<ResultService> DeletarAsync(Guid produtoId)
        {
            if (produtoId == Guid.Empty)
                return ResultService.Fail<ProdutoDto>("Id do produto deve ser informado");

            var produto = await _produtoRepository.ObterPorIdAsync(produtoId);
            if (produto == null)
                return ResultService.Fail("Produto nao encontrado");

            if (await _produtoRepository.DeletarAsync(produto))
                return ResultService.Ok("Produto removido com sucesso");

            return ResultService.Fail("Ocorreu um erro ao remover o Produto");
        }

        public async Task<ResultService> AlterarAsync(ProdutoDto produtoDto)
        {
            if (produtoDto.Id == Guid.Empty)
                return ResultService.Fail<ProdutoDto>("ID precisa ser informado");

            var result = await new ProdutoDtoValidator().ValidateAsync(produtoDto);
            if (!result.IsValid)
                return ResultService.RequestError<ProdutoDto>("Um ou mais erros foram encontrados", result);

            var produto = await _produtoRepository.ObterPorIdAsync(produtoDto.Id);
            if (produto == null)
                return ResultService.Fail("Produto nao encontrado");

            //Mapeando propriedades informadas para edição, na entidade ja existente no banco!
            var produtoAtualizado = _mapper.Map(produtoDto, produto);

            if (await _produtoRepository.EditarAsync(produtoAtualizado))
                return ResultService.Ok("Produto editado com sucesso");

            return ResultService.Fail("Ocorreu um erro ao editar o Produto");
        }

        public async Task<ResultService> ObterPorIdAsync(Guid produtoId)
        {
            if (produtoId == Guid.Empty)
                return ResultService.Fail<ProdutoDto>("Id do Produto deve ser informado");

            var produto = await _produtoRepository.ObterPorIdAsync(produtoId);
            if (produto == null)
                return ResultService.Fail<ProdutoDto>("Produto nao encontrado");

            var produtoDto = _mapper.Map<ProdutoDto>(produto);
            return ResultService.Ok(produtoDto);
        }

        public async Task<ResultService<ICollection<ProdutoDto>>> ObterTodosAsync()
        {
            var produtos = await _produtoRepository.ObterTodosAsync();
            var produtosMapeados = _mapper.Map<ICollection<ProdutoDto>>(produtos);
            return ResultService.Ok(produtosMapeados);
        }
    }
}
