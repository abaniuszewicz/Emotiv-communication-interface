using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Records
{
    public class QueryRecordsResponse : IResult
    {
        public string applicationId { get; }
        public string licenseId { get; }
        public string keyword { get; }
        public object startDatetime { get; }
        public object modifiedDatetime { get; }
        public object duration { get; }

        [JsonConstructor]
        private QueryRecordsResponse(string applicationId, string licenseId, string keyword, object startDatetime, object modifiedDatetime, object duration)
        {
            this.applicationId = applicationId;
            this.licenseId = licenseId;
            this.keyword = keyword;
            this.startDatetime = startDatetime;
            this.modifiedDatetime = modifiedDatetime;
            this.duration = duration;
        }
    }
}