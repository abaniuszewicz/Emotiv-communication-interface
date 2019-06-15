using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.DataSubscription
{
    public class UnsubscribeRequest : Request
    {
        public override string Method { get; } = "unsubscribe";
        [JsonProperty("params")]
        public UnsubscribeParameter Parameter { get; }

        public UnsubscribeRequest(int id, UnsubscribeParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
