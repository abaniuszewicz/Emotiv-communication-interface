using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Records
{
    public class StopRecordResponse : IResult
    {
        public RecordObject record { get; }
        public string sessionId { get; }

        [JsonConstructor]
        private StopRecordResponse(RecordObject record, string sessionId)
        {
            this.record = record;
            this.sessionId = sessionId;
        }
    }
}