using Microsoft.AspNetCore.Mvc;
using Surferbot.Application.Modelos.Clientes;
using Surferbot.Application.UseCases.Clientes;


namespace Surferbot.Api.Controllers.Cadastro_Cliente
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController: ControllerBase
    {
        private readonly IClienteUseCase _clienteUseCase;
        public ClienteController(IClienteUseCase clienteUseCase)
        {
            _clienteUseCase = clienteUseCase;
        }
        [HttpPost]
        public IActionResult Criar([FromBody] CriarClienteDto request)
        {
            try
            {
                _clienteUseCase.Criar(request);
                return Created();
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var cliente = _clienteUseCase.Get(id);
                return Ok(cliente);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

