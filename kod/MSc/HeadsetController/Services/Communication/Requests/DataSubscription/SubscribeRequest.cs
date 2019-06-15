using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.DataSubscription
{
    public class SubscribeRequest : Request
    {
        public override string Method { get; } = "subscribe";
        [JsonProperty("params")]
        public SubscribeParameter Parameter { get; }

        public SubscribeRequest(int id, SubscribeParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
