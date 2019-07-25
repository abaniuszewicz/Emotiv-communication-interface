namespace HeadsetController.Services.API.Requests.BCI
{
    public class SetupProfileRequest : Request
    {
        public override string method { get; } = "setupProfile";
        public SetupProfileParameter @params { get; }

        public SetupProfileRequest(SetupProfileParameter parameter)
        {
            @params = parameter;
        }
    }
}
