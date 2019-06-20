using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Headsets
{
    public class ControlDeviceResponse : IResult
    {
        public string command { get; }
        public string message { get; }

        [JsonConstructor]
        private ControlDeviceResponse(string command, string message)
        {
            this.command = command;
            this.message = message;
        }
    }
}