using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Surferbot.Application.Modelos;
using Surferbot.Application.Modelos.Clientes;
using Surferbot.Application.UseCases.Clientes;
using Surferbot.Core.Exceptions;


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
            _clienteUseCase.Criar(request);
            return Created();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        { 
            var cliente = _clienteUseCase.Get(id);
            return Ok(cliente);
        }
    }
}

