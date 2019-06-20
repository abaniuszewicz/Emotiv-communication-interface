namespace HeadsetController.Services.API.Requests.Authentication
{
    public class RequestAccessParameter
    {
        public string clientId { get; }
        public string clientSecret { get; }

        public RequestAccessParameter(string clientId, string clientSecret)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }
    }
}
