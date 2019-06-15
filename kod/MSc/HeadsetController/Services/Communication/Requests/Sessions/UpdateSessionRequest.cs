using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Sessions
{
    public class UpdateSessionRequest : Request
    {
        public override string Method { get; } = "updateSession";
        [JsonProperty("params")]
        public UpdateSessionParameter Parameter { get; }

        public UpdateSessionRequest(int id, UpdateSessionParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
