namespace HeadsetController.Services.API.Requests.Sessions
{
    public class UpdateSessionRequest : Request
    {
        public override string method { get; } = "updateSession";
        public UpdateSessionParameter @params { get; }

        public UpdateSessionRequest(UpdateSessionParameter parameter)
        {
            @params = parameter;
        }
    }
}
