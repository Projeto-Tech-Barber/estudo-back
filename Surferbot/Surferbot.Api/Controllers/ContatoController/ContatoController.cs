using Microsoft.AspNetCore.Mvc;
using Surferbot.Application.Dtos.ContatoDtos;
using Surferbot.Application.Interface.InterfaceContato;
using Surferbot.Core.Exceptions;

namespace Surferbot.Api.Controllers.ContatoController;

[ApiController]
[Route("api/[controller]")]
public class ContatoController : ControllerBase
{
    private readonly ILogger<ContatoController> _logger;
    private readonly IContatoService _service;

    public ContatoController(ILogger<ContatoController> logger, IContatoService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpPost]
    public IActionResult AdicionarContato([FromBody] ContatoDto contatoDto)
    {
        _service.CadastroContatos(contatoDto);
        return Created();
        
    }   
}
