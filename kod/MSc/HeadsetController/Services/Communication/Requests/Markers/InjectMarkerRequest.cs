using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Markers
{
    public class InjectMarkerRequest : Request
    {
        public override string Method { get; } = "injectMarker";
        [JsonProperty("params")]
        public InjectMarkerParameter Parameter { get; }

        public InjectMarkerRequest(int id, InjectMarkerParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
