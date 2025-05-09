namespace Surferbot.Errors
{
    public class ApiException : Exception
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public string ErrorDetails { get; set; }

        public ApiException(string statusCode, string message, string errorDetails = null) 
            : base(message)
        {
            StatusCode = statusCode;
            Message = message;
            ErrorDetails = errorDetails;
        }
    }
}