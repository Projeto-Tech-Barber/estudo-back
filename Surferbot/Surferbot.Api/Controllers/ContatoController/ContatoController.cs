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
        try
        {
            _service.CadastroContatos(contatoDto);
            return Created();
        }
        catch (ValidacaoException ex)
        {
            _logger.LogWarning("Erro de validação ao cadastrar contata: {@Erros}", ex.Erros);
            return BadRequest(new { erro = ex.Erros });
        }
        catch (DomainException ex)
        {
            _logger.LogError(ex, "Algo deu errado ao criar a conta");
            return BadRequest(new { erro = ex.Message });
        }
        catch (ConexaoException ex)
        {
            _logger.LogError(ex, "Erro de conexão ao cadastrar contato.");
            return StatusCode(503, new { erro = ex.Message });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro inesperado ao cadastrar contato.");
            return StatusCode(500, new { erro = "Erro interno no servidor." });
        }
    }   
}
