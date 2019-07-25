namespace HeadsetController.Services.API.Requests.DataSubscription
{
    public class SubscribeRequest : Request
    {
        public override string method { get; } = "subscribe";
        public SubscribeParameter @params { get; }

        public SubscribeRequest(SubscribeParameter parameter)
        {
            @params = parameter;
        }
    }
}
