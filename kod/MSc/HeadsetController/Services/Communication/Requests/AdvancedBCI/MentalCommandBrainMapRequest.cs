using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.AdvancedBCI
{
    public class MentalCommandBrainMapRequest : Request
    {
        public override string Method { get; } = "mentalCommandBrainMap";
        [JsonProperty("params")]
        public MentalCommandBrainMapParameter Parameter { get; }

        public MentalCommandBrainMapRequest(int id, MentalCommandBrainMapParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
