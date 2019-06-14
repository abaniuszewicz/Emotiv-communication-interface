using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class LoginRequest : Request
    {
        public override string Method { get; } = "login";
        [JsonProperty("params")]
        public LoginParameter Parameter { get; }


        public LoginRequest(int id, LoginParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
