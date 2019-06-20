using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Authentication
{
    public class GenerateNewTokenResponse : IResult
    {
        public string cortexToken { get; }

        [JsonConstructor]
        private GenerateNewTokenResponse(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}