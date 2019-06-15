using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class RequestAccessRequest : Request
    {
        public override string Method { get; } = "requestAccess";
        public RequestAccessParameter @params { get; }
        
        public RequestAccessRequest(int id, RequestAccessParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}
