namespace HeadsetController.Services.API.Requests.BCI
{
    public class GetCurrentProfileRequest : Request
    {
        public override string method { get; } = "getCurrentProfile";
        public GetCurrentProfileParameter @params { get; }

        public GetCurrentProfileRequest(GetCurrentProfileParameter parameter)
        {
            @params = parameter;
        }
    }
}
