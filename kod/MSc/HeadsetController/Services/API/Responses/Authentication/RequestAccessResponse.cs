using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Authentication
{
    public class RequestAccessResponse : IResult
    {
        public bool accessGranted { get; }
        public string message { get; }

        [JsonConstructor]
        private RequestAccessResponse(bool accessGranted, string message)
        {
            this.accessGranted = accessGranted;
            this.message = message;
        }
    }
}