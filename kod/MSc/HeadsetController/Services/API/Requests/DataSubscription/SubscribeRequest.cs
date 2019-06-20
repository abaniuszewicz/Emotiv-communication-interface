namespace HeadsetController.Services.API.Requests.DataSubscription
{
    public class SubscribeRequest : Request
    {
        public override string method { get; } = "subscribe";
        public SubscribeParameter @params { get; }

        public SubscribeRequest(int id, SubscribeParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
