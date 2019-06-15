using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.AdvancedBCI
{
    public class MentalCommandActiveActionRequest : Request
    {
        public override string Method { get; } = "mentalCommandActiveAction";
        [JsonProperty("params")]
        public MentalCommandActiveActionParameter Parameter { get; }

        public MentalCommandActiveActionRequest(int id, MentalCommandActiveActionParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
