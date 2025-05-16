using Surferbot.Application.Dtos.ContatoDtos;

namespace Surferbot.Application.Interface.InterfaceContato;

public interface IContatoService
{
    void CadastroContatos(ContatoDto contatoDto);
}
