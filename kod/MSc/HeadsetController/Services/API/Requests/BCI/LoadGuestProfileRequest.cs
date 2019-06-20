namespace HeadsetController.Services.API.Requests.BCI
{
    public class LoadGuestProfileRequest : Request
    {
        public override string method { get; } = "loadGuestProfile";
        public LoadGuestProfileParameter @params { get; }

        public LoadGuestProfileRequest(int id, LoadGuestProfileParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
