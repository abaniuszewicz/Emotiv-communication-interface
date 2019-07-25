namespace HeadsetController.Services.API.Requests.DataSubscription
{
    public class UnsubscribeRequest : Request
    {
        public override string method { get; } = "unsubscribe";
        public UnsubscribeParameter @params { get; }

        public UnsubscribeRequest(UnsubscribeParameter parameter)
        {
            @params = parameter;
        }
    }
}
