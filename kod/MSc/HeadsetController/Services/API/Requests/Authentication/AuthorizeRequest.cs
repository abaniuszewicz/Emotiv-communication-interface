namespace HeadsetController.Services.API.Requests.Authentication
{
    public class AuthorizeRequest : Request
    {
        public override string method { get; } = "authorize";
        public AuthorizeParameter @params { get; }

        public AuthorizeRequest(int id, AuthorizeParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
