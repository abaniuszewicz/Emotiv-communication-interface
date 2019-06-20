namespace HeadsetController.Services.API.Requests.Authentication
{
    public class RequestAccessRequest : Request
    {
        public override string method { get; } = "requestAccess";
        public RequestAccessParameter @params { get; }
        
        public RequestAccessRequest(int id, RequestAccessParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
