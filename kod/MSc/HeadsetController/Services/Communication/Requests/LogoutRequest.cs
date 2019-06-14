using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class LogoutRequest : Request
    {
        public override string Method { get; } = "logout";
        [JsonProperty("params")]
        public LogoutParameter Parameter { get; }

        public LogoutRequest(int id, LogoutParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
