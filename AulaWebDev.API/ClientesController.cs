using AulaWebDev.Aplicacao.Services;
using Microsoft.AspNetCore.Mvc;

namespace AulaWebDev.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _clienteService.ObterTodosAsync();
            if (result.Sucesso)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
