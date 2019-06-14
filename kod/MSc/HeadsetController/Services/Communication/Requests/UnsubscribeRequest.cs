using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class UnsubscribeRequest : Request
    {
        public override string Method { get; } = "unsubscribe";
        [JsonProperty("params")]
        public UnsubscribeParameter Parameter { get; }

        public UnsubscribeRequest(int id, UnsubscribeParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
