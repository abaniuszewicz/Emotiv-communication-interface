using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.BCI
{
    public class TrainingRequest : Request
    {
        public override string Method { get; } = "training";
        [JsonProperty("params")]
        public TrainingParameter Parameter { get; }

        public TrainingRequest(int id, TrainingParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
