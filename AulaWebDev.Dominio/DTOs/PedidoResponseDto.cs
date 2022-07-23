namespace AulaWebDev.Dominio.DTOs
{
    public class PedidoResponseDto
    {
        public Guid Id { get; set; }
        public ProdutoDto Produto { get; set; }
        public ClienteDto Cliente { get; set; }
    }
}
