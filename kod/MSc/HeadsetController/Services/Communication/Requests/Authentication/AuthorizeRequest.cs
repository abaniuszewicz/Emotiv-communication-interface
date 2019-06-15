using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class AuthorizeRequest : Request
    {
        public override string Method { get; } = "authorize";
        [JsonProperty("params")]
        public AuthorizeParameter Parameter { get; }

        public AuthorizeRequest(int id, AuthorizeParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
