using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Authentication
{
    public class HasAccessRightResponse : IResult
    {
        public bool accessGranted { get; }
        public string message { get; }

        [JsonConstructor]
        private HasAccessRightResponse(bool accessGranted, string message)
        {
            this.accessGranted = accessGranted;
            this.message = message;
        }
    }
}