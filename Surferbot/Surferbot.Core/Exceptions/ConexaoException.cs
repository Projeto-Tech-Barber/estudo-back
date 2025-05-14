namespace Surferbot.Core.Exceptions;

public class ConexaoException : Exception
{
    public ConexaoException(string message, Exception innerException = null)
        : base(message, innerException) { }
}