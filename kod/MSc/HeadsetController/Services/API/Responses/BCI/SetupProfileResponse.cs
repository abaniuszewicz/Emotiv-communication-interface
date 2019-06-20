using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.BCI
{
    public class SetupProfileResponse : IResult
    {
        public string action { get; }
        public string name { get; }
        public string message { get; }

        [JsonConstructor]
        private SetupProfileResponse(string action, string name, string message)
        {
            this.action = action;
            this.name = name;
            this.message = message;
        }
    }
}