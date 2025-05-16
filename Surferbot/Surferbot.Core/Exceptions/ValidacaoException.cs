namespace Surferbot.Core.Exceptions;

public class ValidacaoException : Exception
{
    public ValidacaoException(IEnumerable<string> erros) : base ("Erro de validação")
    {
        Erros = erros.ToList();
    }

    public List<string> Erros { get; }


}
