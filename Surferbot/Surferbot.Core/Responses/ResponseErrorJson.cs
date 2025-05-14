namespace Surferbot.Core.Responses
{
    public class ResponseErrorJson
    {
        public List<string> ErrorMenssages { get; set; }
        public ResponseErrorJson(string errorMessage)
        {
            ErrorMenssages = [errorMessage];
        }
        public ResponseErrorJson(List<string> errorMessage)
        {
            ErrorMenssages = errorMessage;
        }
    }
}
