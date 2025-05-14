namespace Surferbot.Core.Exceptions;

public class DomainException : Exception
{
    public DomainException(string messagem) : base(messagem) { }

    public DomainException(string message, Exception innerException) : base(message, innerException) { }
}
