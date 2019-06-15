using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.AdvancedBCI
{
    public class GetTrainingTimeRequest : Request
    {
        public override string Method { get; } = "getTrainingTime";
        [JsonProperty("params")]
        public GetTrainingTimeParameter Parameter { get; }

        public GetTrainingTimeRequest(int id, GetTrainingTimeParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
