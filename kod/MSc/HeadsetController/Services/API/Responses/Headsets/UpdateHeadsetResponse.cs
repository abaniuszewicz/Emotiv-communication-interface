using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Headsets
{
    public class UpdateHeadsetResponse : IResult
    {
        public string headsetId { get; }
        public string message { get; }

        [JsonConstructor]
        private UpdateHeadsetResponse(string headsetId, string message)
        {
            this.headsetId = headsetId;
            this.message = message;
        }
    }
}