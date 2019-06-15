using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.BCI
{
    public class GetCurrentProfileRequest : Request
    {
        public override string Method { get; } = "getCurrentProfile";
        [JsonProperty("params")]
        public GetCurrentProfileParameter Parameter { get; }

        public GetCurrentProfileRequest(int id, GetCurrentProfileParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
