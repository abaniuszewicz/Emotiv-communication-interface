namespace HeadsetController.Services.API.Requests.Sessions
{
    public class UpdateSessionRequest : Request
    {
        public override string method { get; } = "updateSession";
        public UpdateSessionParameter @params { get; }

        public UpdateSessionRequest(int id, UpdateSessionParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
