namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class GetUserLoginRequest : Request
    {
        public override string Method { get; } = "getUserLogin";

        public GetUserLoginRequest(int id) : base(id)
        {
        }
    }
}
