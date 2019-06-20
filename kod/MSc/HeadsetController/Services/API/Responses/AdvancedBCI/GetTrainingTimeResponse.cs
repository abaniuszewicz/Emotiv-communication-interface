using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.AdvancedBCI
{
    public class GetTrainingTimeResponse : IResult
    {
        public int time { get; }
        public string detection { get; }

        [JsonConstructor]
        private GetTrainingTimeResponse(int time, string detection)
        {
            this.time = time;
            this.detection = detection;
        }
    }
}