namespace HeadsetController.Services.API.Requests.Authentication
{
    public class GenerateNewTokenRequest : Request
    {
        public override string method { get; } = "generateNewToken";
        public GenerateNewTokenParameter @params { get; }

        public GenerateNewTokenRequest(GenerateNewTokenParameter parameter)
        {
            @params = parameter;
        }
    }
}
