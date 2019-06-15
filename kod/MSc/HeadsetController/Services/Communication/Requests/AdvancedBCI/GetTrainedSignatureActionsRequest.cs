using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.AdvancedBCI
{
    public class GetTrainedSignatureActionsRequest : Request
    {
        public override string Method { get; } = "getTrainedSignatureActions";
        [JsonProperty("params")]
        public GetTrainedSignatureActionsParameter Parameter { get; }

        public GetTrainedSignatureActionsRequest(int id, GetTrainedSignatureActionsParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
