using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Markers
{
    public class UpdateMarkerResponse : IResult
    {
        public string recordId { get; }
        public string sessionId { get; }
        public MarkerObject marker { get; }

        [JsonConstructor]
        private UpdateMarkerResponse(string recordId, string sessionId, MarkerObject marker)
        {
            this.recordId = recordId;
            this.sessionId = sessionId;
            this.marker = marker;
        }
    }
}