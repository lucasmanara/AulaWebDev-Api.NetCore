using AulaWebDev.Dominio.DTOs;

namespace AulaWebDev.Aplicacao.Services
{
    public interface IProdutoService
    {
        Task<ResultService<ProdutoDto>> CriarAsync(ProdutoDto produtoDto);
        Task<ResultService> AlterarAsync(ProdutoDto produtoDto);
        Task<ResultService> DeletarAsync(Guid produtoId);
        Task<ResultService> ObterPorIdAsync(Guid produtoId);
        Task<ResultService<ICollection<ProdutoDto>>> ObterTodosAsync();
    }
}
