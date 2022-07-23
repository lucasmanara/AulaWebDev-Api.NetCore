using AulaWebDev.Aplicacao.Services;
using AulaWebDev.Dominio.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AulaWebDev.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] PedidoDto pedidoDto)
        {
            var result = await _pedidoService.CriarAsync(pedidoDto);

            if (result.Sucesso)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
