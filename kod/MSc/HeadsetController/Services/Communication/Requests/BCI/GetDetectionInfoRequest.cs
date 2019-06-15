using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.BCI
{
    public class GetDetectionInfoRequest : Request
    {
        public override string Method { get; } = "getDetectionInfo";
        [JsonProperty("params")]
        public GetDetectionInfoParameter Parameter { get; }

        public GetDetectionInfoRequest(int id, GetDetectionInfoParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
