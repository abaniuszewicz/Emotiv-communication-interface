namespace HeadsetController.Services.API.Requests.Authentication
{
    public class GenerateNewTokenRequest : Request
    {
        public override string method { get; } = "generateNewToken";
        public GenerateNewTokenParameter @params { get; }

        public GenerateNewTokenRequest(int id, GenerateNewTokenParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
