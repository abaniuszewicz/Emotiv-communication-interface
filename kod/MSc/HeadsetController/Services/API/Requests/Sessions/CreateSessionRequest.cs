namespace HeadsetController.Services.API.Requests.Sessions
{
    public class CreateSessionRequest : Request
    {
        public override string method { get; } = "createSession";
        public CreateSessionParameter @params { get; }

        public CreateSessionRequest(int id, CreateSessionParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
