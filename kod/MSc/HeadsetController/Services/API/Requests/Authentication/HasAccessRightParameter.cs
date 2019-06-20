namespace HeadsetController.Services.API.Requests.Authentication
{
    public class HasAccessRightParameter
    {
        public string clientId { get; }
        public string clientSecret { get; }

        public HasAccessRightParameter(string clientId, string clientSecret)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }
    }
}