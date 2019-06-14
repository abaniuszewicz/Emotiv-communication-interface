using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class CreateSessionRequest : Request
    {
        public override string Method { get; } = "createSession";
        [JsonProperty("params")]
        public CreateSessionParameter Parameter { get; }

        public CreateSessionRequest(int id, CreateSessionParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
