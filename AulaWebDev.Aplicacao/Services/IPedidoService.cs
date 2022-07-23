﻿using AulaWebDev.Dominio.DTOs;

namespace AulaWebDev.Aplicacao.Services
{
    public interface IPedidoService
    {
        Task<ResultService<PedidoResponseDto>> CriarAsync(PedidoDto pedidoDto);
        Task<ResultService<ICollection<PedidoResponseDto>>> ObterTodosAsync();
        Task<ResultService<PedidoResponseDto>> ObterPorIdAsync();
        Task<ResultService> DeletarAsync(Guid pedidoId);
    }
}
