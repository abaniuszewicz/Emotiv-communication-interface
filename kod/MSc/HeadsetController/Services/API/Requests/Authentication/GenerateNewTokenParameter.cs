namespace HeadsetController.Services.API.Requests.Authentication
{
    public class GenerateNewTokenParameter
    {
        public string cortexToken { get; }
        public string clientId { get; }
        public string clientSecret { get; }

        public GenerateNewTokenParameter(string cortexToken, string clientId, string clientSecret)
        {
            this.cortexToken = cortexToken;
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }
    }
}