namespace HeadsetController.Services.API.Requests.Authentication
{
    public class AuthorizeParameter
    {
        public string clientId { get; }
        public string clientSecret { get; }
        public string license { get; set; }
        public int? debit { get; set; }

        public AuthorizeParameter(string clientId, string clientSecret)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }
    }
}
