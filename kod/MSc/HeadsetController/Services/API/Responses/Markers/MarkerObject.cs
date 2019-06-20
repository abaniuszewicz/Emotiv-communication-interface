using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Markers
{
    public class MarkerObject
    {
        public string uuid { get; }
        public string type { get; }
        public string value { get; }
        public string label { get; }
        public string port { get; }
        public string startDatetime { get; }
        public string endDatetime { get; }
        public object extras { get; }

        [JsonConstructor]
        private MarkerObject(string uuid, string type, string value, string label, string port, string startDatetime, string endDatetime, object extras)
        {
            this.uuid = uuid;
            this.type = type;
            this.value = value;
            this.label = label;
            this.port = port;
            this.startDatetime = startDatetime;
            this.endDatetime = endDatetime;
            this.extras = extras;
        }
    }
}