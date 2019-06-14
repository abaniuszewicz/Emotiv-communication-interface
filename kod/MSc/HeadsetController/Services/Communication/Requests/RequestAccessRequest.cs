using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class RequestAccessRequest : Request
    {
        public override string Method { get; } = "requestAccess";
        [JsonProperty("params")]
        public RequestAccessParameter Parameter { get; }
        
        public RequestAccessRequest(int id, RequestAccessParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
