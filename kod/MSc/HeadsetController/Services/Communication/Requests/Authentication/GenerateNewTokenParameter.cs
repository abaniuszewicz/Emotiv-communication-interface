namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class GenerateNewTokenParameter
    {
        public string cortexToken { get; set; }
        public string clientId { get; set; }
        public string clientSecret { get; set; }

        public GenerateNewTokenParameter(string cortexToken, string clientId, string clientSecret)
        {
            this.cortexToken = cortexToken;
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }
    }
}