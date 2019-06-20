using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.BCI
{
    public class TrainingResponse : IResult
    {
        public string action { get; }
        public string status { get; }
        public string message { get; }

        [JsonConstructor]
        private TrainingResponse(string action, string status, string message)
        {
            this.action = action;
            this.status = status;
            this.message = message;
        }
    }
}