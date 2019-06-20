using System.Collections.Generic;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Records
{
    public class RecordObject
    {
        public string uuid { get; }
        public string applicationId { get; }
        public string title { get; }
        public string description { get; }
        public IEnumerable<string> tags { get; }
        public string startDatetime { get; }
        public string endDatetime { get; }
        public string licenseId { get; }
        public IEnumerable<string> licenseScope { get; }
        public IEnumerable<object> markers { get; }

        [JsonConstructor]
        private RecordObject(string uuid, string applicationId, string title, string description, IEnumerable<string> tags, string startDatetime, string endDatetime, string licenseId, IEnumerable<string> licenseScope, IEnumerable<object> markers)
        {
            this.uuid = uuid;
            this.applicationId = applicationId;
            this.title = title;
            this.description = description;
            this.tags = tags;
            this.startDatetime = startDatetime;
            this.endDatetime = endDatetime;
            this.licenseId = licenseId;
            this.licenseScope = licenseScope;
            this.markers = markers;
        }
    }
}
