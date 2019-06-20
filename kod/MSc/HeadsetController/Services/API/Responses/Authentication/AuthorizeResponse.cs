using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Authentication
{
    public class AuthorizeResponse : IResult
    {
        public string cortexToken { get; }
        public object warning { get; }

        [JsonConstructor]
        private AuthorizeResponse(string cortexToken, object warning)
        {
            this.cortexToken = cortexToken;
            this.warning = warning;
        }
    }
}