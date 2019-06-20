namespace HeadsetController.Services.API.Requests.BCI
{
    public class SetupProfileRequest : Request
    {
        public override string method { get; } = "setupProfile";
        public SetupProfileParameter @params { get; }

        public SetupProfileRequest(int id, SetupProfileParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
