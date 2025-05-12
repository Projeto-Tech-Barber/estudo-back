namespace Surferbot.Core.Exceptions
{
    public class ErrorValidationException: Exception
    {
        public List<string> Errors { get; set; }
        public ErrorValidationException(List<string> errorMenssages)
        {
            Errors = errorMenssages;

        }
    }
}
