namespace HeadsetController.Services.API.Requests.Authentication
{
    public class GetUserLoginRequest : Request
    {
        public override string method { get; } = "getUserLogin";

        public GetUserLoginRequest(int id) : base(id)
        {
        }
    }
}
