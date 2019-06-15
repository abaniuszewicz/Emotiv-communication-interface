namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class HasAccessRightParameter
    {
        public string clientId { get; set; }
        public string clientSecret { get; set; }

        public HasAccessRightParameter(string clientId, string clientSecret)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }
    }
}